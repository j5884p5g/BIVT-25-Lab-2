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
            answer += 1;

            double dl = x;
            for (int i = 1; i <= n; i++)
            {
                answer += 1 / dl;
                dl *= x;
            }

            // end

            return answer;
        }
        public long Task3(int n)
        {
            long answer = 0;

            // code here
            long f = 1;
            for (int i = 1; i <= n; i++)
            {
                f *= i;
                answer += f;
            }
            answer += 1;
            // end

            return answer;
        }
        public double Task4(double x)
        {
            double answer = 0;

            // code here
            double paw = x;
            for (int i = 1; Math.Abs(Math.Sin(i * paw)) >= E; i++)
            {
                answer += Math.Sin(i * paw);
                paw *= x;
            }
            // end

            return answer;
        }
        public int Task5(double x)
        {
            int answer = 0;

            // code here
            double zn = x;
            while (Math.Abs(1 / zn - x / zn) >= E)
            {
                answer += 1;
                zn *= x;
            }
            answer += 1;
            // end

            return answer;
        }
        public int Task6(int limit)
        {
            int answer = 0;

            // code here
            int elem = 1; int i = 0;
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
                L = L / 2;
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
            for (double x = a; x <= b + E; x += h)
            {
                SY += Math.Atan(x);
                int sn = -1;
                double mn = 1;
                for (int i = 0; ; i++)
                {
                    double s = -1 * sn * x * mn / (2 * i + 1);
                    SS += s;
                    sn *= -1;
                    mn *= x * x;
                    if (Math.Abs(s) < E) {break; }
                }
            }
            // end

            return (SS, SY);
        }
    }
}
