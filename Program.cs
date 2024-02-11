using System;
using System.Globalization;
using System.Security.Cryptography;
namespace WebApplication1;

public class Person(){
  public int Age;
}


public class Program()
{
  public static void Main (string[] args){
  int hour=12;

  if(hour >0 && hour<12){
    System.Console.WriteLine("morning");
  }
  else if(hour>=12 && hour <18){
    System.Console.WriteLine("Evening");
  
  }
  else{
    System.Console.WriteLine("night");
  }

  }
}

