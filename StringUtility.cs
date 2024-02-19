namespace WebApplication1;

public class Stringutility
{
    public static string Summarizetext(string sentence, int maxlength=20){

        if (sentence.Length < maxlength)
            return sentence;

            var words = sentence.Split(' ');
            var totalcharacters = 0;
            var summary = new List<string>();

            foreach (var word in words){
                summary.Add(word);
                totalcharacters += word.Length +1;
                if (totalcharacters > maxlength)
                {
                    break;
                }          
            }
            return string.Join(" ",summary)+"...";        
    }
}
