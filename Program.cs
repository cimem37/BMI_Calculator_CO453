using System;

class BMI {
    static void Main(string[] args) {
        Console.WriteLine("- - - - - - - - - - - - - - - - - - - - -");
        Console.WriteLine("BMI *Body Mass Index* Calculator By Bruno");
        Console.WriteLine("- - - - - - - - - - - - - - - - - - - - -");

        Console.WriteLine("Please enter your height in centimeters:");
        double height = Convert.ToDouble(Console.ReadLine()) / 100; // Convert height to meters

        Console.WriteLine("Please enter your weight in kilograms:");
        double weight = Convert.ToDouble(Console.ReadLine());

        double bmi = weight / (height * height); // Calculate BMI

        Console.WriteLine("Your BMI is " + bmi);
        Console.WriteLine("The above result is based on the WHO (World Health Organisation) formula "); 
        if (bmi < 18.5) {
            Console.WriteLine("Status of result: Underweight");
        } else if (bmi >= 18.5 && bmi <= 24.9) {
            Console.WriteLine("Status of result: Normal");
        } else if (bmi >= 25.0 && bmi <= 29.9) {
            Console.WriteLine("Status of result: Overweight");
        } else if (bmi >= 30.0 && bmi <= 34.9) {
            Console.WriteLine("Status of result: Obese Class I");
        } else if (bmi >= 35.0 && bmi <= 39.9) {
            Console.WriteLine("Status of result: Obese Class II");
        } else {
            Console.WriteLine("Status of result: Obese Class III");
        }
    }
}
