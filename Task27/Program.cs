Console.Clear();
Console.Write("Введите число a: ");
int a = Convert.ToInt32(Console.ReadLine());
int b;
int sum=0;
while(a>0){
b=a%10;
a=a/10;
sum=sum+b;
}
Console.WriteLine(sum);