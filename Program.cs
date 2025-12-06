using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== CSProjectGroup10: Patient Health Check ===");

        // Create a Patient object
        Patient p = new Patient();

        // Assign sample data (you can change these)
        p.FirstName = "John";
        p.LastName = "Doe";
        p.Weight = 72;   // kg
        p.Height = 175;  // cm

        // Display patient info
        Console.WriteLine($"\nPatient: {p.FirstName} {p.LastName}");
        Console.WriteLine($"Weight: {p.Weight} kg");
        Console.WriteLine($"Height: {p.Height} cm");

        // Run BMI calculation
        p.CalculateBMI();

        // Run Blood Pressure check (you can change numbers)
        p.CheckBloodPressure(120, 80);

        Console.WriteLine("\n=== End of Report ===");
        Console.ReadLine();
    }
}
