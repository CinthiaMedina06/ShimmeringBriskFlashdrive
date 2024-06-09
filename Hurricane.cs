using static System.Console;
public class Hurricane{
   public void HurricaneCat() {
     WriteLine("Enter the wind speed in mph");
     var input = ReadLine();
     double mph;
     double.TryParse(input, out mph);
      WriteLine(mph >= 74 && mph <= 95 ? "Category One Hurricane": mph>=96 && mph <= 110 ? "Category Two Hurricane" :mph >=111 && mph <= 129 ? "Category Three": mph>=130 && mph <= 156 ? "Category Four Hurricane" : mph>=157 ? "Category Five Hurricane": "Not a hurricane");
   
   }
}
      