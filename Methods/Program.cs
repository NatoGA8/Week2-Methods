using System;

class Methods
{
    static void Main(string[] args)
    {
        CreateMenu();
    }

    static void CreateMenu()
    {
        try
        {
            // Display menu options
            Console.Clear();
            Console.WriteLine("Main Menu");
            Console.WriteLine("1. Say Hello");
            Console.WriteLine("2. Add Numbers");
            Console.WriteLine("3. Calculate Rectangle Area");
            Console.WriteLine("4. Exit");
            Console.Write("Choose an option: ");

            // Get user's choice
            string choice = Console.ReadLine();

            // Switch statement to handle user's choice
            switch (choice)
            {
                case "1":
                    SayHello();
                    break;
                case "2":
                    AddNumbers();
                    break;
                case "3":
                    CalculateRectangleArea();
                    break;
                case "4":
                    Console.WriteLine("Exiting...");
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
        catch (Exception ex)
        {
            // Handle any errors that occur during menu creation
            Console.WriteLine($"Error: {ex.Message}");
        }
    }

    // Method to say hello
    static void SayHello()
    {
        Console.WriteLine("Hello, world!");
    }

    // Method to add two numbers
    static void AddNumbers()
    {
        try
        {
            Console.Write("Enter the first number: ");
            int firstNumber = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the second number: ");
            int secondNumber = Convert.ToInt32(Console.ReadLine());

            int result = firstNumber + secondNumber;
            Console.WriteLine($"The result is: {result}");
        }
        catch (FormatException ex)
        {
            // Handle invalid number input
            Console.WriteLine($"Input Error: {ex.Message}");
        }
    }

    // Method to calculate the area of a rectangle
    static void CalculateRectangleArea()
    {
        try
        {
            Console.Write("Please enter the rectangle's length: ");
            double length = Convert.ToDouble(Console.ReadLine());

            Console.Write("Please enter the rectangle's width: ");
            double width = Convert.ToDouble(Console.ReadLine());

            // Call method to calculate area and store the result
            double area = CalculateArea(length, width);

            // Output the result
            Console.WriteLine($"The area of the rectangle is: {area}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }

    // Method to calculate area of a rectangle
    static double CalculateArea(double length, double width)
    {
        double area = length * width;
        return area;
    }
}
