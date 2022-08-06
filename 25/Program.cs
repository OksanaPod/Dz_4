Console.WriteLine("Введите два числа A,B:");
int A =Convert.ToInt32(Console.ReadLine());
int B=Convert.ToInt32(Console.ReadLine());
int Otvet=1;
for (int i =1; i<=B; i++)
{
    Otvet = Otvet*A;
}
Console.WriteLine(Otvet);
