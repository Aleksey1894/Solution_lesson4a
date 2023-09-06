// See https://aka.ms/new-console-template for more information

Console.WriteLine("Enter the initial value: ");

int initial_value = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter the final value: ");

int final_value = Convert.ToInt32(Console.ReadLine());

int result = 0;

int result1 = 0;

for (int i = initial_value; i <= final_value; i++)
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
