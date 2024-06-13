
   using static System.Console;
   public class Perfect{
     public void PerfectNums() {
       WriteLine("Input number");
       var input = ReadLine();
       int number;

       if (int.TryParse(input, out number)){
         int sum = 0;
        
         for (int i = 1; i < number; i++){
           
             if (number % i == 0){
               sum += i;
               }
           
           }
        
         if (sum == number ){
           WriteLine("Perfect Number");
           }
         else WriteLine ("Not A Perfect Number");
         }
       else WriteLine("Only numbers are allowed");
       } 
     }