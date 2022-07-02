// See https://aka.ms/new-console-template for more information

int[] arr = new int[4];
foreach (int i in arr)
{
    Console.WriteLine(i + "");
}
Console.WriteLine(" ");
int a = 0;

for (int i=0; i<4; i++)
{
    arr[i] = a;
    a = a + 10;
}

foreach (int i in arr)
{
    Console.WriteLine(i + "");
}
Console.WriteLine(" ");

Array.Reverse(arr);
Console.WriteLine("reverse array");

foreach (int i in arr)
{
    Console.WriteLine(i + "");
}
Console.WriteLine(" ");

Array.Sort(arr);
Console.WriteLine("sorted array");
foreach (int i in arr)
{
    Console.WriteLine(i + "");
}
Console.WriteLine(" ");

Array.Clear(arr);
Console.WriteLine("cleared array");

foreach (int i in arr)
{
    Console.WriteLine(i + "");
}
Console.WriteLine(" ");

Array.Fill(arr,5);
foreach (int i in arr)
{
    Console.WriteLine(i + "");
}
Console.WriteLine(" ");


