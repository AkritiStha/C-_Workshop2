
class Program
{
    static void Main()
    {
        // 1. Declare and initialize variables of various data types
        byte b = 100;                 
        short s = 32000;             
        int i = 12345;           
        long l = 123456789L; 
        float f = 3.14f;              
        double d = 3.141592653589793; 
        decimal dec = 3.141592653589793123456789m; 
        char ch = 'A';                
        bool isTrue = true;           

        // 2. Convert the integer value 42 to a string
        int number = 42;
        string numberAsString = number.ToString();

        // 3. Convert a string "3.14" to a double
        string piString = "3.14";
        double piValue = double.Parse(piString);
       

        // 4. Print all variables with labels showing their types and values
        Console.WriteLine("Data Types and Values");
        Console.WriteLine($"byte    : {b}");
        Console.WriteLine($"short   : {s}");
        Console.WriteLine($"int     : {i}");
        Console.WriteLine($"long    : {l}");
        Console.WriteLine($"float   : {f}");
        Console.WriteLine($"double  : {d}");
        Console.WriteLine($"decimal : {dec}");
        Console.WriteLine($"char    : {ch}");
        Console.WriteLine($"bool    : {isTrue}");

        Console.WriteLine("\nType Conversions");
        Console.WriteLine($"int to string       : \"{numberAsString}\" (type: string)");
        Console.WriteLine($"string to double    : {piValue} (type: double, from \"{piString}\")");
    }
}