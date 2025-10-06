using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.InteropServices;

namespace Lab2
{
    public class Purple
    {
        const double E = 0.0001;
        public int Task1(int n, int p, int h)
        {
            int answer = 0;

            for (int i = 0; i < n; i++)
            {
                long term = (long)p + (long)i * h;
                answer += (int)(term * term);
            }
            return answer;
        }
   
        public (int quotient, int remainder)  Task2(int a, int b)
        {
            int quotient = 0;
            int remainder = 0;

            int cur = a;
            while (cur >= b)
            {
                cur -= b;
                quotient++;
            }
            remainder = cur;

            return (quotient, remainder);
        }
        public double Task3()
        {
            double answer = 0;

            long p1 = 1, q1 = 1;      
            long p2 = 2, q2 = 1;       
            double prev = (double)p1 / q1;
            double cur = (double)p2 / q2;

            while (Math.Abs(cur - prev) >= E)
            {
                long p3 = p1 + p2;
                long q3 = q1 + q2;

                prev = cur;
                cur = (double)p3 / q3;

                p1 = p2; q1 = q2;
                p2 = p3; q2 = q3;
            }

            answer = cur;

            return answer;
        }
        public int Task4(double b, double q)
        {
            int answer = 1;

            double val = Math.Abs(b);       
            double aq = Math.Abs(q);
            while (val >= E)
            {
                answer++;
                val *= aq;                  
            }

            return answer;
        }
        public int Task5(int a, int b)
        {
            int answer = 0;


            long number = a;
            while (b > 0)
            {
                number *= b;
                b--;
            }

            while (number >= 10)
            {
                number /= 10;
                answer++;
            }

            return answer;
        }
        public long Task6()
        {
            long answer = 0;

            decimal grains = 0m;
            decimal g = 1m;
            for (int i = 0; i < 64; i++)
            {
                grains += g;
                g *= 2m;
            }

            decimal tons = grains / 15_000_000m;   
            answer = (long)Math.Floor(tons);

            return answer;
        }

        public int Task7(double S, double d)
        {
            int answer = 0;

            double target = 2 * S;
            double cur = S;

            while (cur < target)
            {
  
                double monthlyAdd = cur * (d / 100.0) / 12.0;

                for (int m = 0; m < 12 && cur < target; m++)
                {
                    cur += monthlyAdd;
                    answer++;
                }
            }

            return answer;
        }
        public (double SS, double SY) Task8(double a, double b, double h)
        {
            double SS = 0;
            double SY = 0;

            for (double x = a; x <= b + 1e-12; x += h)
            {
                double term = 1.0;   
                double Sx = 0.0;
                int k = 0;

                while (Math.Abs(term) >= E)
                {
                    Sx += term;
                    k++;
                    term *= -x * x / ((2 * k - 1) * (2 * k));
                }

                SS += Sx;
                SY += Math.Cos(x);
            }
            return (SS, SY);
        }
    }
}