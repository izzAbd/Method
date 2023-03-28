using System;
					
public class Program
{
	public static void Main()
	{
	string isTrueStr = Console.ReadLine();
    bool isTrue = bool.Parse(isTrueStr);
    string result = MyBool(isTrue);
    Console.WriteLine(result);

}
  static string MyBool(bool input){
    if(input == true){
        return "Beli";
    }
    else{
       return "Xeyr";

    }
     
}
}