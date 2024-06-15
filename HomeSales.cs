using static System.Console;
 public class HomeSales{
   public void HolidayHomes( 
     int prevD = 0, 
     int prevE = 0,
     int prevF = 0
     ) 
   {
     
     WriteLine("------------------------");
     //input
     WriteLine("Enter salesperson initial");
     var initial = ReadLine();
    
     //control
     if (initial.ToLower() == "z"){
       return;
     }
     
     if (initial.ToLower() != "d" && initial.ToLower() != "e" && initial.ToLower() != "f"){
        WriteLine("Error, invalid salesperson selected, please try again");
       HolidayHomes(prevD,prevE,prevF);
     }
     
     //Input
     WriteLine("Enter sales amount");
     var sales = ReadLine();
     WriteLine("------------------------");
     
    //check if is valid number
    if (int.TryParse(sales, out int number))
     {
        switch (initial.ToLower())
         {
            case "d": 
                prevD += number;
                break;
            case "e":
               prevE += number;
               break;
             case "f":
               prevF += number;
               break;
          }
      }

    //grand total
     Clear();
     WriteLine("Total for D: {0}", prevD.ToString("C"));
     WriteLine("Total for E: {0}", prevE.ToString("C"));
     WriteLine("Total for F: {0}", prevF.ToString("C"));
     WriteLine("------------------------");
     WriteLine("Grand Total: {0}", (prevD + prevE + prevF).ToString("C"));
     WriteLine("------------------------");
     WriteLine("Highest Sales: {0}", prevD > prevE && prevD > prevF ? "D" : prevE > prevF ? "E" : "F");
     
     HolidayHomes(prevD,prevE,prevF);

   }
}
   
