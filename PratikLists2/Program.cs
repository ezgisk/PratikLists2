
using System.Collections.Specialized;

Console.WriteLine("Lutfen kahve adi girin:");

List<string> list = new List<string>();//Creating a new list

for (int i = 1; i <= 5; i++)
{
    Console.Write($"{i}. Kahve:");
    list.Add(Console.ReadLine());//Adding elements to list
}
Console.WriteLine("Istediginiz kahveler :");

foreach (string s in list)
{
    Console.WriteLine(s);//Writing the list the console
}
Console.ReadKey();

