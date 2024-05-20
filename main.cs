using System;

class Program {
  public static void Main (string[] args) {
    Console.WriteLine ("PersonalInfo");
    Concatenate("Lucinda", "Potter");
    string birthDate = "6/24/1992";
    Console.WriteLine (birthDate);
    Concatenate("work","000-000-0101");
    Concatenate("cell","000-000-0189");
    }

  private static void Concatenate(string string1, string string2) {
    Console.WriteLine (string1 + " " + string2);
  }
}