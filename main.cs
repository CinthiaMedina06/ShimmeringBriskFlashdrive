using System;

class Program {
  public static void Main (string[] args) {
    Console.WriteLine ("PersonalInfo");
    Concatenate("Robert", "Hall");
    string birthDate = "2/27/1949";
    Console.WriteLine (birthDate);
    Concatenate("work","000-444-0101");
    Concatenate("cell","000-444-0189");
    }

  private static void Concatenate(string string1, string string2) {
    Console.WriteLine (string1 + " " + string2);
  }
}