using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.InteropServices;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Lab2
{
    public class Blue
    {
        const double E = 0.0001;
        public double Task1(int n, double x)
        {
            double answer = 0;

            // code here
            double sum = 0;
            for (int c = 1; c <= n; c++)
            {
                sum += Math.Sin(c * x) / Math.Pow(x, c - 1);
                answer = sum;
            }
            // end

            return answer;
        }
        public double Task2(int n)
        {
            double answer = 0;

            // code here
            double s = 0;
            long fact = 1;
            for (int c = 1; c <= n; c++)
            {
                fact *= c;
                s += Math.Pow(-1, c) * (Math.Pow(5, c) / fact);
                answer = s;
            }
            // end

            return answer;
        }
        public long Task3(int n)
        {
            long answer = 0;

            // code here
            long ch1 = 0;
            long ch2 = 1;
            long sum = 0;
            for (int c = 0; c < n; c++)
            {
                sum += ch1;
                long next = ch1 + ch2;
                ch1 = ch2;
                ch2 = next;
                answer = sum;
            }
            // end

            return answer;
        }
        public int Task4(int a, int h, int L)
        {
            int answer = 0;

            // code here
            //int sum = a;
            //int n = 0;
            //int i = 1;

            //while (sum < L)
            //{
            //    sum += a + i * h;
            //    i++;
            //    n++;
            //    answer = n;
            //}

            //int s = 0;

            //for (int n = 1; s <= L; n++)
            //{
            //    s += a + (n - 1) * h;
            //    answer = n;
            //}


            int s = 0;


            for (int n = 1; ; n++)
            {
                int term = a + (n - 1) * h;
                if (s + term > L) break;

                s += term;
                answer = n;
            }

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
            while (true)
            {
                ch += i;
                zn *= x;
                answer += elem;
                elem = ch / zn;
                i++;
                if (elem <= 0.0001)
                    break;
            }

            // end

            return answer;
        }
        public int Task6(int h, int S, int L)
        {
            int answer = 0;

            // code here
            int time = 0;
            int cells = S;
            while (cells < L)
            {
                cells *= 2;
                time += h;
                answer = time;
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
            double start = S;
            double rate = I / 100.0;



            // a)
            double sum = 0.0;
            double distance = start;
            for (int day = 1; day <= 7; day++)
            {
                sum += distance;
                distance *= (1.0 + rate);
            }
            a = Math.Round(sum, 6);

            // b) 
            double targetSum = 100.0;
            double total = start;
            distance = start;
            int days = 1;
            if (total < targetSum)
            {
                while (total < targetSum)
                {
                    distance *= (1.0 + rate);
                    total += distance;
                    days++;
                }
            }
            b = days;

            // c)
            double targetDaily = 42.0;
            if (start > targetDaily)
            {
                c = 0;
            }
            else
            {
                distance = start;
                int wait = 0;
                while (distance <= targetDaily)
                {
                    distance *= (1.0 + rate);
                    wait++;
                }
                c = wait;
            }

            return (a, b, c);
        }


        public (double SS, double SY) Task8(double a, double b, double h)
        {
            double SS = 0;
            double SY = 0;
            double epsilon = 0.0001;

            // code here
            for (double x = a; x <= b + 0.0001; x += h)
            {
                double sum = 0;
                double term;
                int i = 0;
                double factorial = 1;
                double x_power = 1;

                
                do
                {
                    term = (2 * i + 1) * x_power / factorial;
                    sum += term;

                    i++;
                    factorial *= i;
                    x_power *= x * x;

                } while (Math.Abs(term) >= epsilon && i < 100);

                
                double y = (1 + 2 * x * x) * Math.Exp(x * x);

                
                SS += sum;
                SY += y;
                // end
            }
            return (SS, SY);

        }
    }
}
    
