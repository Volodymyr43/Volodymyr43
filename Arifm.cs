using System;
public class Test
{
    public static void Main()
    {
        int acshion = Convert.ToInt32(Console.ReadLine());
        string[] str1 = Console.ReadLine().Split(' ');
        int a = Convert.ToInt32(str1[0]);
        int b = Convert.ToInt32(str1[1]);

        switch (acshion)
        {
            case 1:
                Console.WriteLine(a + b);
                break;
            case 2:
                Console.WriteLine(a - b);
                break;
            case 3:
                Console.WriteLine(a * b);
                break;
            case 4:
                Console.WriteLine(b == 0 ? "Error" : a / b);
                break;
            case 5:
                Console.WriteLine(b == 0 ? "Error" : a % b);
                break;
            default:
                Console.WriteLine("Error");
                break;
        }
    }
}
