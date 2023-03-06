using System;

class BMI {
    static void Main(string[] args) {
        Console.WriteLine("- - - - - - - - - - - - - - - - - - - - -");
        Console.WriteLine("BMI *Body Mass Index* Calculator By Bruno");
        Console.WriteLine("- - - - - - - - - - - - - - - - - - - - -");

        Console.WriteLine("Please enter your height ( in cm ):");
        double height = Convert.ToDouble(Console.ReadLine()) / 100; // Convert height to meters

        Console.WriteLine("Please enter your weight ( in kg ):");
        double weight = Convert.ToDouble(Console.ReadLine());

        double bmi = weight / (height * height); // Calculate BMI

        Console.WriteLine("Your BMI accordingly is : " + bmi);
    }
}
