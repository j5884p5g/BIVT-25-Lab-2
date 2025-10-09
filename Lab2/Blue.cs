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
            double s = Math.Sin(x);
            for (int i = 2; i <= n; i++)
            {
                s += Math.Sin(i * x) / Math.Pow(x, i - 1);
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
            for (int i = 1; i <= n; i++)
            {
                s += Math.Pow(-1, i + 1) * Math.Pow(5, i) / Factorial(i);
            }
            answer = s;
            // end

            return answer;
        }

        private double Factorial(int n)
        {
            double f = 1;
            for (int i = 2; i <= n; i++) f *= i;
            return f;
        }

        public long Task3(int n)
        {
            long answer = 0;

            // code here
            if (n < 2) answer = 0;
            else if (n == 2) answer = 1;
            else
            {
                long a = 0, b = 1;
                for (int i = 2; i <= n; i++)
                {
                    long temp = a + b;
                    a = b;
                    b = temp;
                }
                answer = a + b;
            }
            // end

            return answer;
        }

        public int Task4(int a, int h, int L)
        {
            int answer = 0;

            // code here
            int n = 0;
            double sum = a;
            while (sum <= L)
            {
                n++;
                sum = n * (2 * a + (n - 1) * h) / 2.0;
                if (sum > L) break;
            }
            answer = n;
            // end

            return answer;
        }

        public double Task5(double x)
        {
            double answer = 0;

            // code here
            double ch = 0, zn = 1, elem = 1;
            int i = 1;
            while (Math.Abs(elem) > 0.0001)
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
            int t = 0;
            int cells = S;
            while (cells < L)
            {
                t += h;
                cells *= 2;
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
            double dist = S;
            double total = 0;
            for (int i = 1; i <= 7; i++)
            {
                total += dist;
                dist += dist * I / 100.0;
            }
            a = total;

            dist = S;
            int day = 0;
            total = 0;
            while (total < 100)
            {
                total += dist;
                dist += dist * I / 100.0;
                day++;
            }
            b = day;

            dist = S;
            int d = 0;
            while (dist <= 42)
            {
                dist += dist * I / 100.0;
                d++;
            }
            c = d;
            // end

            return (a, b, c);
        }

        public (double SS, double SY) Task8(double a, double b, double h)
        {
            double SS = 0;
            double SY = 0;

            // code her
