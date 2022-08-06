Console.WriteLine("Введите массив из 8 элементов");
int n=8;
int [] arr = new int [n];
for(int i =0;i<arr.Length;i++)
{
    Console.WriteLine($"i={i}");
    arr [i] = Console.Read();
} 
Console.WriteLine(string.Join(", ",arr));
