// Напишите программу, которая на вход принимает число (N), а на выходе показывает все числа от 1 до N.

System.Console.WriteLine("Введите число");

int N = int.Parse(Console.ReadLine());

int i = 1;

if(N<=1)
{
System.Console.WriteLine("Введи число больше 1");
}
else
{  
 System.Console.WriteLine("числа от 1 до " +N);
 while(i<N+1) 
  {
  System.Console.Write(i+".");
  i++; 
  }

}


