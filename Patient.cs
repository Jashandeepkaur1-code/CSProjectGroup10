using System;

public class Patient
{
    // ----- PUBLIC PROPERTIES (PascalCase) -----
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public double Weight { get; set; }   // in kg
    public double Height { get; set; }   // in cm


    // ----- BMI CALCULATION METHOD -----
    public void CalculateBMI()
    {
        // Convert height from cm to meters
        double heightInMeters = Height / 100;

        // Formula: BMI = kg / (m * m)
        double bmi = Weight / (heightInMeters * heightInMeters);

        Console.WriteLine($"\nBMI: {bmi:F2}");

        // Determine BMI category
        if (bmi < 18.5)
        {
            Console.WriteLine("BMI Status: Underweight");
        }
        else if (bmi >= 18.5 && bmi < 25)
        {
            Console.WriteLine("BMI Status: Normal weight");
        }
        else if (bmi >= 25 && bmi < 30)
        {
            Console.WriteLine("BMI Status: Overweight");
        }
        else
        {
            Console.WriteLine("BMI Status: Obese");
        }
    }


    // ----- BLOOD PRESSURE CHECK METHOD -----
    public void CheckBloodPressure(int systolic, int diastolic)
    {
        Console.WriteLine($"\nBlood Pressure: {systolic}/{diastolic}");

        if (systolic < 120 && diastolic < 80)
        {
            Console.WriteLine("Blood Pressure Status: Normal");
        }
        else if (systolic >= 120 && systolic < 130 && diastolic < 80)
        {
            Console.WriteLine("Blood Pressure Status: Elevated");
        }
        else if (systolic >= 130 && systolic < 140 || diastolic >= 80 && diastolic < 90)
        {
            Console.WriteLine("Blood Pressure Status: High BP (Stage 1)");
        }
        else if (systolic >= 140 || diastolic >= 90)
        {
            Console.WriteLine("Blood Pressure Status: High BP (Stage 2)");
        }
        else
        {
            Console.WriteLine("Blood Pressure Status: Consult doctor");
        }
    }
}
