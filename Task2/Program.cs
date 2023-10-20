// Задача 66: Задайте значения m и n. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от m до n.
// m = 1; n = 15 -> 120
// m = 4; n = 8. -> 30

int Sum(int m, int n)
{
if ((m == n) || (n < m))
return n;
else return n + Sum(m, n - 1);
}

Console.Clear();
Console.Write("Вводите первый Число {M}: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Вводите второй Число {N}: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"-> {Sum(m, n)}");
