namespace Lab2
{
    public class White
    {
        const double E = 0.0001;
        public int Task1(int n)
        {
            int answer = 0;

            // code here
            if (n <= 0) return 0;
            for(int i = 1; i <= n; i++)
            {
                answer += 3 * i - 1;
            }
            // end

            return answer;
        }
        public double Task2(int n)
        {
            double answer = 0;

            // code here
            if (n <= 0) return 0;
            double sum = 0;
            for (int i = 1; i <= n; i++)
            {
                sum += 1.0 / i;
            }
            answer = sum;
            // end

            return answer;
        }
        public long Task3(int n)
        {
            long answer = 0;

            // code here
            long factorial = 1;
            for (int i = 1; i <= n; i++)
            {
                factorial *= i;
            }
            answer = factorial;
            // end

            return answer;
        }
        public long Task4(int a, int b)
        {
            long answer = 1;

            // code here
            for (int i = 1; i <= b; i++)
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
            for (int n = 1; p <= L; n += 3)
            {
                p *= n;
                answer = n;
            }
            // end

            return answer;
        }
        public double Task6(double x)
        {
            double answer = 0;

            // code here
            double sum = 0;
            double term = 1;

            while (term >= 1e-4)
            {
                sum += term;
                term *= x * x;
            }
            answer = sum;
            // end
            
            return answer;
        }

        public int Task7(int n)
        {
            int answer = 0;
            int sum = 0;
            // code here
            while (sum < n)
            {
                answer++;
                sum += answer;
            }
                return answer;
        }

        public int Task8(double L, double v)
        {
            {
                int answer = 0;

                // code here
                double k = 0;
                double h = 0;
                double R = 6371;

                for (int t = 0; k <= L; t+=1)
                {
                    h = v*t;
                    k = Math.Sqrt((R + h) * (R + h) - R * R);
                    answer = t;
                }
                // end
                
                return answer;
            }
        }
    }
}
