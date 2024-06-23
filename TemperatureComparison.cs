using System.Diagnostics.Metrics;
using System;
using static System.Console;
public class TemperatureComparison
{
    public string Comparison(
      int _prevNum = 0,
      int _counter = 1,
      bool _isOrdered = true,
      string _strNums = "",
      int _rllyord = 0,
      double avgSum = 0
    )
    {

        int prevNum = _prevNum;
        int counter = _counter;
        bool isOrdered = _isOrdered;
        string strNums = _strNums;
        int rllyord = _rllyord;

        //input
        WriteLine("Enter temperature");
        var temp = ReadLine();

        if (int.TryParse(temp, out int tempF))
        {
            if (tempF > 130 || tempF < -30)
            {
                WriteLine("Temperature " + tempF.ToString() + " is invalid, Please enter a valid temperature between -30 and 130");
                Comparison(prevNum, counter, isOrdered, strNums, rllyord, avgSum);
            }
            strNums = String.Concat(strNums, tempF.ToString(), " ,");
            avgSum = avgSum + tempF;

            if (counter < 5)
            {
                if (counter >= 1 && tempF >= prevNum && isOrdered == true)
                {
                    isOrdered = true;

                }
                else if (counter >= 1 && tempF <= prevNum && prevNum>0 && isOrdered == true)
                {
                    isOrdered = false;
                    rllyord++;
                }

                counter++;

                prevNum = tempF;


                Comparison(prevNum, counter, isOrdered, strNums, rllyord, avgSum);
                //Clear();
            }
            else
            {   

                if  (rllyord < 3 && rllyord >1 && isOrdered==false)

                {
                    WriteLine("It's a mixed bag");

                }
                else
                {
                    if (tempF > prevNum)
                    {
                        WriteLine("Getting warmer");
                    }
                    else if (tempF < prevNum)
                    {
                        WriteLine("Getting cooler");
                    }

                }
                //averaging

                WriteLine("5-day temperatures " + "[" + strNums + "]");
                double nvat = avgSum / 5;
                WriteLine("Average temperature " + nvat.ToString() + " degrees");

            }



        }
        else
        {
            WriteLine("Only numbers are allowed");
            Comparison(prevNum, counter, isOrdered, strNums, rllyord, avgSum);
        }
        return "complete";

    }

}