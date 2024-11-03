using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        var tasks = new Dictionary<int, Action>// cautat pe net cum sa nu folosesc switch case
        {
            { 1, Ex1 },
            { 2, Ex2 },
            { 3, Ex3 },
            { 4, Ex4 },
            { 5, Ex5 },
            { 6, Ex6 },
            { 7, Ex7 },
            { 8, Ex8 },
            { 9, Ex9 },
            { 10, Ex10 },
            { 11, Ex11 },
            { 12, Ex12 },
            { 13, Ex13 },
            { 14, Ex14 },
            { 15, Ex15 },
            { 16, Ex16 },
            { 17, Ex17 },
            { 18, Ex18 },
            { 19, Ex19 },
            { 20, Ex20 },
            { 21, Ex21 }
        };


        while (true)
        {
            Console.WriteLine("Alege exercitiul (1-21) sau 0 pentru a iesi din program:");
            if (int.TryParse(Console.ReadLine(), out int task) && tasks.ContainsKey(task))
            {
                tasks[task]();
            }
            else if (task == 0)
            {
                return;
            }
            else
            {
                Console.WriteLine("Invalid task number.");
            }
        }
    }

    static void Ex1()
    {
        Console.Write("Introdu a: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Introdu b: ");
        double b = double.Parse(Console.ReadLine());
        if (a == 0)
        {
            if (b == 0) Console.WriteLine("O infinitate de solutii.");
            else Console.WriteLine("0 solutii.");
        }
        else
        {
            Console.WriteLine($"Solutie: x = {-b / a}");
        }
    }
    static void Ex2()
    {
        Console.Write("Introdu a: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Introdu b: ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Introdu c: ");
        double c = double.Parse(Console.ReadLine());

        if (a == 0)
        {
            Console.WriteLine("Ec. de gradul 1");
            return;
        }

        double delta = b * b - 4 * a * c;
        if (delta  > 0)
        {
            double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
            double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
            Console.WriteLine($" x1 = {x1}, x2 = {x2}");
        }
        else if (delta == 0)
        {
            double x = -b / (2 * a);
            Console.WriteLine($" x = {x}");
        }
        else
        {
            Console.WriteLine("0 solutii.");
        }
    }
    static void Ex3()
    {
        Console.Write("Introdu n: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Introdu k: ");
        int k = int.Parse(Console.ReadLine());
        Console.WriteLine(n % k == 0 ? $"{n} divizibil cu {k}" : $"{n} nu divizibil cu {k}");
    }
    static void Ex4()
    {
        Console.Write("introdu an: ");
        int an = int.Parse(Console.ReadLine());
        bool bi = (an % 4 == 0 && an % 100 != 0) || (an % 400 == 0);
        Console.WriteLine(bi ? $"{an} an bisect." : $"{an} nu an bisect.");
    }
    static void Ex5()
    {
        Console.Write("Introdu un nr: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Pozitia de la capat: ");
        int p = int.Parse(Console.ReadLine());
        string numStr = n.ToString();

        if (p > 0 && p <= numStr.Length)
            Console.WriteLine($"A {p}-lea nr de la capat {numStr[numStr.Length - p]}");
        else
            Console.WriteLine("nu are pozitia .");
    }
    static void Ex6()
    {
        Console.Write("Latura a: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Latura b: ");
        int b = int.Parse(Console.ReadLine());
        Console.Write("Latura c: ");
        int c = int.Parse(Console.ReadLine());
        bool Triunghi = a + b > c && a + c > b && b + c > a;
        Console.WriteLine(Triunghi ? "Da" : "Nu");
    }
    static void Ex7() { 
        Console.Write("a: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("b: ");
        int b = int.Parse(Console.ReadLine());
        //(a, b) = (b, a);
        int aux = a;
        a = b;
        b = aux;
        Console.WriteLine($"swap: a = {a}, b = {b}");
    }
    static void Ex8()
    {
        Console.Write("a: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("b: ");
        int b = int.Parse(Console.ReadLine());
        a = a + b;
        b = a - b;
        a = a - b;
        Console.WriteLine($"swap: a = {a}, b = {b}");
    }
    static void Ex9()
    {
        Console.Write("Introdu un nr: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Divizorii:");
        for (int i = 1; i <= n; i++)
        {
            if (n % i == 0)
                Console.Write(i + " ");
        }
        Console.WriteLine();
    }
    static void Ex10()
    {
        Console.Write("Introdu un nr: ");
        int n = int.Parse(Console.ReadLine());
        bool prim = n > 1;

        for (int i = 2; i * i <= n; i++)
        {
            if (n % i == 0)
            {
                prim = false;
                break;
            }
        }
        Console.WriteLine(prim ? $"{n} prim. " : $"{n} nu prim.");
    }
    static void Ex11()
    {
        Console.Write("Introdu un nr: ");
        int n = int.Parse(Console.ReadLine());
        // char[] digits = n.ToString().ToCharArray();
        // Array.Reverse(digits);
        // Console.WriteLine("Invers: " + new string(digits));
        int c = 0;
        while (n != 0) { c = c * 10 + n % 10;n /= 10; }
        Console.WriteLine(c);
    }
    static void Ex12()
    {
        Console.Write("Nr: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("De la: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Pana la: ");
        int b = int.Parse(Console.ReadLine());
        

        int c = 0;
        for (int i = a; i <= b; i++)
        {
            if (i % n == 0) c++;
        }
        Console.WriteLine($"Nr divizibile cu {n} in [{a}, {b}]: {count}");
    }
    static void Ex13()
    {
        Console.Write("De la: ");
        int An1 = int.Parse(Console.ReadLine());
        Console.Write("Pana la: ");
        int An2 = int.Parse(Console.ReadLine());
        int c = 0;

        for (int i = An1; i <= An2; i++)
        {
            if ((i % 4 == 0 && i % 100 != 0) || (i % 400 == 0))
                c++;
        }
        Console.WriteLine($"Ani bisecti din {An1} pana in {An2}: {c}");
    }
    static void Ex14()
    {
        Console.Write("Introdu un nr: ");
        int n = int.Parse(Console.ReadLine());
        // string str = n.ToString();
        // string reversed = new string(str.ToCharArray().Reverse().ToArray());
        // Console.WriteLine(str == reversed ? $"{n} palindrome." : $"{n} nu palindrome.");
        int c = 0; int c1 = n;
        while (n != 0) { c = c * 10 + n % 10; n /= 10; }
        Console.WriteLine(c1==c ?$"{c1} palindrom":$"{c1} nu palindrom");

    }
    static void Ex15()
    {
        int[] v = new int[3];
        for (int i = 1; i <= 3; i++)
        {
            Console.Write("Introdu un nr: ");
            v[i] = int.Parse(Console.ReadLine());
        }
        for (int i = 1; i < 3; i++)
        {
            if (v[i] > v[i + 1])
                (v[i], v[i + 1]) = (v[i + 1], v[i]);

        }
        Console.WriteLine("Nr ordonate :");
        for (int i = 1; i <= 3; i++)

            Console.WriteLine($"{v[i]} ");
    }
    static void Ex16()
    {
        int[] v = new int[5];
        for (int i = 1; i <= 3; i++)
        {
            Console.Write("Introdu un nr: ");
            v[i] = int.Parse(Console.ReadLine());
        }
        for (int i = 1; i < 3; i++)
        {
            if (v[i] > v[i + 1])
                (v[i], v[i + 1]) = (v[i + 1], v[i]);

        }
        Console.WriteLine("Nr ordonate :");
        for (int i = 1; i <= 3; i++)

            Console.WriteLine($"{v[i]} ");
    }
    static void Ex17() {
        Console.WriteLine("introdu primul numar: ");
        int n1 =int.Parse(Console.ReadLine());
        Console.WriteLine("introdu al doilea numar: ");
        int n2 = int.Parse(Console.ReadLine());
        int c1 = n1;
        int c2 = n2;
        while(n2 != 0)
        {
            int r = n1 % n2;
            n1 = n2;
            n2 = r;
        }
        Console.WriteLine($"cmmdc= {n1}, cmmmc= {c1*c2/n1}");
    }
    static void Ex18()
    {
        Console.WriteLine("Introdu numarul: ");
        int n=int.Parse(Console.ReadLine());
        int c = n;
        int[] v= new int [n+1];
        while (n % 2 == 0) { v[2]++; n /= 2; }
        for (int i = 3; i < Math.Sqrt(c); i += 2)
        {
            while (n % i == 0)
            {
                v[i]++;
                n /= i;
            }
        }
        if (n > 2)
            v[n]++;
        for (int i = 2; i <= c; i++)
            if (v[i] != 0) { Console.WriteLine($"{i}^{v[i]} "); }
    }
    static void Ex19()
    {
        
        Console.WriteLine("Introdu numarul: ");
        int n = int.Parse(Console.ReadLine());
        int[] v = new int[10];
        int c = 0;
        int c1 = n;
        while (n!=0)
        {
            v[n % 10]++;
            n /= 10;
        }
        for (int i = 0; i < 10; i++)
            if (v[i] != 0) c++;
        Console.WriteLine(c==2 ? $"{c1} din 2 cifre" : $"{c1} nu din 2 cifre");


    }
    static void Ex20() //copiat de pe GitHub
    {
        Console.WriteLine("Introdu primul numar: ");
        int m=int.Parse(Console.ReadLine());
        Console.WriteLine("Introdu al doilea numar: ");
        int n = int.Parse(Console.ReadLine());

        // TODO aducem fractia la forma ireductibila. 
        int parteInt, parteFract;
        parteInt = m / n; // 0
        parteFract = m % n; // 13
        Console.Write($"{parteInt},");
        int cifra, rest;
        List<int> resturi = new List<int>();
        List<int> cifre = new List<int>();
        resturi.Add(parteFract);
        bool periodic = false;
        do
        {
            cifra = parteFract * 10 / n;
            cifre.Add(cifra);
            //Console.Write($"{cifra}");
            rest = parteFract * 10 % n;
            if (!resturi.Contains(rest))
            {
                resturi.Add(rest);
            }
            else
            {
                periodic = true;
                break;
            }
            parteFract = rest;
        } while (rest != 0);

        if (!periodic)
        {
            foreach (var item in cifre)
            {
                Console.Write(item);
            }
        }
        else
        {
            for (int i = 0; i < resturi.Count; i++)
            {
                if (resturi[i] == rest)
                {
                    Console.Write("(");
                }
                Console.Write(cifre[i]);
            }
            Console.WriteLine(")");
        }

    }
    static void Ex21() 
    {
        int min = 1;
        int max = 1024;
        int n;
        while (min < max)
        {
            n = (min + max) / 2;
            Console.WriteLine($"Numarul este mai mare decat {n}? (da/nu)");
            string r = Console.ReadLine().Trim().ToLower();

            if (r == "da")
            {
                min = n; 
            }
            else if (r == "nu")
            {
                max = n - 1; 
            }
            else
            {
                Console.WriteLine("Raspuns invalid. Te rog să raspunzi cu 'da' sau 'nu'.");
            }
        }

        Console.WriteLine($"Numarul tau este: {min+1}");
    }

}

