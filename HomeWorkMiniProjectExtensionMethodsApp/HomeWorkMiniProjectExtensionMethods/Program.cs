
using System.ComponentModel;
using System.Globalization;

PersonModel person = new();

NumberFormatInfo nfi = new CultureInfo("nl-NL", false).NumberFormat;

person.FirstName = "What is your first name?: ".RequestString();
person.LastName = "What is your last name?: ".RequestString();
person.Age = "What is your age?: ".RequestInt();
person.BankAccountTotal = "How much money do you have in your bank account: ".RequestDecimal();

foreach (PropertyDescriptor personInfo in TypeDescriptor.GetProperties(person))
{
    string name = personInfo.Name;
    object value = personInfo.GetValue(person);

    if (personInfo.Name == "BankAccountTotal")
    {
        string bankAccountTotal = ((decimal)value).ToString("#,#0.00", nfi);
        Console.WriteLine("{0}={1}", name, bankAccountTotal);
    }
    else
    {
        Console.WriteLine("{0}={1}", name, value);
    }
}

public class PersonModel
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }
    public decimal BankAccountTotal { get; set; }
}

public static class ConsoleHelper
{
    // REQUEST STRING
    public static string RequestString(this string message)
    {
        string output = "";

        while (string.IsNullOrEmpty(output))
        {
            Console.Write(message);
            output = Console.ReadLine();
        }

        return output;

    }

    // REQUEST INT
    public static int RequestInt(this string message)
    {
        return message.RequestInt(false);
    }

    public static int RequestInt(this string message, int minValue, int maxValue)
    {
        return message.RequestInt(true);
    }

    private static int RequestInt(this string message, bool useMinMax, int minValue = 0, int maxValue = 0)
    {
        bool isValidInt = false;
        bool isInValidRange = true;
        int output = 0;

        while (isValidInt == false || isInValidRange == false)
        {
            Console.Write(message);
            isValidInt = int.TryParse(Console.ReadLine(), out output);

            if (useMinMax)
            {
                isInValidRange = output >= minValue && maxValue <= output;
            }
        }

        return output;
    }

    // REQUEST DECIMAL

    public static decimal RequestDecimal(this string message)
    {
        return message.RequestDecimal(false);
    }

    public static decimal RequestDecimal(this string message, decimal minValue, decimal maxValue)
    {
        return message.RequestDecimal(true);
    }

    private static decimal RequestDecimal(this string message, bool useMinMax, decimal minValue = 0m, decimal maxValue = 0m)
    {
        bool isValidInt = false;
        bool isInValidRange = true;
        decimal output = 0;

        while (isValidInt == false || isInValidRange == false)
        {
            Console.Write(message);
            isValidInt = decimal.TryParse(Console.ReadLine(), out output);

            if (useMinMax)
            {
                isInValidRange = output >= minValue && maxValue <= output;
            }
        }

        return output;
    }
}