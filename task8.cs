using System;
					
public class Program
{
	public static void Main()
	{
	Console.WriteLine("enter number: ");
	int num =int.Parse( Console.ReadLine());
	bool result = PrimeNum(num);
	if(result){
	    Console.WriteLine("Prime number");
	}
	else{
	    Console.WriteLine(" not Prime number");
	}
}
  static bool PrimeNum(int number){
    int count = 0;
    for(int i=2;i<number/2;i++){
        if (number%i==0){
            count++;
    }
    }
    if (count==0){
        return true;
    }
    else{
        return false;
    }
     
}
}
