using static System.Console;
public class GreenvileFair {
  public void GreenvilleRevenue (){
    
   var fee = 25;
    
    WriteLine("\n**********************************");
    WriteLine("* The stars shine in Greenville. *");
    WriteLine("**********************************");
    WriteLine("\nPlease Enter the following number below from the following menu:");
    WriteLine("\n1. CALCULATE Greenville Revenue Year-Over-Year");
    WriteLine("2. Exit");
    var num = ReadLine();
    if (num == "1"){
      Clear();
      WriteLine("Enter the number of contestants last year");
      var prevContestants = ReadLine();
      WriteLine("Enter the number of contestants this year");
      var currentContestants = ReadLine();
      
      
      WriteLine("Last year's competition had {0} contestants, and this year's has {1} contestants", prevContestants, currentContestants);
      
      if (double.TryParse(prevContestants, out double prevCont) && double.TryParse(currentContestants, out double currentCont)){
        double revExpected = currentCont * fee;
        WriteLine("\nRevenue expected this year is {0}", revExpected.ToString("C"));
        
        if (currentCont > prevCont && currentCont < 2 * prevCont)

            WriteLine("\nThe competition is bigger than ever!");
          
            else if (currentCont > 2 * prevCont) 

            WriteLine("\nThe competition is more than twice as big this year!");
        
        else WriteLine("\nA tighter race this year! Come out and cast your vote!");
        
        } 
      }
    else WriteLine("Thank you for using the Greenville Revenue App, good-bye!");
  }
}