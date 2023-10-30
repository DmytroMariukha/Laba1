class Vector
{
    private double x1, y1, x2, y2; 

    public Vector(double x1, double y1, double x2, double y2) 
    {
        this.x1 = x1;
        this.y1 = y1;
        this.x2 = x2;
        this.y2 = y2;
    }

    public bool Correct() 
    {
        return !(x1 == x2 && y1 == y2);
    }

    public double Length() 
    {
        double dx = x2 - x1;
        double dy = y2 - y1;
        return Math.Sqrt(dx * dx + dy * dy);
    }

    public void Koord(out double x, out double y) 
    {
        x = x2 - x1;
        y = y2 - y1;
    }

    public void Print() 
    {
        Console.WriteLine("x1 = {0}, y1 = {1}, x2 = {2}, y2 = {3}", x1, y1, x2, y2);
    }

    public void PrintLengthAndKoord()
    {
        if (Correct())
        {
            double length = Length();
            double x, y;
            Koord(out x, out y);
            Console.WriteLine("Довжина: {0}", length);
            Console.WriteLine("Кординати: ({0}, {1})", x, y);
        }
        else
        {
            Console.WriteLine("Вектор некоректний.");
        }
    }
}

class Program
{
    static void Main()
    {
        try
        {
            Console.Write("Введіть x1: ");
            double x1 = double.Parse(Console.ReadLine());
            Console.Write("Введіть y1: ");
            double y1 = double.Parse(Console.ReadLine());
            Console.Write("Введіть x2: ");
            double x2 = double.Parse(Console.ReadLine());
            Console.Write("Введіть y2: ");
            double y2 = double.Parse(Console.ReadLine());

            Vector vector = new Vector(x1, y1, x2, y2);
            vector.Print();

            if (vector.Correct())
            {
                vector.PrintLengthAndKoord();
            }
            else
            {
                Console.WriteLine("Вектор некоректний.");
            }
        }
        catch (Exception)
        {
            Console.WriteLine("Невідома помилка.");
        }
    }
}