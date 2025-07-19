// using System.Diagnostics;
// using System.Globalization;
// using System.Text;
// Console.WriteLine("Hello, Please enter the number you want to add from 1 to: ");

// string? numasstring;
// //? to accept null as a value

// numasstring = Console.ReadLine();


// bool isvalid = double.TryParse(numasstring, out _);//make it varify its anum

// if (!isvalid)
// {
//     Console.WriteLine("number you entered is not valid!!");
    
// }
// else if(isvalid){
//     Int64 maxnum= Convert.ToInt64(numasstring);


//     Console.WriteLine($"You picked the number: {numasstring}?");



//     Stopwatch timeEQ = Stopwatch.StartNew();

//     Int64 sumEQ = maxnum * (maxnum + 1) / 2;

//     timeEQ.Stop();


//     Stopwatch timeloop = Stopwatch.StartNew();


//     Int64 sumloop = 0;
//     for (int i = 1; i <= maxnum; i++)
//     {
//         sumloop += i;
//     }

//     timeloop.Stop();

//     Console.WriteLine($"elapsed sec for formula= {timeEQ.Elapsed.TotalSeconds}");//to get cpu diff from loop and equation
//     Console.WriteLine($"elapsed sec for for loop= {timeloop.Elapsed.TotalSeconds}");
//     Console.WriteLine($"total sum from 1 to {maxnum} is = {sumEQ} from formula");
//     Console.WriteLine($"total sum from 1 to {maxnum} is = {sumloop} from for loop");
// }



