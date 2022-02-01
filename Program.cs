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
void plus(double a, double b){
Console.WriteLine(a+b);
}
void minus(double a, double b){
Console.WriteLine(a-b);
}
void multi(double a, double b){
Console.WriteLine(a*b);
}
void division(double a, double b){
Console.WriteLine(a/b);
}