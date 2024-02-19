using System.ComponentModel;
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
public class Writename(){
    
public void Reiner(){
        for(int i=0;i<10;i++){
            if(i%2==0)
                System.Console.WriteLine(i);
        }
    } 
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
public void Connie(){
    var numbers= new List<int>{1,2,3,4};
    numbers.Add(1);
    numbers.AddRange(new int[3]{5,6,7});
    foreach(var n in numbers)
        System.Console.WriteLine(n);
    System.Console.WriteLine();
    System.Console.WriteLine(numbers.IndexOf(5));   
    System.Console.WriteLine("count is"+numbers.Count);
    numbers.Remove(1);
    foreach(var n in numbers)
        System.Console.WriteLine("removing start of 1: "+n);

    System.Console.WriteLine("count is"+numbers.Count);
    for (var i=0; i<numbers.Count;i++){
        if(numbers[i]==1)
            numbers.Remove(numbers[i]);
        }
        foreach(var n in numbers)
        System.Console.WriteLine(n);

        numbers.Clear();
    System.Console.WriteLine(numbers.Count);
    }
    public void Levi(){
        var datetime = new DateTime(2024,02,15);
        var result = DateTime.Now;
        var today = DateTime.Today;
        var yesterday = result.AddDays(-1);
        System.Console.WriteLine(yesterday);
    }
    public void Annie(){
        var fullname = "Mosh hamadani";
        var trim = fullname.Trim().ToUpper();
        System.Console.WriteLine("trim is : '{0}' ",trim);

        var index = fullname.IndexOf(' ');
        var firstname = fullname.Substring(0,index);
        System.Console.WriteLine(firstname);
        var lastname = fullname.Substring(index + 1);
        System.Console.WriteLine(lastname);

        var names = fullname.Split(' ');
        System.Console.WriteLine(names[0]);
        System.Console.WriteLine(names[1]);

        System.Console.WriteLine(fullname.Replace("Mosh","Moshfegh"));

        if(string.IsNullOrWhiteSpace(" ")){
            System.Console.WriteLine("Invalid");
        }
        var str = "25";
        var age = Convert.ToByte(str);
        System.Console.WriteLine(age);

        var price = 29.95f;
        System.Console.WriteLine(price.ToString("C1"));
    }
}