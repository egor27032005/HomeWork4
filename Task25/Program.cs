Console.Clear();
Console.Write("Введите число a: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число b: ");
int b = Convert.ToInt32(Console.ReadLine());
int i =0;
int c =1;
while (b>i) {
    c=c*a;
    i=i+1;
}
Console.WriteLine(c);
