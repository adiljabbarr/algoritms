using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greatest_Common_Divisor
{
class Program
{

    static int GetNum(string text)
    {
        bool IsItANumber = false;
        int x = 0;
        Console.WriteLine(text);

        do
        {
            IsItANumber = int.TryParse(Console.ReadLine(), out x);

        } while (!IsItANumber);

        return x;
    }
    static void Main(string[] args)
    {
        string text = "birinci nomre daxil ele";
        int x = GetNum(text);
        text = "ikinci nomre daxil ele";
        int y = GetNum(text);


        int z = ebob(x, y);
        Console.WriteLine(z);
    }

    private static int ebob(int x, int y)
    {
        int v = 0;
        int n = 0;

        v = enboyukortaqbolen(x, y);


        return v;

    }

    static int enboyukortaqbolen(int m, int h)
        {

            do
            {
                for (int i = m; i <= 1; i--)



                    if (m%i == 0 && h%i == 0)
                    {
                        int x = 0;
                        x = i;

                        return x;
                    }
            } while (true);
            return m;
        }

  }
}