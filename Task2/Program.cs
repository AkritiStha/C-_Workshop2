class Circle
{
    public const double PI = 3.14;
    
    private int radius = 5;

    // Method to calculate area: A = PI * r^2
    public double Area()
    {
        return PI * radius * radius;
    }

    // Method to calculate perimeter (circumference): C = 2 * PI * r
    public double Perimeter()
    {
        return 2 * PI * radius;
    }
}


 class Program
 {
     static void Main()
     {
         Console.WriteLine($"PI = {Circle.PI}");
        //Trying to modify the constant
         Circle.PI = 3.15;
         //Compilation error because PI is a constant

     }
 }

 

