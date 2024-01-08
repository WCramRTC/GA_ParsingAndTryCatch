namespace GA_ParsingAndTryCatch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exploring Data Parsing and Try-Catch Blocks in C#");

            // Step 1: Error Handling with try-catch
            try
            {
                // Code that may throw exceptions
                int result = 10 / 0; // This will throw a DivideByZeroException
            }
            catch (Exception ex)
            {
                // Handle the exception
                Console.WriteLine($"An error occurred: {ex.Message}");
            }

            // Step 2: Parsing Data from Strings
            string numericString = "42";
            int parsedInt;

            try
            {
                parsedInt = int.Parse(numericString);
                Console.WriteLine($"Parsed integer: {parsedInt}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid format for parsing integer.");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Value is too large or too small for an integer.");
            }

            // Step 3: Parsing Integers
            string anotherNumericString = "123456789";
            int anotherParsedInt;

            try
            {
                anotherParsedInt = int.Parse(anotherNumericString);
                Console.WriteLine($"Parsed integer: {anotherParsedInt}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid format for parsing integer.");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Value is too large or too small for an integer.");
            }

            // Step 4: Parsing Doubles
            string doubleString = "3.14";
            double parsedDouble;

            try
            {
                parsedDouble = double.Parse(doubleString);
                Console.WriteLine($"Parsed double: {parsedDouble}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid format for parsing double.");
            }

            // Step 5: Parsing Multiple Values
            Console.Write("Enter an integer: ");
            string input1 = Console.ReadLine();

            Console.Write("Enter a double: ");
            string input2 = Console.ReadLine();

            int parsedInput1;
            double parsedInput2;

            try
            {
                parsedInput1 = int.Parse(input1);
                parsedInput2 = double.Parse(input2);

                Console.WriteLine($"Parsed integer: {parsedInput1}");
                Console.WriteLine($"Parsed double: {parsedInput2}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input format.");
            }

            // Step 6: Code Testing and Validation (No additional code needed)

            // Step 7: Code Readability and Documentation (No additional code needed)

            // Step 8: Submission (No additional code needed)
        } // main
         
    } // class

} // namespace
