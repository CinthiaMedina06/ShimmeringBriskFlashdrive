using static System.Console;
public class GreenvileFair {
  public void GreenvilleRevenue (){
    
   
    int revExpected = 10650;
    WriteLine("\n**********************************");
    WriteLine("* The stars shine in Greenville. *");
    WriteLine("**********************************");
    WriteLine("\nPlease Enter the following number below from the following menu:");
    WriteLine("\n1. CALCULATE Greenville Revenue Year-Over-Year");
    WriteLine("2. Exit");
    var num = ReadLine();
    if (num == "1"){
      WriteLine("Enter the number of contestants last year");
      var prevContestants = ReadLine();
      WriteLine("Enter the number of contestants this year");
      var currentContestants = ReadLine();
      Clear();
      WriteLine("Last year's competition had {0} contestants, and this year's has {1} contestants", prevContestants, currentContestants);
      WriteLine("Revenue expected this year is {0}", revExpected.ToString("C"));
      
      if (int.TryParse(prevContestants, out int prevCont) && int.TryParse(currentContestants, out int currentCont))
      if (prevCont < currentCont){
        
        WriteLine("It is true that this year's competition is bigger than last year's.");
      }
      else if (prevCont > currentCont) 
      
        WriteLine("It is false that this year's competition is bigger than last year's.");
       GreenvilleRevenue ();
    }
    else WriteLine("Thank you for using the Greenville Revenue App, good-bye!");
    
   
    
    
   
  }
}