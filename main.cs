using System;

class Program {
  public static void Main (string[] args) {
    Console.WriteLine ("PersonalInfo");
    Concatenate("Chris", "Johnson");
    string birthDate = "12/01/1987";
    Console.WriteLine (birthDate);
    Concatenate("work","000-222-0101");
    Concatenate("cell","000-222-0189");
    }

  private static void Concatenate(string string1, string string2) {
    Console.WriteLine (string1 + " " + string2);
  }
}