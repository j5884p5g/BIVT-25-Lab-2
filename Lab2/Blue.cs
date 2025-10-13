using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
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

            double exp = 1.0; 
            for (int i = 1; i <= n; i++)
            {
                double top = Math.Sin(i * x);
                answer += top / exp;   
                exp *= x;              
            }

            // end

                return answer;
        }
        public double Task2(int n)
        {
            double answer = 0.0;

            double pow = 1.0; // 5^0
            double fact = 1.0; // <-- antes int; evita overflow
            int sign = -1;     // (-1)^1

            for (int i = 1; i <= n; i++)
            {
                pow *= 5.0;     // 5^i
                fact *= i;      // i!
                answer += sign * (pow / fact);
                sign *= -1;     // alternar signo
            }

            return answer;
        }
        public long Task3(int n)
        {
            long answer = 0;

            // code here
            if (n <= 0)
            {
                answer = 0;
            }
            else
            {
                long sum = 0;
                long a = 0;
                long b = 1;

                for (int i = 0; i < n; i++)
                {
                    sum += a;
                    long next = a + b;
                    a = b;
                    b = next;
                }

                answer = sum;
            }
            // end

                return answer;
        }
        public int Task4(int a, int h, int L)
        {
            int answer = 0;

            int s = 0;
            int num = 0;

            for (int i = 1; ; i++)                 // ← quitamos s<L del header
            {
                int sequence = a + (i - 1) * h;
                if (s + sequence > L) break;       // ← si me paso, corto

                s += sequence;
                num++;
            }

            answer = num;
            return answer;
        }

        public double Task5(double x)
        {
            double answer = 0.0;
            // code here
            double ch = 0.0, zn = 1.0;
            double elem = ch / zn;  // 0 al inicio
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
            if (S >= L)
            {
                return answer;
            }
            else
            {
                int initialQuantity = S;
                int time = 0;
                while (initialQuantity < L)
                {
                    initialQuantity *= 2;
                    time += h;
                }
                answer = time;
            }

            // end

            return answer;
        }
        public (double a, int b, int c) Task7(double S, double I)
        {
            double r = 1 + I / 100.0;

            // a) total en 7 días
            double a = 0;
            double d = S;
            for (int i = 1; i <= 7; i++)
            {
                a += d;
                d *= r;
            }

            // b) días hasta acumular 100 km (esta suele estar bien)
            int b = 0;
            double acumulado = 0;
            d = S;
            while (acumulado < 100)
            {
                acumulado += d;
                d *= r;
                b++;
            }

            // c) primer día con distancia diaria > 42 km
            // Cambiar aquí: empezar en 0 para coincidir con el test
            int c = 0;   // <-- antes era 1
            d = S;
            while (d <= 42)
            {
                d *= r;
                c++;
            }

            return (a, b, c);   
        }

        public (double SS, double SY) Task8(double a, double b, double h)
        {
            double SS = 0.0;
            double SY = 0.0;

            if (h <= 0) return (0, 0);

            // Iteración por índice entero para cubrir [a, b] de forma robusta
            for (int k = 0; ; k++)
            {
                double x = a + k * h;
                if (x > b + 1e-12) break; // incluye b si cae en malla (tolerancia)

                // --- Serie S(x) = Σ (2i+1) * x^(2i) / i! ---
                double Sx = 0.0;
                double q = 1.0; // x^(0)/0! = 1
                int i = 0;

                while (true)
                {
                    double term = (2 * i + 1) * q;

                    // Incluir también el primer término con |term| < E y luego cortar
                    Sx += term;
                    if (Math.Abs(term) < E) break;

                    i++;
                    q *= (x * x) / i; // q_{i+1} = q_i * x^2 / (i)
                }

                // --- Forma analítica ---
                double y = (1 + 2 * x * x) * Math.Exp(x * x);

                SS += Sx;
                SY += y;
            }

            return (SS, SY);
        }

    }
}

























