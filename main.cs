using System;

class InchesToCentimeters
{// open InchesToCentimeters

// declare a constant for the conversion of inches to centimeters
    const double CentimetersConversion = 2.54;

    public static void Main(string[] args){// open Main
// create a method that holds a parameter of the values in the unit tests. Then multiply that value by the constant to get the centimeters. If the calculated values of these numbers multiplied by the constant (cenitmeterConversion) are less than .01 the tests will pass.
        Inches(5,5 * CentimetersConversion);
        Inches(50, 50 * CentimetersConversion);;
        Inches(-15, -15 * CentimetersConversion);
        Inches(15994, 15994 * CentimetersConversion);
    }// close Main 
// the Inches method will take the parameters above  and calceulate the number in centimeters which should be the actual legnth in centimeters based on 2.54 conversion rate. 
    static void Inches(double inches, double actualCentimeters){// open inches
// store the conversion of inches * 2.54 and hold it in a variable called centimeters
        double centimeters = inches * CentimetersConversion;
// use string interpolation to print a statment that will show the inches and the centimeters.
        Console.WriteLine($"{inches} is equal to {centimeters} centimeters ");
// create an if else to check if the unit test passes or not. the method Math.Abs will check the absolute value both the centimeters and the actualCentimeters. If the absolute value of the centimeters is less than .01 the test passes.
      if (Math.Abs(centimeters - actualCentimeters) < 0.01){// open if
          Console.WriteLine("unit test passed");
      }// end if
      else
      {// open else
          Console.WriteLine("unit test failed");
      }// end else

    }// cose inches
}// close InchesToCentimeters