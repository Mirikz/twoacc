Console.WriteLine("Enter a");
double a = Console.ReadLine();
Console.WriteLine("Enter b");
double b = Console.ReadLine();
Console.WriteLine("'+' for plus, '-' for minus, '*' for multiply, '/' for division");
string choice = Console.ReadLine();
switch (choice){
	case "+":
		plus();
		break;
	case "-":
		minus();
		break;
	case "*":
		multi();
		break;
	case "/":
		division();
		break;
}
	