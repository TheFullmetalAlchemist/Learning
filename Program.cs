using System;
using System.Collections;
using System.Globalization;
using System.Security.Cryptography;
using Microsoft.VisualBasic;
namespace WebApplication1;


public class Program()
{
  public static void Main(string[] args){
    
    var output = Stringutility.Summarizetext("This is going to be a really long sentence");
    System.Console.WriteLine(output);
    }    
  }

