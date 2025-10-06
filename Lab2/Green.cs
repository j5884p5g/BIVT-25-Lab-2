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
            for (double i = 2; i <= n; i = i+2) 
            { 
                answer += (i / (i + 1)); 
            } 
            // end 
 
            return answer; 
        } 
        public double Task2(int n, double x) 
        { 
            double answer = 0; 
 
            // code here 
            answer = 1; 
            double a = 1; 
            for (int i = 1; i <= n; i++) 
            { 
                a = a * x; 
                answer += 1/a; 
            } 
            // end 
 
            return answer; 
        } 
        public long Task3(int n) 
        { 
            long answer = 0; 
 
            // code here 
            long f = 1; 
            answer = 1; 
            for (int i = 1; i <= n; i++) 
            { 
                f = f * i; 
                answer += + f; 
            } 
            // end 
 
            return answer; 
        } 
        public double Task4(double x) 
        { 
            double answer = 0; 
 
            // code here 
            int a = 1; 
            double b = x; 
            do 
            { 
                answer += Math.Sin(a * b); 
                a++; 
                b = b * x; 
            } while (Math.Abs(Math.Sin(a * b)) >= 0.0001); 
            // end 
 
            return answer; 
        } 
        public int Task5(double x) 
        { 
            int answer = 0; 
 
            // code here 
            double z1 = 1; 
            double z2 = 1 / x; 
            while (Math.Abs(z1 - z2) >= E) 
            { 
                answer++; 
                z1 = z2; 
                z2 = z2 / x; 
            } 
            answer += 1; 
            // end 
 
            return answer; 
        } 
        public int Task6(int limit) 
        { 
            int answer = 0; 
 
            // code here 
            int elem = 1, i = 0; 
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
            for (double x = a; x <= b + 0.0000000000001; x += h) 
            { 
                double s = 1; 
                double st1 = 1; 
                double st2 = x; 
                int i = 0; 
                while (Math.Abs(s) >= E) 
                { 
                    s = st1 * st2 / (2 * i + 1); 
                    SS += s; 
                    st1 = st1 * (-1); 
                    st2 = st2 * x * x; 
                    i++; 
                } 
                SY += Math.Atan(x); 
            } 
            // end 
 
            return (SS, SY); 
        } 
    } 
}
