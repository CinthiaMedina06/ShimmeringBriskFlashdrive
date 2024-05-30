
using static System.Console;
public class InchesToCentmeters{
  public void InchtoCm () {
    const double INCH = 2.54;
    double x = 15994;
    var cm = INCH * x;
      WriteLine("{0}{1}{2}{3}", x, " inches is ", cm, " centimeters");
    }
}