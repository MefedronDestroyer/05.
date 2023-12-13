using System;

//1

class S1
{
    static void Main()
    {
        int w, r = 0;
        try
        {
            Console.WriteLine("Размер массива: _");
            w = Int32.Parse(Console.ReadLine());
            int[] g = new int[w];
            for (int i = 0; i < g.Length; i++)
            {
                while (r % 5 != 2)
                {
                    r++;
                }
                g[i] = r;
                Console.WriteLine("Позиция {0} = {1}", i + 1, g[i]);
                r++;
            }
        }
        catch
        {
            Console.WriteLine("Введено неверное значение");
        }
        Console.ReadKey();
    }

}

//2

class S2
{
    static void Main()
    {
        int w = 2, e = 2048, z = 12;
        int[] nums = new int[z];

        for (int k = 11; k >= 0; k--)
        {
            e = e / 2;
            nums[k] = e;
            Console.Write(nums[k] + " ");
        }

        Console.WriteLine("");
        for (int k = 0; k <= nums.Length - 1; k++)
        {
            Console.Write(nums[k] + " ");
        }


        Console.ReadKey();
    }
}

//3

class S3
{
    static void Main()
    {
        int u = 10;
        char w = 'a';
        char[] e = new char[u];

        for (int i = 0; i < e.Length; i++)
        {
            e[i] = (char)w++;
            w++;                                    
            Console.WriteLine("{0} = {1}", i, e[i]);
        }
        Console.WriteLine();
        for (int j = u - 1; j >= 0; j--)
        {
            Console.WriteLine("{0} = {1}", j, e[j]);
        }
        Console.ReadKey();
    }
}

//4

class S4
{
    static void Main()
    {
        char h = 'A';
        char[] q = new char[10];

        for (int i = 0; i < q.Length; i++)
        {
            switch (h)
            {
                case 'A':
                    h++;
                    break;
                case 'E':
                    h++;
                    break;
                case 'I':
                    h++;
                    break;
            }
            q[i] = h;
            h++;
        }
        for (int j = 0; j < q.Length; j++)
        {
            Console.WriteLine("{0} = {1}", j, q[j]);
        }
        Console.ReadKey();

    }
}

//5

class S5
{
    static void Main()
    {
        int s, min, k;
        int[] q = new int[10];
        Random rnd = new Random();
        Console.WriteLine("Mass");
        for (int i = 0; i < q.Length; i++)
        {
            s = rnd.Next(0, 1000);
            q[i] = s;

            Console.WriteLine("{0} = {1}", i, q[i]);
        }
        Console.WriteLine();
        min = q[0];  
        for (k = 0; k < q.Length; k++)
        {
            if (q[k] <= min)
            {
                min = q[k];
            }
        }
        for (int j = 0; j < q.Length; j++)
        {
            if (q[j] == min)
            {
                Console.WriteLine("Id min = {0} Zn min = {1}",
                    j, q[j]);
            }
        }

        Console.ReadKey();
    }
}

//6

class S6
{
    static void Main()
    {
        int d, max = 0;
        int[] c = new int[10];

        Random rnd = new Random();
        Console.WriteLine("Mass");
        Console.WriteLine();
        for (int i = 0; i < c.Length; i++)
        {
            d = rnd.Next(0, 1000);
            c[i] = d;
            Console.WriteLine("{0} = {1}", i, c[i]);
        }
        Console.WriteLine();
        for (int k = 1; k < c.Length; k++)
        {
            for (int j = 0; j < c.Length - k; j++)
            {
                if (c[j] < c[j + 1])
                {
                    max = c[j + 1];
                    c[j + 1] = c[j];
                    c[j] = max;
                }
            }
        }
        Console.WriteLine();
        Console.WriteLine("Con Mass");
        Console.WriteLine();
        for (int a = 0; a < c.Length; a++)
        {
            Console.WriteLine("{0} = {1}", a, c[a]);
        }
        Console.ReadKey();
    }
}

//7

class S7
{
    static void Main()
    {
        char g;
        Random rnd = new Random();
        char[] q = new char[10];
        Console.WriteLine("Mass");
        Console.WriteLine();
        for (int i = 0; i < q.Length; i++)
        {
            g = (char)rnd.Next(0, 200);
            q[i] = g;
            Console.WriteLine("{0} = {1}", i, q[i]);
        }
        Console.WriteLine();
        Console.WriteLine("Obr Mass");
        Console.WriteLine();
        for (int k = 9; k >= 0; k--)
        {
            Console.WriteLine("{0} = {1}", k, q[k]);
        }
        Console.ReadKey();
    }
}

//8

class S8
{
    static void Main()
    {
        int str = 3, stb = 5, w;
        int[,] r = new int[str, stb];
        int[,] rc = new int[stb, str];
        Random rnd = new Random();
        for (int i = 0; i < r.GetLength(0); i++)
        {
            for (int k = 0; k < r.GetLength(1); k++)
            {
                w = rnd.Next(0, 1000);
                r[i, k] = w;
                Console.Write(r[i, k] + "\t");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
        Console.WriteLine("Zam");
        Console.WriteLine();
        for (int i = 0; i < rc.GetLength(0); i++)
        {
            for (int j = 0; j < rc.GetLength(1); j++)
            {
                rc[i, j] = r[j, i];
                Console.Write(rc[i, j] + "\t");

            }
            Console.WriteLine();
        }
        Console.ReadKey();

    }
}

//9

class S9
{
    static void Main()
    {
        int w, str, stb;
        int[,] r = new int[5, 5];
        int[,] r2 = new int[5, 5];
        Random rnd = new Random();
        for (int i = 0; i < r.GetLength(0); i++)
        {
            for (int k = 0; k < r.GetLength(1); k++)
            {
                w = rnd.Next(0, 100);
                r[i, k] = w;
                Console.Write(r[i, k] + "\t");
            }
            Console.WriteLine();
        }
        str = rnd.Next(0, 5);
        stb = rnd.Next(0, 5);
        Console.WriteLine();
        Console.WriteLine("Id str {0} \nId stb = {1}", str, stb);
        Console.WriteLine();
        for (int i = 0; i < r2.GetLength(0); i++)
        {
            if (i != str)
            {
                for (int k = 0; k < r2.GetLength(1); k++)
                {
                    if (k != stb)
                    {
                        r2[i, k] = r[i, k];
                        Console.Write(r2[i, k] + "\t");
                    }
                }
                Console.WriteLine();
            }
        }
        Console.ReadKey();
    }
}