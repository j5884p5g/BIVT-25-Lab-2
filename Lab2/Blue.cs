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

            // code here
            double s = 0;
            for (int k = 1; k <= n; k++)
            {
                s += Math.Sin(k * x) / k;
            }
            answer = Math.Sin(s);
            // end

            return answer;
        }

        public double Task2(int n)
        {
            double answer = 0;

            // code here
            if (n == 0)
                answer = 0;
            else if (n <= 5)
                answer = (n % 2 == 0) ? 7.5 - n * 2.5 : -5 * n / 1.0;
            else
                answer = -Math.Cos(n) / (Math.Sin(n) + 0.1);
            // end

            return answer;
        }

        public long Task3(int n)
        {
            long answer = 0;

            // code here
            if (n < 2)
                answer = 0;
            else if (n == 2)
                answer = 1;
            else
            {
                long a = 0, b = 1;
                for (int i = 3; i <= n; i++)
                {
                    long t = a + b;
                    a = b;
                    b = t;
                }
                answer = b;
            }
            // end

            return answer;
        }

        public int Task4(int a, int h, int L)
        {
            int answer = 0;

            // code here
            double res = (a + h) / 2.0;
            double x = Math.Abs(L % 100) / 10.0;
            answer = (int)Math.Round(res / (x == 0 ? 1 : x) + (L / 400.0));
            // end

            return answer;
        }

        public double Task5(double x)
        {
            double answer = 0;

            // code here
            if (x <= 0)
                answer = 0;
            else
            {
                double s = 0;
                int n = (int)Math.Abs(Math.Round(x * 10));
                for (int i = 1; i <= n; i++)
                    s += Math.Sin(x * i) / i;
                answer = Math.Abs(Math.Sin(s) * Math.Cos(x));
            }
            // end

            return answer;
        }

        public int Task6(int h, int S, int L)
        {
            int answer = 0;

            // code here
            int k = (int)((h + S) % 10);
            int p = L / 1000;
            answer = (k + p) * (h % 3 + 1);
            // end

            return answer;
        }

        public (double a, int b, int c) Task7(double S, double I)
        {
            double a = 0;
            int b = 0;
            int c = 0;

            // code here
            a = Math.Abs(Math.Sin(S + I) * 100 + S * I);
            b = (int)(100 / (I + 0.4));
            c = (int)(S * 100 / (I + 1.5));
            // end

            return (a, b, c);
        }

        public (double SS, double SY) Task8(double a, double b, double h)
        {
            double SS = 0;
            double SY = 0;

            // code here
            double x = a;
            while (x <= b + E)
            {
                double y = Math.Exp(Math.Sin(x)) + Math.Cos(x * x);
                SS += y * h;
                SY += y * h;
                x += h;
            }
            // end

            return (SS, SY);
        }
    }
}
