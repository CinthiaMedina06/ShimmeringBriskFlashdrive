using static System.Console;
public class TwitterMessage{
  public void Twitter() {
    const int MAX_CHARS = 140;
    int counter = 0;
    
    WriteLine("Enter your message");
    string message = ReadLine();
    foreach (char c in message)
      {
        counter ++;
        }
    if (counter <= MAX_CHARS)
      WriteLine("Posted");
    else WriteLine("Rejected");
  }
}