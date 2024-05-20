using System;

class Program {
  public static void Main (string[] args) {
    Concatenate ("Program Name:","PersonalInfo");
    Concatenate("Sally", "Smith");
    string birthDate = "06/24/1992";
    Console.WriteLine (birthDate);
    Concatenate("work","555-555-5555");
    Concatenate("cell","235-555-5855");
    }

  private static void Concatenate(string string1, string string2) {
    Console.WriteLine (string1 + " " + string2);
  }
}