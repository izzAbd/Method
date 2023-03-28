using System;
					
public class Program
{
	public static void Main()
	{
	Console.WriteLine("enter number: ");
	int num =int.Parse(Console.ReadLine());
	Console.WriteLine("enter power: ");
    int power =int.Parse(Console.ReadLine());
	int result = PowerNum(num,power);
    Console.WriteLine(result);
}
  static int PowerNum(int number, int power){
        int rslt = number ^ power;
        return rslt;
}   
}