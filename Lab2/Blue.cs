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
            for (int k = 1; k <= n; k++)
                answer += Math.Sin(k * x) / Math.Pow(x, k - 1);
            // end

            return answer;
        }
        public double Task2(int n)
        {
            double answer = 0;

            // code here
            double term = -5;
            for (int k = 1; k <= n; k++)
            {
                if (k > 1) term *= -5.0 / k;
                answer += term;
            }
            // end

            return answer;
        }
        public long Task3(int n)
        {
            long answer = 0;

            // code here
            if (n == 0) answer = 0;
            else
            {
                long f0 = 0, f1 = 1;
                for (int i = 2; i <= n + 1; i++)
                {
                    long t = f0 + f1;
                    f0 = f1;
                    f1 = t;
                }
                answer = f1 - 1;
            }
            // end

            return answer;
        }
        public int Task4(int a, int h, int L)
        {
            int answer = 0;

            // code here
            int sum = 0, n = 0;
            while (true)
            {
                int next = a + n * h;
                if (sum + next > L) break;
                sum += next;
                n++;
            }
            answer = n;
            // end

            return answer;
        }
        public double Task5(double x)
            {
                double answer = 0;
            
                // code here
                if (x <= 0)
                {
                    answer = 0;
                }
                else
                {
                    double ch = 0, zn = 1, elem;
                    int i = 1;
                    do
                    {
                        ch += i;
                        zn *= x;
                        elem = ch / zn;
                        answer += elem;
                        i++;
                    } while (Math.Abs(elem) > 0.0001);
                }
                // end
            
                return answer;
            }

        public int Task6(int h, int S, int L)
        {
            int answer = 0;

            // code here
            int cells = S, t = 0;
            while (cells < L)
            {
                cells *= 2;
                t += h;
            }
            answer = t;
            // end

            return answer;
        }
        public (double a, int b, int c) Task7(double S, double I)
        {
            double a = 0;
            int b = 0;
            int c = 0;

            // code here
            double r = 1 + I / 100.0;
            double dist = S, total = 0;
            for (int d = 0; d < 7; d++)
            {
                total += dist;
                dist *= r;
            }
            a = total;
            dist = S; total = 0;
            while (total < 100)
            {
                total += dist;
                dist *= r;
                b++;
            }
            dist = S;
            while (dist <= 42)
            {
                dist *= r;
                c++;
            }
            // end

            return (a, b, c);
        }
        public (double SS, double SY) Task8(double a, double b, double h)
        {
            double SS = 0;
            double SY = 0;

            // code here
            for (double x = a; x <= b + E; x += h)
            {
                double sum = 0;
                int i = 0;
                double term;
                do
                {
                    double f = 1;
                    for (int j = 2; j <= i; j++) f *= j;
                    term = (2 * i + 1) * Math.Pow(x, 2 * i) / f;
                    sum += term;
                    i++;
                }
                while (Math.Abs(term) > E);
                SS += sum;
                SY += (1 + 2 * x * x) * Math.Exp(x * x);
            }
            // end

            return (SS, SY);
        }
    }
}

