Console.WriteLine("Введите число A:");
int A =Convert.ToInt32(Console.ReadLine());
int count=0;
while(A>0)
{
count = A%10+count;
A=A/10;
}
Console.WriteLine(count);