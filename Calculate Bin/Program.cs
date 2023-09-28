using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введiть десяткове число: ");
        int decimalNumber = int.Parse(Console.ReadLine());

        Console.WriteLine($"Двiйкова система: {DecimalToBaseN(decimalNumber, 2)}");
        Console.WriteLine($"Вiсiмкова система: {DecimalToBaseN(decimalNumber, 8)}");
        Console.WriteLine($"Шiстнадцяткова система: {DecimalToBaseN(decimalNumber, 16)}");

        Console.ReadLine();
    }

    static string DecimalToBaseN(int decimalNumber, int baseN)
    {
        if (baseN < 2 || baseN > 16)
        {
            throw new ArgumentException("Підтримуються тiльки системи з основами від 2 до 16.");
        }

        string result = "";
        while (decimalNumber > 0)
        {
            int remainder = decimalNumber % baseN;
            result = ToBaseNCharacter(remainder) + result;
            decimalNumber /= baseN;
        }

        return result;
    }

    static char ToBaseNCharacter(int digit)
    {
        if (digit < 10)
        {
            return (char)('0' + digit);
        }
        else
        {
            return (char)('A' + digit - 10);
        }
    }
}