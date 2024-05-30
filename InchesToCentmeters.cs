
using static System.Console;
public class InchesToCentmeters{
  public void InchtoCm () {
    const double INCH = 2.54;
    WriteLine("Enter number of inches to convert to centimeters");
    var x = ReadLine();

    var doubleValue = 0.00;
    if (double.TryParse(x, out doubleValue)) {
      var cm = doubleValue * INCH;
      WriteLine("{0}{1}{2}{3}", x, " inches is ", cm, " centimeters");
    }
    else
    {
      WriteLine("Only numbers are allowed");
      InchtoCm();
    }

    }
}