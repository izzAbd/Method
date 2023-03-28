using System;
					
public class Program
{
	public static void Main()
	{
	Console.WriteLine("enter your name: ");
	string name = Console.ReadLine();
	Console.WriteLine("enter your surname: ");
	string surName = Console.ReadLine();
	string result = FullName(name,surName);
	Console.WriteLine(result);
}
  static string FullName(string name, string surname){
    
    return $"Full name is {name} {surname}";
    }
     
}