using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.InteropServices;

namespace Lab2
{
    public class Blue
    {
        const double E = 0.0001;
        
        // Задание 1: Вычислить s = sin x + sin 2x/x² + ... + sin nx/x^(n-1)
        public double Task1(int n, double x)
        {
            double answer = 0;

            for (int i = 1; i <= n; i++)
            {
                double denominator = (i == 1) ? 1 : Math.Pow(x, i - 1);
                answer += Math.Sin(i * x) / denominator;
            }

            return answer;
        }

        // Задание 2: Вычислить s = -1/1 + 2/2 - 3/3 + ... + (-1)^n * n/n
        public double Task2(int n)
        {
            double answer = 0;

            for (int i = 1; i <= n; i++)
            {
                double term = (i % 2 == 0) ? 1 : -1; // (-1)^i * i/i = (-1)^i * 1
                answer += term;
            }

            return answer;
        }

        // Задание 3: Найти сумму первых n чисел Фибоначчи (начиная с 0)
        public long Task3(int n)
        {
            if (n <= 0) return 0;
            if (n == 1) return 0;

            long answer = 0;
            long a = 0, b = 1;

            answer += a; // F0 = 0
            if (n > 1) answer += b; // F1 = 1

            for (int i = 2; i < n; i++)
            {
                long next = a + b;
                answer += next;
                a = b;
                b = next;
            }

            return answer;
        }

        // Задание 4: Определить максимальное количество членов арифметической прогрессии
        public int Task4(int a, int h, int L)
        {
            int answer = 0;
            int sum = 0;
            int current = a;

            while (sum + current <= L)
            {
                sum += current;
                answer++;
                current += h;
            }

            return answer;
        }

        // Задание 5: Реализовать схему (кусочно-заданная функция)
        public double Task5(double x)
        {
            double answer = 0;

            if (x <= -1)
                answer = x * x - 1;
            else if (x > -1 && x <= 2)
                answer = 2 * x + 3;
            else // x > 2
                answer = Math.Sqrt(x - 1);

            return answer;
        }

        // Задание 6: Определить время для достижения L клеток амебой
        public int Task6(int h, int S, int L)
        {
            if (S >= L) return 0;

            int answer = 0;
            int currentCells = S;

            while (currentCells < L)
            {
                answer += h;
                currentCells *= 2; // каждые h часов делится на 2 клетки
            }

            return answer;
        }

        // Задание 7: Тренировки спортсмена
        public (double a, int b, int c) Task7(double S, double I)
        {
            double a = 0;
            int b = 0;
            int c = 0;

            // a. суммарный путь за 7 дней
            double dailyDistance = S;
            double totalDistance = 0;
            
            // За 7 дней
            for (int day = 1; day <= 7; day++)
            {
                totalDistance += dailyDistance;
                dailyDistance *= (1 + I/100); // увеличение на I%
            }
            a = totalDistance;

            // b. через сколько дней суммарный путь >= 100 км
            dailyDistance = S;
            totalDistance = 0;
            b = 0;
            while (totalDistance < 100)
            {
                b++;
                totalDistance += dailyDistance;
                dailyDistance *= (1 + I/100);
            }

            // c. через сколько дней дневная норма > 42 км
            dailyDistance = S;
            c = 0;
            while (dailyDistance <= 42)
            {
                c++;
                dailyDistance *= (1 + I/100);
            }

            return (a, b, c);
        }

        // Задание 8: Вычислить сумму рядов и сравнить с аналитической функцией
        public (double SS, double SY) Task8(double a, double b, double h)
        {
            double SS = 0;
            double SY = 0;

            for (double x = a; x <= b; x += h)
            {
                // Вычисление ряда для arctg x
                double seriesSum = 0;
                double term = x;
                int i = 0;
                
                while (Math.Abs(term) >= E)
                {
                    seriesSum += term;
                    i++;
                    term = Math.Pow(-1, i) * Math.Pow(x, 2 * i + 1) / (2 * i + 1);
                }
                
                SS += seriesSum;
                SY += Math.Atan(x); // аналитическое выражение
            }

            return (SS, SY);
        }
    }
}
