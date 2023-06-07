
double num1, num2;
string op;

try
{

	Console.Write("Enter first number: ");
	num1 = double.Parse(Console.ReadLine());

	Console.Write("Enter second number: ");
	num2 = double.Parse(Console.ReadLine());

	Console.Write("Enter math operator (+ - * /): ");
	op = Console.ReadLine();

	if (op == "+")
	{
		Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
	}
	else if (op == "-")
	{
		Console.WriteLine($"{num1} - {num2} = {num1 - num2}");
	}
	else if (op == "*")
	{
		Console.WriteLine($"{num1} * {num2} = {num1 * num2}");
	}
	else if (op == "/")
	{
		Console.WriteLine($"{num1} / {num2} = {num1 / num2}");
	}
}
catch (FormatException)
{
	Console.WriteLine("Text is not a number");
}
catch (DivideByZeroException)
{
	Console.WriteLine("Can not divide by zero");
}


Console.ReadLine();
