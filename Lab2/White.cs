using static System.Net.WebRequestMethods;

namespace Lab2
{
    public class White
    {
        const double E = 0.0001;
        public int Task1(int n)
        {
            int answer = 0;

            // code here
            answer = (((2 + (3 * n - 1)) * n) / 2);
            // end

            return answer;
        }
        public double Task2(int n)
        {
            double answer = 0;

            // code here
            for(int i = 1; i <= n; i++)
            {
                answer += 1.0 / i;
            }
            // end

            return answer;
        }
        public long Task3(int n)
        {
            long answer = 0;

            // code here
            if (n == 0)
            {
                answer = 1;
            }
            else
            {
                answer = n * Task3(n - 1);
            }

                // end

                return answer;
        }
        public long Task4(int a, int b)
        {
            long answer = 0;

            // code here
            answer = 1;
            for(int i = 0; i < b; i++)
            {
                answer *= a;
            }
            // end

            return answer;
        }
        public int Task5(int L)
        {
            int answer = 0;

            // code here
            int p = 1;
            int a = 1;
            while (p <= L)
            {
                p = p * a;
                a = a + 3;
            }
            answer = a - 3;
            // end

            return answer;
        }
        public double Task6(double x)
        {
            double answer = 0;
            const double R = 6371.0; // радиус Земли, км

            // code here
            double eps = 1e-4;
            double term = 1;
            double x2 = x * x;
            while (term >= eps)
            {
                answer += term;
                term *= x2;
            }
            // end

            return answer;
        }

        public int Task7(int n)
        {
            int answer = 0;

            // code here
            int sum = 0;
            while (sum < n)
            {
                answer++;
                sum += answer;
            }

           
            // end

            return answer;
        }
        public int Task8(double L, double v)
        {
            int answer = 0;
            const double R = 6371.0;
            // code here
            double h = Math.Sqrt(R * R + L * L) - R;
            answer = (int)(Math.Ceiling(h / v));
            // end

            return answer;
        }
    }
}
