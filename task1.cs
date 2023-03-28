using System;
					
public class Program
{
	public static void Main()
	{
    // iki eded daxil edib onlarin cemini tapan method
    
	Console.WriteLine("enter number 1: ");
		
	string number1 = Console.ReadLine();
	
	int.TryParse(number1, out int num1);

	Console.WriteLine("enter number 2: ");
		
	string number2 = Console.ReadLine();
	
	int.TryParse(number1, out int num2);
		
	int sum = Sum(num1,num2);
	Console.WriteLine(sum);
	}
	static int Sum(int number1,int number2){
		return number1 + number2;		
}
}