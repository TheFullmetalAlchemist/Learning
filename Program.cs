using System;
using System.Collections;
using System.Globalization;
using System.Security.Cryptography;
namespace WebApplication1;


public class Program()
{
  public static void Main(string[] args){
    var season = Season.winter;


    switch(season){
      case Season.autumn:
        System.Console.WriteLine("this is autumn season");
        break;
      
      case Season.winter:
      System.Console.WriteLine("this is winter");
      break;

      default:
      System.Console.WriteLine("dont know what season");
      break;
    }    
  }
}

