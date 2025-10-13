namespace Lab2test
{
    [TestClass]
    public sealed class PurpleTest
    {
        Lab2.Purple _main = new Lab2.Purple();
        const double E = 0.0001;

        [TestMethod]
        public void Test1()
        {
            // Arrange
            var input = new int[,] {
                { 1, 2,  3,  4,  5, 10,  10, 10,  25,  50 },
                { 1, 1,  1,  2, 10, 10,  10,  5,   7,  13 },
                { 1, 1, 10, 20, 30, 10, 100, 10, 100, 100 }
            };
            var answer = new double[] { 1, 5, 563, 6096, 33500, 38500, 2941000, 33250, 49421225, 407443450 };
            var test = new double[answer.Length];
            // Act
            for (int i = 0; i < answer.Length; i++)
            {
                test[i] = _main.Task1(input[0, i], input[1, i], input[2, i]);
            }
            // Assert
            for (int i = 0; i < answer.Length; i++)
            {
                Assert.AreEqual(answer[i], test[i], E);
            }
        }
        [TestMethod]
        public void Test2()
        {
            // Arrange
            var input = new int[] { 1, 2, 3, 5, 10, 10, 9, 25, 375, 12345 };
            var answer = new (int q, int r)[] {
                (2, 0),
                (1, 1),
                (1, 2),
                (2, 0),
                (1, 0),
                (0, 9),
                (2, 7),
                (15, 0),
                (32, 345) };
            var test = new (int q, int r)[answer.Length];
            // Act
            for (int i = 0; i < answer.Length; i++)
            {
                test[i] = _main.Task2(input[i + 1], input[i]);
            }
            // Assert
            for (int i = 0; i < answer.Length; i++)
            {
                Assert.AreEqual(answer[i], test[i]);
            }
        }
        [TestMethod]
        public void Test3()
        {
            // Arrange
            var answer = new double[] { 1.618056 };
            var test = new double[answer.Length];
            // Act
            for (int i = 0; i < answer.Length; i++)
            {
                test[i] = _main.Task3();
            }
            // Assert
            for (int i = 0; i < answer.Length; i++)
            {
                Assert.AreEqual(answer[i], test[i], E);
            }
        }
        [TestMethod]
        public void Test4()
        {
            // Arrange
            var input = new double[,] {
                { 1, 1000, 2, 3.5, -1, 10.1, 1.01, 8.8, 0.1, -0.45 },
                { 0.1, 0.1, 0.2, -0.2, -0.5, 0.9, 0.99, -0.8, 0.75, -0.75 }
            };
            var answer = new int[] { 6, 9, 8, 8, 15, 111, 919, 53, 26, 31 };
            var test = new int[answer.Length];
            // Act
            for (int i = 0; i < answer.Length; i++)
            {
                test[i] = _main.Task4(input[0, i], input[1, i]);
            }
            // Assert
            for (int i = 0; i < answer.Length; i++)
            {
                Assert.AreEqual(answer[i], test[i], E);
            }
        }
        [TestMethod]
        public void Test5()
        {
            // Arrange
            var input = new int[,] {
                { 1, 2, 3, 4, 5, 10, 10,  5, 25, 150, 7 },
                { 1, 1, 2, 3, 3, 10,  5, 10, 10,   5, 0 }
            };
            var answer = new double[] { 0, 0, 0, 1, 1, 7, 3, 7, 7, 4, 0 };
            var test = new double[answer.Length];
            // Act
            for (int i = 0; i < answer.Length; i++)
            {
                test[i] = _main.Task5(input[0, i], input[1, i]);
            }
            // Assert
            for (int i = 0; i < answer.Length; i++)
            {
                Assert.AreEqual(answer[i], test[i], E);
            }
        }
        [TestMethod]
        public void Test6()
        {
            // Arrange
            var answer = new long[] { 1229782938247 };
            var test = new long[answer.Length];
            // Act
            for (int i = 0; i < answer.Length; i++)
            {
                test[i] = _main.Task6();
            }
            // Assert
            for (int i = 0; i < answer.Length; i++)
            {
                Assert.AreEqual(answer[i], test[i]);
            }
        }
        [TestMethod]
        public void Test7()
        {
            // Arrange
            var input = new double[,] {
                { 0, 1,   1, 2,  3, 10,  100, 10, 10,  10,  12 },
                { 5, 5, 7.5, 5, 33, 28, 29.5,  1, 10, 12.3, 12 }
            };
            var answer = new int[] { 0, 171, 115, 171, 29, 34, 32, 836, 88, 72 };
            var test = new int[answer.Length];
            // Act
            for (int i = 0; i < answer.Length; i++)
            {
                test[i] = _main.Task7(input[0, i], input[1, i]);
            }
            // Assert
            for (int i = 0; i < answer.Length; i++)
            {
                Assert.AreEqual(answer[i], test[i]);
            }
        }
        [TestMethod]
        public void Test8()
        {
            // Arrange
            var input = new double[,] {
                { 0,    0.1, 0.2, 0.01, 0.001, 0.05,  0.1, 0.09, 0.1 },
                { 0.1,  0.2,   1,  0.1,   0.1,  0.5, 0.99,  0.5, 0.99 },
                { 0.1,  0.2, 0.3, 0.01, 0.001, 0.05,  0.9, 0.05, 1.1 }
            };
            var answer = new (double, double)[] {
                (1.995004, 1.995004),
                (0.995004, 0.995004),
                (2.554356, 2.554356),
                (9.980761, 9.980761),
                (99.830910, 99.830910),
                (9.525304, 9.525304),
                (0.995004, 0.995004),
                (8.552503, 8.552503),
                (0.995004, 0.995004)
            };
            var test = new (double, double)[answer.Length];
            // Act
            for (int i = 0; i < answer.Length; i++)
            {
                test[i] = _main.Task8(input[0, i], input[1, i], input[2, i]);
            }
            // Assert
            for (int i = 0; i < answer.Length; i++)
            {
                Assert.AreEqual(answer[i].Item1, test[i].Item1, E * 10);
                Assert.AreEqual(answer[i].Item2, test[i].Item2, E * 10);
            }
        }
    }
}


