Console.WriteLine("Number1- ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Number2- ");
int num2 = Convert.ToInt32(Console.ReadLine());
int result = num1 % num2;
if(result == 0)
{
    Console.Write("Первое число кратно второму");
}
else
{
     Console.Write("Первое число некратно второму, остаток" + result);
}
