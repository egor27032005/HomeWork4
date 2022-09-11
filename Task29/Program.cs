Console.Clear();
int [] array=new int[8];
int i =0;
int j =0;
while (i<8) {
    int a = Convert.ToInt32(Console.ReadLine());
    array[i]=a;
    i=i+1;
}
Console.Write("[");
while (j<7) {
    Console.Write(array[j]+",");
    j=j+1;
}
Console.Write(array[7]+"]");