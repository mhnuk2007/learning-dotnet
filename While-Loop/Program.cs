// See https://aka.ms/new-console-template for more information
int count = 5;
while (count > 0)
{
    Console.WriteLine($"Count: {count}");
    count--;
}
Console.WriteLine("Done!");

string inputStr = "";
// Console.WriteLine("Basic while() loop:");
// while (inputStr != "exit")
// {
//     Console.Write("Enter a string: ");
//     inputStr = Console.ReadLine();
//     Console.WriteLine($"You entered: {inputStr}");
// }
// Console.WriteLine("Done!");

// do-while loop: It execute at least once always
Console.WriteLine("do-while() loop:");
do
{
    Console.Write("Enter a string: ");
    inputStr = Console.ReadLine();
    Console.WriteLine($"You entered: {inputStr}");
}
while (inputStr != "exit");
Console.WriteLine("Done!");