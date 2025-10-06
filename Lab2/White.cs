namespace Lab2
{
    public class White
    {
        const double E = 0.0001;
        public int Task1(int n)
        {
            int answer = 0;

            // code here
            for (int i = 1; i<= n; i++)
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
            for (int i = 1; i <= n; i++)
            {
                answer += 1.0 / i;
            }
            // end

            return answer;
        }
        public long Task3(int n)
        {
            long answer = 1;

            // code here
            for (int i = 1; i<=n;  i++)
            {
                answer *= i;
            }
            // end

            return answer;
        }
        public long Task4(int a, int b)
        {
            long answer = 1;

            // code here
            for (int i=0; i<b;i++)
            {
                answer *=a;
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

            // code here
            if (Math.Abs(x)>=1)
            {
                return 0;
            }
            double s = 1e-4;
            double t = 1;
            int n = 0;
            while (Math.Abs(t)>=s)
            {
                answer += t;
                n++;
                t=Math.Pow(x, 2 * n);
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
            const double R = 6371.0; // радиус Земли, км

            // code here
            double h = 0;
            double g = 0;
            while (g < L)
            {
                answer ++;
                h = v * answer;
                g = Math.Sqrt(2*R*h+h*h);
            }
            // end

            return answer;
        }
    }
    }



















