﻿public class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Giải phương trình bậc nhất môt ẩn. Tìm x khi ax = b");
        Console.WriteLine("Nhập a");
        double a = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Nhập b");
        double b = Convert.ToDouble(Console.ReadLine());
        if (a == 0)
        {
            if (b == 0)
            {
                Console.WriteLine("Phương trình có vô số nghiệm");
            }
            else
            {
                Console.WriteLine("Phương trình vô nghiệm");
            }
        }
        else
        {   
            double x = -b/a;
            Console.WriteLine($"Nghiệm của phương trình là{x}");
        }
    }
}