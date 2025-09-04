using System;

class Program
{
    static void Main()
    {
        int choice;
        do
        {
            Console.WriteLine("\n===== MENU =====");
            Console.WriteLine("Slide 9:");
            Console.WriteLine(" 1. May tinh (+, -, *, /)");
            Console.WriteLine(" 2. Ham x = y^2 + 2y + 1 (y = -5..5)");
            Console.WriteLine(" 3. Tinh van toc tu quang duong va thoi gian");
            Console.WriteLine(" 4. Tinh dien tich va the tich hinh cau");
            Console.WriteLine(" 5. Kiem tra ky tu (nguyen am, chu so, ky tu khac)");

            Console.WriteLine("Slide 21:");
            Console.WriteLine(" 6. Kiem tra chan le");
            Console.WriteLine(" 7. Tim so lon nhat trong 3 so");
            Console.WriteLine(" 8. Kiem tra diem nam o goc phan tu nao");

            Console.WriteLine("Slide 22:");
            Console.WriteLine(" 9. Kiem tra loai tam giac");
            Console.WriteLine("10. Nhap 10 so, tinh tong va trung binh");
            Console.WriteLine("11. Bang cuu chuong");
            Console.WriteLine("12. Ve tam giac so don gian");
            Console.WriteLine("13. Ve cac mau so khac");
            Console.WriteLine("14. Day so dieu hoa (harmonic series)");
            Console.WriteLine("15. Tim so hoan hao trong pham vi");
            Console.WriteLine("16. Kiem tra so nguyen to");
            Console.WriteLine("0. Thoat");

            Console.Write("Nhap lua chon: ");
            choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1: Calculator(); break;
                case 2: FunctionY(); break;
                case 3: SpeedCalc(); break;
                case 4: SphereCalc(); break;
                case 5: CheckCharacter(); break;
                case 6: EvenOdd(); break;
                case 7: LargestOfThree(); break;
                case 8: QuadrantCheck(); break;
                case 9: TriangleType(); break;
                case 10: SumAverage(); break;
                case 11: MultiplicationTable(); break;
                case 12: PatternTriangle(); break;
                case 13: Patterns(); break;
                case 14: HarmonicSeries(); break;
                case 15: PerfectNumbers(); break;
                case 16: PrimeCheck(); break;
                case 0: Console.WriteLine("Dang thoat..."); break;
                default: Console.WriteLine("Lua chon khong hop le."); break;
            }
        } while (choice != 0);
    }

    // ========== Slide 9 ==========
    static void Calculator()
    {
        Console.Write("Nhap so thu nhat: ");
        double a = Convert.ToDouble(Console.ReadLine());
        Console.Write("Nhap toan tu (+,-,*,/): ");
        char op = Console.ReadLine()[0];
        Console.Write("Nhap so thu hai: ");
        double b = Convert.ToDouble(Console.ReadLine());
        double result = 0;
        switch (op)
        {
            case '+': result = a + b; break;
            case '-': result = a - b; break;
            case '*': result = a * b; break;
            case '/': result = b != 0 ? a / b : double.NaN; break;
            default: Console.WriteLine("Toan tu khong hop le"); return;
        }
        Console.WriteLine("Ket qua = " + result);
    }

    static void FunctionY()
    {
        for (int y = -5; y <= 5; y++)
        {
            int x = y * y + 2 * y + 1;
            Console.WriteLine($"y = {y}, x = {x}");
        }
    }

    static void SpeedCalc()
    {
        Console.Write("Nhap quang duong (km): ");
        double d = Convert.ToDouble(Console.ReadLine());
        Console.Write("Nhap gio: ");
        int h = Convert.ToInt32(Console.ReadLine());
        Console.Write("Nhap phut: ");
        int m = Convert.ToInt32(Console.ReadLine());
        Console.Write("Nhap giay: ");
        int s = Convert.ToInt32(Console.ReadLine());
        double timeHours = h + m / 60.0 + s / 3600.0;
        double kmh = d / timeHours;
        double mph = kmh * 0.621371;
        Console.WriteLine($"Van toc: {kmh:F2} km/h, {mph:F2} mph");
    }

    static void SphereCalc()
    {
        Console.Write("Nhap ban kinh: ");
        double r = Convert.ToDouble(Console.ReadLine());
        double surface = 4 * Math.PI * r * r;
        double volume = 4.0 / 3 * Math.PI * Math.Pow(r, 3);
        Console.WriteLine($"Dien tich = {surface:F2}, The tich = {volume:F2}");
    }

    static void CheckCharacter()
    {
        Console.Write("Nhap mot ky tu: ");
        char c = Console.ReadLine()[0];
        if ("aeiouAEIOU".Contains(c))
            Console.WriteLine("Day la nguyen am");
        else if (char.IsDigit(c))
            Console.WriteLine("Day la chu so");
        else
            Console.WriteLine("Day la ky tu khac");
    }

    // ========== Slide 21 ==========
    static void EvenOdd()
    {
        Console.Write("Nhap mot so: ");
        int n = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(n % 2 == 0 ? "So chan" : "So le");
    }

    static void LargestOfThree()
    {
        Console.Write("Nhap 3 so: ");
        int a = Convert.ToInt32(Console.ReadLine());
        int b = Convert.ToInt32(Console.ReadLine());
        int c = Convert.ToInt32(Console.ReadLine());
        int largest = Math.Max(a, Math.Max(b, c));
        Console.WriteLine("So lon nhat = " + largest);
    }

    static void QuadrantCheck()
    {
        Console.Write("Nhap x: ");
        int x = Convert.ToInt32(Console.ReadLine());
        Console.Write("Nhap y: ");
        int y = Convert.ToInt32(Console.ReadLine());
        if (x > 0 && y > 0) Console.WriteLine("Goc phan tu I");
        else if (x < 0 && y > 0) Console.WriteLine("Goc phan tu II");
        else if (x < 0 && y < 0) Console.WriteLine("Goc phan tu III");
        else if (x > 0 && y < 0) Console.WriteLine("Goc phan tu IV");
        else Console.WriteLine("Nam tren truc toa do");
    }

    // ========== Slide 22 ==========
    static void TriangleType()
    {
        Console.Write("Nhap canh a: ");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.Write("Nhap canh b: ");
        int b = Convert.ToInt32(Console.ReadLine());
        Console.Write("Nhap canh c: ");
        int c = Convert.ToInt32(Console.ReadLine());
        if (a == b && b == c) Console.WriteLine("Tam giac deu");
        else if (a == b || b == c || a == c) Console.WriteLine("Tam giac can");
        else Console.WriteLine("Tam giac thuong");
    }

    static void SumAverage()
    {
        int sum = 0;
        for (int i = 1; i <= 10; i++)
        {
            Console.Write($"Nhap so thu {i}: ");
            sum += Convert.ToInt32(Console.ReadLine());
        }
        double avg = sum / 10.0;
        Console.WriteLine($"Tong = {sum}, Trung binh = {avg}");
    }

    static void MultiplicationTable()
    {
        Console.Write("Nhap so: ");
        int n = Convert.ToInt32(Console.ReadLine());
        for (int i = 1; i <= 10; i++)
            Console.WriteLine($"{n} x {i} = {n * i}");
    }

    static void PatternTriangle()
    {
        for (int i = 1; i <= 5; i++)
        {
            for (int j = 1; j <= i; j++)
                Console.Write(j + " ");
            Console.WriteLine();
        }
    }

    static void Patterns()
    {
        int num = 1;
        for (int i = 1; i <= 4; i++)
        {
            for (int j = 1; j <= i; j++)
                Console.Write(num++ + " ");
            Console.WriteLine();
        }
    }

    static void HarmonicSeries()
    {
        Console.Write("Nhap n: ");
        int n = Convert.ToInt32(Console.ReadLine());
        double sum = 0;
        for (int i = 1; i <= n; i++)
        {
            sum += 1.0 / i;
            Console.Write("1/{0} + ", i);
        }
        Console.WriteLine("\nTong = " + sum);
    }

    static void PerfectNumbers()
    {
        Console.Write("Nhap pham vi toi da: ");
        int max = Convert.ToInt32(Console.ReadLine());
        for (int n = 1; n <= max; n++)
        {
            int sum = 0;
            for (int i = 1; i < n; i++)
                if (n % i == 0) sum += i;
            if (sum == n)
                Console.WriteLine(n + " la so hoan hao");
        }
    }

    static void PrimeCheck()
    {
        Console.Write("Nhap so: ");
        int n = Convert.ToInt32(Console.ReadLine());
        bool isPrime = n > 1;
        for (int i = 2; i <= Math.Sqrt(n); i++)
            if (n % i == 0) { isPrime = false; break; }
        Console.WriteLine(isPrime ? "La so nguyen to" : "Khong phai so nguyen to");
    }
}
