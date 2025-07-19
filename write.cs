using System.Diagnostics;
using System.Globalization;
using System.Text;

Console.WriteLine("enter the number you wanna write to: ");
int num;

string? numasstring = Console.ReadLine();
bool isvalid = double.TryParse(numasstring, out _);//make it varify its anum

if (!isvalid)
{
    Console.WriteLine("number you entered is not valid!!");
}
else if (isvalid)
{
    num = Convert.ToInt32(numasstring);
    StringBuilder newwaynum = new StringBuilder();

    Stopwatch time1 = Stopwatch.StartNew();

    for (int i = 0; i <= num; i++)//firstmethod
    {
        newwaynum.Append($"{i}");
        if (i != num) newwaynum.Append(',');//to remove , 
    }

    time1.Stop();
    Console.WriteLine(newwaynum);
    Console.WriteLine($"elapsed sec for 1st method= {time1.Elapsed.TotalSeconds}");



    Stopwatch time2 = Stopwatch.StartNew();
    string Number = "";
    for (int i = 0; i <= num; i++)//second method
    {
        Number = Number + i.ToString();
        if (i != num) Number = Number + ',';//to remove ,
    }

    time2.Stop();

    Console.WriteLine(Number);
    Console.WriteLine($"elapsed sec for 2nd method = {time2.Elapsed.TotalSeconds}");
}