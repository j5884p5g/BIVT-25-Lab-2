using System.Collections.Generic;

namespace Lab2
{
    public class Green
    {
        const double E = 0.0001;
        const double Da = 0.0000000001;
        public double Task1(int n)
        {
            double answer = 0;

            // code here
            for (int i = 2; i <= n; i += 2)
            {
                answer += (double)i / (i + 1);
            }
            // end

            return answer;
        }
        public double Task2(int n, double x)
        {
            double answer = 0;

            // code here
            for (int i = 0;i <= n;i++)
            {
                answer += (double)Math.Pow(x, -i);
            }
            // end

            return answer;
        }
        public long Task3(int n)
        {
            long answer = 0;

            // code here
            long f = 1;
            for (int i = 0; i <= n; i++)
            {
                if (i == 0)
                {
                    f = 1;
                }
                else
                {
                    f *= i;
                }
                answer += f;
            }
            // end

            return answer;
        }
        public double Task4(double x)
        {
            double answer = 0;

            // code here
            for (int i = 1; ;i++)
            {
                double t;
                t = Math.Sin(i * Math.Pow(x, i));
                if (Math.Abs(t) >= E)
                {
                    answer += t;
                }
                else
                {
                    break;
                }
            }
            // end

            return answer;
        }
        public int Task5(double x)
        {
            int answer = 0;

            // code here
            while (Math.Abs(1 / Math.Pow(x, answer) - 1/Math.Pow(x, answer - 1)) >= E)
                answer += 1;
            // end

            return answer;
        }
        public int Task6(int limit)
        {
            int answer = 0;

            // code here
            int elem = 1;
            int i = 0;
            while (elem < limit)
            {
                elem *= 2;
                answer += elem;
                i++;
            }
            // end

            return answer;
        }

        public int Task7(double L)
        {
            int answer = 0;

            // code here
            while (L > Da)
            {
                L /= 2;
                answer++;
            }
            // end

            return answer;
        }
        public (double SS, double SY) Task8(double a, double b, double h)
        {
            double SS = 0;
            double SY = 0;

            // code here 
            for (double x = a; x <= b + 0.0001; x += h)
            {
                int p = -1;
                double n = 1;
                double sn = 1;
                int i = 0;
                while (Math.Abs(sn) >= E)
                {
                    sn = -p * x * n / (2 * i + 1);
                    p = -1 * p;
                    SS += sn;
                    n = n * x * x;
                    i++;
                }

                SY += Math.Atan(x);
            }
            // end

            return (SS, SY);
        }
    }
}
