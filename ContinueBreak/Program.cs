int[] nums = new[]{15, 7, 12, 23, 41, 28, 9, 17, 32};

// break
foreach(int num in nums)
{
    Console.WriteLine(num);
    if(num == 23)
    {
        break;
    }
}
Console.WriteLine("Done!");

// continue
foreach(int num in nums)
{
    if(num % 2 == 0)
    {
        continue;
    }
    Console.WriteLine(num);
}
Console.WriteLine("Done!"); 
