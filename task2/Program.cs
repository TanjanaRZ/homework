Console.Write("Введите первое число ");
int a = Convert.ToInt32(Console.ReadLine( ));
Console.Write("Введите второе число ");
int b = Convert.ToInt32(Console.ReadLine( ));

if (a > b)
{ 
     Console.WriteLine("Первое число большее, второе - меньшее");
}
else if (a < b)
{
      Console.WriteLine("Первое число меньшее,второе - большее");
}
else if (a == b)
{
     Console.WriteLine("Первое и второе числа равны");
}    
