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
            for(int i=1;i<=n;i++)
            {
                answer += Math.Sin(i * x) / Math.Pow(x, i - 1);
            }
            // end

            return answer;
        }
        public double Task2(int n)
        {
            double answer = 0;

            // code here
            double factorial = 1;
            double power = 1;

            for (int i = 1; i <= n; i++)
            {
                factorial *= i;
                power *= 5;
                double term = power / factorial;

                if (i % 2 == 0)
                    answer += term;
                else
                    answer -= term;
            }
            // end

            return answer;
        }
        public long Task3(int n)
        {
            long answer = 0;

            // code here
            if (n >= 1) answer += 0;
            if (n >= 2) answer += 1;

            long prev1 = 0;
            long prev2 = 1;

            for (int i = 3; i <= n; i++)
            {
                long current = prev1 + prev2;
                answer += current;
                prev1 = prev2;
                prev2 = current;
            }
            // end

            return answer;
        }
        public int Task4(int a, int h, int L)
        {
            int answer = 0;

            // code here 
            int n = 1;
            while (true)
            {
                long Sn = (long)n * (2 * a + (n - 1) * h) / 2;
                if (Sn > L)
                {
                    answer = n - 1;
                    break;
                }
                n++;
            }
                // end

                return answer;
        }
        public double Task5(double x)
        {
            double answer = 0;

            // code here
            double ch = 0, zn = 1;
            double elem = ch / zn;
            int i = 1;

            do
            {
                ch += i;
                zn *= x;
                answer += elem;
                elem = ch / zn;
                i++;
            } while (elem > 0.0001);

            // end

            return answer;
        }
        public int Task6(int h, int S, int L)
        {
            int answer = 0;

            // code here
            int currentCells = S;
            int time = 0;

            while (currentCells < L)
            {
                time += h;
                currentCells *= 2;
            }
            answer = time;
            // end

            return answer;
        }
        public (double a, int b, int c) Task7(double S, double I)
        {
            double a = 0;
            int b = 0;
            int c = 0;

            // code here
            double coef = 1 + I / 100.0;

            // a) за 7 дней
            double daily = S;
            a = 0;
            for (int day = 1; day <= 7; day++)
            {
                a += daily;
                daily *= coef;
            }

            // b) суммарный путь 100 км
            double total = 0;
            daily = S;
            b = 0;
            while (total < 100)
            {
                b++;
                total += daily;
                daily *= coef;
            }

            // c) дневная норма > 42 км
            daily = S;
            c = 0;
            while (daily <= 42)
            {
                c++;
                daily *= coef;
            }
            // end

            return (a, b, c);
        }
        public (double SS, double SY) Task8(double a, double b, double h)
        {
            double SS = 0;
            double SY = 0;

            // code here
            for (double x = a; x <= b + 0.0001; x += h)
            {
                int i = 0;
                double t = 1, sum = 1;
                do
                {
                    i++;
                    t = t * ((2 * i + 1) * x * x / (i * (2 * i - 1)));
                    sum += t;
                } while (t >= 0.0001);

                SS += sum;
                SY += (1 + 2 * x * x) * Math.Exp(x * x);
            }
            // end

            return (SS, SY);
        }
    }
}
