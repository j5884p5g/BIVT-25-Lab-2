using System.Runtime.Intrinsics.X86;

namespace Lab2
{
    public class White
    {
        const double E = 0.0001;
        public int Task1(int n)
        {
            int answer = 0;

            // code here
            int a1 = 2;
            int a2 = 3 * n - 1;
            int d = 3;
            answer = (((2 * a1 + (n - 1) * d)) * n) / 2;
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
                s = s + 1.0 / i;
            }

            // end
            answer = s;

            return answer;
        }
        public long Task3(int n)
        {
            long answer = 0;

            // code here
            long s = 1;
            for (int i = 1; i <= n; i++)
                s = s * i;
            // end
            answer = s;
            return answer;
        }
        public long Task4(int a, int b)
        {
            long answer = 0;

            // code here
            long s = 1;
            for (int i = 1; i <= b; i++)
                s *= a;
            // end
            answer = s;
            return answer;
        }
        public int Task5(int L)
        {
            int answer = 0;

            // code here
            int s = 1;
            int n = 1;
            while (s <= L)
            {
                s *= n;
                n += 3;

            }
            // end
            answer = n - 3;
            return answer;
        }
        public double Task6(double x)
        {
            double answer = 0;
            double miniC = 0.0001;
            double s = 1.0;
            double tek = 1.0;
            // code here
            while (tek >= miniC)
            {
                tek = tek * x * x;
                s = s + tek;
            }
            // end
            answer = s;
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

            // end


        }
        public int Task8(double L, double v)
        {
            int answer = 0;
            const double R = 6371.0; // радиус Земли, км
            double Height = 0;
            double Horizon = 0;
            // code here
            while (Horizon <= L)
            {
                answer++;
                Height += v;
                Horizon = Math.Sqrt((2 * R * Height) + (Height * Height));
            }
            // end

            return answer;
        }
    }

}