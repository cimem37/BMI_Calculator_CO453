using System;

class BMI {
    static void Main(string[] args) {
        Console.WriteLine("- - - - - - - - - - - - - - - - - - - - -");
        Console.WriteLine("BMI *Body Mass Index* Calculator By Bruno");
        Console.WriteLine("- - - - - - - - - - - - - - - - - - - - -");

        Console.Write("Please enter your height in centimeters: ");
        double height;
        if (!double.TryParse(Console.ReadLine(), out height) || height <= 0) {
            Console.WriteLine("[ERROR] Invalid height input. Please enter a positive numerical value.");
            return;
        }
        height /= 100; // Convert height to meters

        Console.Write("Please enter your weight in kilograms: ");
        double weight;
        if (!double.TryParse(Console.ReadLine(), out weight) || weight <= 0) {
            Console.WriteLine("[ERROR] Invalid weight input. Please enter a positive numerical value.");
            return;
        }

        double bmi = weight / (height * height); // Calculate BMI

        Console.WriteLine("Your BMI is " + bmi.ToString("0.00"));

        string status = "";
        if (bmi < 18.5) {
            status = "Underweight";
        }
        else if (bmi < 25.0) {
            status = "Normal";
        }
        else if (bmi < 30.0) {
            status = "Overweight";
        }
        else if (bmi < 35.0) {
            status = "Obese Class I";
        }
        else if (bmi < 40.0) {
            status = "Obese Class II";
        }
        else {
            status = "Obese Class III";
        }

        Console.WriteLine("Weight status: " + status);
        Console.Write("The result is based on the World Health Organization formula");
        Console.Write("Thank you for using the application");
    }
}
