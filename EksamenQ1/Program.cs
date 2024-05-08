namespace Eksamen2024;

class Program
{
    static void Main(string[] args)
    {
        // Oppgave A:
        int myInt = 11;
        float myFloat = 3.14f;
        double muDouble = 3.791827293824728;
        char myChar = 'S';
        string myString = "hei på deg";
        
        // skriver ut verdier med datatypene deres
        Console.WriteLine("Oppgave A");
        Console.WriteLine($"{myInt} er en {myInt.GetType()}");
        Console.WriteLine($"{myFloat} er en {myFloat.GetType()}");
        Console.WriteLine($"{muDouble} er en {muDouble.GetType()}");
        Console.WriteLine($"{myChar} er en {myChar.GetType()}");
        Console.WriteLine($"{myString} er en {myString.GetType()}");
        
        // Oppgave B:
        Console.WriteLine("Oppgave B");
        Console.WriteLine("Skriv inn en setning");
        string inputSentence = Console.ReadLine();
        int WordCount = inputSentence.Split(' ', StringSplitOptions.RemoveEmptyEntries).Length;
        Console.WriteLine($" ord i setningen: {inputSentence} er: {WordCount}");
        
        // oppgave c:
        
        Console.WriteLine("Oppgave C");
        Console.WriteLine($"Reversert streng fra oppgave a er: {ReversedString(inputSentence)}");
        
        // Oppgave D:
        Console.WriteLine("oppgave D:");
        double[] doubleArray = { 1.1, 5.421, 7.98, 8.02, 2, 555 };
        Console.WriteLine("tall i arrayen;");
        foreach (var num in doubleArray)
        {
            Console.WriteLine(num);
        }
        
        // Oppgave E:
        Console.WriteLine("Oppgave E");
        Console.WriteLine($"Summen av tallene i arrayen er: {CalculateSum(doubleArray)}");
        
        
        // oppgave C:
        static string ReversedString(string input)
        {
            char[] charArray = input.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
        
        // Oppgave E:
        static double CalculateSum(double[] arr)
        {
            double sum = 0;
            foreach (var num in arr)
            {
                sum += num;
            }

            return sum;
        }
    }
}