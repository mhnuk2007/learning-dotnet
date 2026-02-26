int x = 10000;
int y = 0;
int result;

// General exception
try{
    result = x/y;
    Console.WriteLine(result);
}
catch(Exception e)
{
    Console.WriteLine(e.Message);
    
}

// Specific exception
try
{
    result = x / y;
    Console.WriteLine(result);
}
catch (DivideByZeroException)
{
    Console.WriteLine("You cannot divide by zero.");
}

// exception with finally
try
{
    result = x / y;
    Console.WriteLine(result);
}
catch (DivideByZeroException)
{
    Console.WriteLine("You cannot divide by zero.");
}
finally
{
    Console.WriteLine("Execution completed.");
}

// multiple catch blocks
try
{
    result = x / y;
    Console.WriteLine(result);
}
catch (DivideByZeroException)
{
    Console.WriteLine("Divide by zero error.");
}
catch (Exception ex)
{
    Console.WriteLine($"Unexpected error: {ex.Message}");
}

// without using try-catch
if (y == 0)
{
    Console.WriteLine("Cannot divide by zero.");
}
else
{
    Console.WriteLine(x / y);
}

// throw new exception

try{
    if (x > 1000)
    {
        throw new ArgumentOutOfRangeException("x", "x cannot be greater than 1000.");
    }
    result = x / y;
    Console.WriteLine(result);
}
catch (ArgumentOutOfRangeException ex)
{
    Console.WriteLine(ex.Message);
}
catch (DivideByZeroException)
{
    Console.WriteLine("You cannot divide by zero.");
}


