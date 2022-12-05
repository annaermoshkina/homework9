//Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

int recursion(int m,int n)
{
    if (m==0)
    {
        return n+1;
    }
    else if (n==0 && m>0)
    {
        return recursion(m-1,1);
    }
    else
    {
        return recursion(m-1,recursion(m,n-1));
    }
}
Console.WriteLine("Введите первое число");
int n=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ведите второе число");
int m=Convert.ToInt32(Console.ReadLine());
Console.Write(recursion(m,n));