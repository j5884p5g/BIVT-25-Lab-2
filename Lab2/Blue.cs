using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.Design;
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

            double a = Math.Sin(x);
            double b = 1;
            for (int i = 1; i <= n; i++)
            {
                a = Math.Sin(x * i);

                answer += a / b;
                b *= x;
            }

            // end

            return answer;
        }
        public double Task2(int n)
        {
            double answer = 0;

            // code here

            double fact = 1;
            double a = 5;
            int b = -1;
            for (int i = 1; i <= n; i++)
            {
                answer += b * a / fact;
                b *= -1;
                a *= 5;
                fact *= (i + 1);
            }


            // end

            return answer;
        }
        public long Task3(int n)
        {
            long answer = 0;

            // code here
            int a = 0;
            int b = 1;
            for (int i = 0; i < n; i++)
            {
                answer += a;
                int c = a + b;
                a = b; b = c;
            }
            // end

            return answer;
        }
        public int Task4(int a, int h, int L)
        {
            int answer = 0;

            // code here
            int s = 0;

            while (s <= L)
            {


                s += (a + (answer) * h);
                answer = answer + 1;


            }
            answer--;

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

            }
            while (elem > 0.0001);




            // end

            return answer;
        }
        public int Task6(int h, int S, int L)
        {
            int answer = 0;

            // code here
            while (S < L)
            {
                answer += h;
                S = S * 2;



            }
            // end

            return answer;
        }
        public (double a, int b, int c) Task7(double S, double I)
        {
            double a = 0;
            int b = 0;
            int c = 0;

            // code here
            double v = S;
            for (int i = 1; i <= 7; i++)
            {
                a += v;
                v *= (1 + (I / 100));

            }
            double sum = 0;
            v = S;
            while (sum < 100)
            {
                b++;
                sum += v;
                v *= (1 + (I / 100));

            }
            v = S;

            while (v <= 42)
            {
                c++;
                v *= (1 + I / 100);
            }








            // end

            return (a, b, c);
        }
        public (double SS, double SY) Task8(double a, double b, double h)
        {
            double SS = 0;
            double SY = 0;

            // code here

            double epsilon = 0.0001;

            for (double x = a; x <= b + 1e-10; x += h)
            {
                double sum = 0;
                int i = 0;
                double term;

                do
                {
                    term = (2 * i + 1) * Math.Pow(x, 2 * i) / Factorial(i);
                    sum += term;
                    i++;
                } while (Math.Abs(term) >= epsilon);

                double y = (1 + 2 * x * x) * Math.Exp(x * x);

                SS += sum;
                SY += y;
            }

            static double Factorial(int n)
            {
                double result = 1;
                for (int i = 2; i <= n; i++)
                {
                    result *= i;
                }
                return result;
            }
           

            return (SS, SY);
        }
    }
}
