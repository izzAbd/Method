using System;
					
public class Program
{
	public static void Main()
	{
	Console.WriteLine("enter decimal number: ");
	decimal num =decimal.Parse( Console.ReadLine());
	decimal result = Decimal(num);
	Console.WriteLine(result);
}
  static decimal Decimal(decimal number){
    
    return number*=2;
    }
     
}