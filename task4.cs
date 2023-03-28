using System;
					
public class Program
{
	public static void Main()
	{
    // daxil edilen eedin cut ve ya tek oldugunu yoxlayan program
	Console.WriteLine("enter number: ");
	string number = Console.ReadLine();
	int.TryParse(number, out int numb);
	bool result = EvenOrOdd(numb);
	Console.WriteLine(result);
	}
	static bool EvenOrOdd(int number){
		if(number%2==0){
			return true;
		}
		else{
			return false;
		}
}
}