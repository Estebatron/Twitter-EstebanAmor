using System;

class Program {
  public static void Main (string[] args) {
    Console.WriteLine ("Write your tweet");
  var tweet = Console.ReadLine();
if (tweet.Length <= 140){
  Console.WriteLine("Posted");
   }
else{
  Console.WriteLine("Rejected");
  };
  }
}