using System;

class Program {
  public static void Main (string[] args) {
    Console.WriteLine ("PersonalInfo");
    Concatenate("John", "Smith");
    string birthDate = "8/15/1978";
    Console.WriteLine (birthDate);
    Concatenate("work","000-111-0101");
    Concatenate("cell","000-111-0189");
    }

  private static void Concatenate(string string1, string string2) {
    Console.WriteLine (string1 + " " + string2);
  }
}