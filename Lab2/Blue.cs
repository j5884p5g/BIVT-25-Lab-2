using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.InteropServices;

namespace Lab2
{
    public class Blue
    {
        const double E = 0.0001;
        public double Task1(int n, double x)
        {
            double answer = 0;

            double f = 1;
            for (int i = 1; i<=n; i++)
            {
                answer += Math.Sin(i * x) / f;
                f *= x;
            }

            return answer;
        }
        public double Task2(int n)
        {
            double answer = 0;
            double f5 = -5;
            double ff = 1;

            for (int i = 1; i<=n;i++)
            {
                ff *= i;
                answer += f5 / ff;
                f5 *= -5;
                
            }

            return answer;
        }
        public long Task3(int n)
        {
            long answer = 0;
            long x1 = 0;
            long x2 = 1;
            long f = 0;
            for (int i = 0; i<=n-2; i++)
            {
                answer += x2;
                f = x1;
                x1 = x2;
                x2 += f;
            }

            return answer;
        }
        public int Task4(int a, int h, int L)
        {
            int answer = 0;
            int s = 0;
            while ( L >= s)
            {
                s += a + h * answer;
                answer += 1;
            }
            answer -= 1;
            return answer;
        }
        public double Task5(double x)
        {
            double answer = 0;
            double ch = 0;
            double zn = 1;
            double elem = ch / zn;
            int i = 1;
            do
            {
                ch += i;
                zn *= x;
                answer += elem;
                elem = ch / zn;
                i++;
            }
            while (elem > 0.0001);

            return answer;
        }
        public int Task6(int h, int S, int L)
        {
            int answer = 0;

            do
            {
                answer += h;
                S *= 2;

            }
            while (S < L);
            return answer;
        }
        public (double a, int b, int c) Task7(double S, double I)
        {
            double a = 0;
            int b = 0;
            int c = 0;
            int d = 1;
            double km = 0;
            double kmd = 0;
            double h = S;
            a = S;
            while (d < 7)
            {
                d++;
                S = S + S * I / 100;
                a += S;

            }
            S = h;
            km = S;
            b = 1;
            while (km <=100)
            {
                S = S + S * I / 100;
                km += S;
                b++;
            }
            S = h;
            kmd = S;
            while (kmd<=42)
            {
                S = S + S * I / 100;
                kmd = S;
                c++;
            }
            return (a, b, c);
        }
        public (double SS, double SY) Task8(double a, double b, double h)
        {
            double SS = 0;
            double SY = 0;
            double x = a;
            while (x <= b + 1e-10)
            {
                double x2 = 1;
                int i = 0;
                int j = 1;
                
                do
                {
                    if (i > 0)
                    {
                        j *= i;
                    }
                    SS += ((2 * i + 1) * x2)/j;
                    x2 *= x * x;
                    i++;
                }
                while (Math.Abs(((2 * i + 1) * x2) / j) >= E);
                SY += (1 + 2 * x * x) * Math.Exp(x * x);
                x += h;
            }


                return (SS, SY);
        }
    }
}
