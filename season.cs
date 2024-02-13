using System.Reflection.PortableExecutable;
using System.Runtime.InteropServices.Marshalling;
using Microsoft.AspNetCore.Components.Web;

namespace WebApplication1;

public enum Season
{
    summer,
    winter,
    autumn

}

public class Sample()
{
    public void Reiner(){
        for(int i=0;i<10;i++){
            if(i%2==0)
                System.Console.WriteLine(i);
        }
    } 
}
public class Writename(){
public void Eren(){
     var name="eren yeager";
    // for(int i=0;i<name.Length;i++){
    //     System.Console.WriteLine(name[i]);
    foreach(var character in name){
        System.Console.WriteLine(character);
    }
    }
public void Mikasa(){
    
    while(true){
      System.Console.WriteLine(" hi enter your name :");
      var input = System.Console.ReadLine();
        if (!string.IsNullOrEmpty(input)){
            System.Console.WriteLine("your name is "+ input);
            continue;
        }
        break;
    }
}
public void Bertolo(){
    var random = new Random();
    var buffer = new char[10];
    for (var i =0; i <10;i++)
    buffer[i]=((char)('a'+random.Next(0,26)));
    var password = new string(buffer);
    System.Console.WriteLine(password);
}
public void Warhammer(){
    var numbers = new int[] {0,1,9,2,4,16};// length indexof clear copy
    System.Console.WriteLine("number length is:"+ numbers.Length);

    var index = Array.IndexOf(numbers,9);
    System.Console.WriteLine(index);

    System.Console.WriteLine("Effect of clear");
    Array.Clear(numbers, 0, 2);
    foreach(var n in numbers)
    System.Console.WriteLine(n);

    System.Console.WriteLine();
    System.Console.WriteLine("Effect of copy");
    var another = new int[3];
    Array.Copy(numbers, another, 3);
    foreach(var n in another)
    System.Console.WriteLine(n);

    Array.Sort(numbers);
    foreach(var n in numbers)
    System.Console.WriteLine("Effect of sort:"+n);
    Array.Reverse(numbers);
    foreach(var n in numbers)
    System.Console.WriteLine("Effect of reverse:"+n);
}
}
