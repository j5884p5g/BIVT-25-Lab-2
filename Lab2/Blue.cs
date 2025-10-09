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
                double term = Math.Sin(k * x) / Math.Pow(x, k - 1);
                s += term;
            }
            answer = s;
            // end

            return answer;
        }

        public double Task2(int n)
        {
            double answer = 0;

            // code here
            double s = 0;
            double term = -5; 
            for (int k = 1; k <= n; k++)
            {
                if (k == 1)
                {
                    s += term;
                }
                else
                {
                    term *= -5.0 / k; 
                    s += term;
                }
            }
            answer = s;
            // end

            return answer;
        }

        public long Task3(int n)
        {
            long answer = 0;

            // code here
            if (n == 0)
            {
                answer = 0;
            }
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
            int n = 0;
            int next = a;
            int sum = 0;
            while (sum + next <= L)
            {
                sum += next;
                n++;
                next = a + n * h;
            }
            answer = n;
            // end

            return answer;
        }

        public double Task5(double x)
        {
            double answer = 0;

            // code here
            double ch = 0;
            double zn = 1;
            double elem = ch / zn; 
            int i = 1;
            while (elem > 0.0001)
            {
                ch += i;
                zn *= x;
                answer += elem;
                elem = ch / zn;
                i++;
            }
            // end

            return answer;
        }

        public int Task6(int h, int S, int L)
        {
            int answer = 0;

            // code here
            int cells = S;
            int t = 0;
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
            double r = 1.0 + I / 100.0;

            double dayDist = S;
            double total = 0;
            for (int d = 1; d <= 7; d++)
            {
                total += dayDist;
                dayDist *= r;
            }
            a = total;

            dayDist = S;
            total = 0;
            int days = 0;
            while (total < 100)
            {
                total += dayDist;
                dayDist *= r;
                days++;
            }
            b = days;

            dayDist = S;
            int dgt = 0;
            while (dayDist <= 42)
            {
                dayDist *= r;
                dgt++;
            }
            c = dgt;
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
                double Ssum = 0;
                int i = 0;
                while (true)
                {
                    double term = (2 * i + 1) * Math.Pow(x, 2 * i) / Fact(i);
                    Ssum += term;
                    if (Math.Abs(term) < E) break;
                    i++;
                }
                SS += Ssum;
                SY += (1 + 2 * x * x) * Math.Exp(x * x);
            }
            // end

            return (SS, SY);
        }

        
    }
}
