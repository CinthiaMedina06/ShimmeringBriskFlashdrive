using System;
public class MoveEstimator {
  public void Estimator () {
    const int MOVE_FEE = 200;
    const int PER_MILE = 2;
    const int PER_HOUR = 150;
    
    Console.WriteLine ("Enter number of hours traveled");
    var h = Console.ReadLine();
    
    Console.WriteLine ("Enter number of miles traveled");
    var m = Console.ReadLine();
    var totalHours = 0.00;
    var totalMiles = 0.00;
    
    
    if (double.TryParse(m, out totalMiles) && double.TryParse(h, out totalHours)) {
      var total = (totalMiles * PER_MILE) + (totalHours * PER_HOUR) + MOVE_FEE;
      Console.WriteLine("Total price $" + total);
      }
    else {Console.WriteLine("Only numbers are allowed");
      }
  }
}
