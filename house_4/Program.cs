Console.WriteLine("Введите первое число, нажмите Enter");

int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число, нажмите Enter");

int b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите третье число, нажмите Enter");

int c = Convert.ToInt32(Console.ReadLine());

int max = a;

if(b>max) max=b;

if(c>max) max=c;

Console.WriteLine("Больщее число из введенных");

System.Console.WriteLine(max);
