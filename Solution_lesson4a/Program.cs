// See https://aka.ms/new-console-template for more information

Console.WriteLine("Enter the initial value: ");

double initial_value = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Enter the final value: ");

double final_value = Convert.ToDouble(Console.ReadLine());

double result = 0;

double result1 = 0;

for (double i = initial_value; i <= final_value; i++)
{
    if ((i % 2) != 0)
    {
        result += i;
    }
    else
    {
        result1 += i;
    }
}
Console.WriteLine("Sum of add numbers is " + result + "\n");

Console.WriteLine("Sum of even numbers is " + result1);
