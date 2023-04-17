namespace GarbleSort
{
    internal class Program
    {
        static int[] orderedNumArray = new int[9] { 7, 9, 6, 4, 1, 3, 5, 8, 2 };

        static void Main(string[] args)
        {
            try
            {
                string inputString = string.Empty;
                string resultString = "Start";
                string resultArray = string.Empty;

                Console.WriteLine("Ordered Number: 7, 9, 6, 4, 1, 3, 5, 8, 2");
                Console.WriteLine("Enter E to exit.");

                do
                {
                    Console.WriteLine("\nNEW: Please input at least two numbers delimited by comma.");
                    string input = Console.ReadLine();

                    if (input == "E")
                        break;

                    resultString = GarbleSort(input, out resultArray);

                    if (!string.IsNullOrEmpty(resultArray))
                        Console.WriteLine(resultArray);
                    else
                        Console.WriteLine(resultString);
                }
                while (!string.IsNullOrEmpty(resultString));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }
        }

        private static string GarbleSort(string rawInput, out string resultArray)
        {
            try
            {
                resultArray = string.Empty;

                if (string.IsNullOrEmpty(rawInput))
                    return "The provided input is empty.";

                var inputSplit = rawInput.Split(",");

                if (inputSplit.Length == 1)
                    return "The provided input should be more than 1.";

                List<int> result = new List<int>();

                foreach (int o in orderedNumArray)
                {
                    foreach (string i in inputSplit)
                    {
                        if (!int.TryParse(i, out int intVal))
                            return "The provided input must only contain numbers between 1 to 9.";

                        if (intVal < 0 || intVal > 9)
                            return "The provided input must only contain numbers between 1 to 9.";

                        if (o == intVal)
                            result.Add(intVal);
                    }
                }

                if (result.Any())
                    resultArray = "{ " + string.Join(", ", result) + " }";

                return "Done";
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}