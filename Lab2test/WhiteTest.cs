namespace Lab2test
{
    [TestClass]
    public sealed class WhiteTest
    {
        Lab2.White _main = new Lab2.White();
        const double E = 0.0001;

        [TestMethod]
        public void Test1()
        {
            // Arrange
            var input = new int[] { 1, 2, 3, 10, 11, 12, 25 };
            var answer = new int[] { 2, 7, 15, 155, 187, 222, 950 };
            var test = new int[answer.Length];
            // Act
            for (int i = 0; i < answer.Length; i++)
            {
                test[i] = _main.Task1(input[i]);
            }
            // Assert
            for (int i = 0; i < answer.Length; i++)
            {
                Assert.AreEqual(answer[i], test[i]);
            }
        }
        [TestMethod]
        public void Test2()
        {
            // Arrange
            var input = new int[] { 1, 2, 3, 10, 11, 12, 25 };
            var answer = new double[] { 1, 1.5, 1.833333, 2.928968, 3.019877, 3.103211, 3.815958 };
            var test = new double[answer.Length];
            // Act
            for (int i = 0; i < answer.Length; i++)
            {
                test[i] = _main.Task2(input[i]);
            }
            // Assert
            for (int i = 0; i < answer.Length; i++)
            {
                Assert.AreEqual(answer[i], test[i], E);
            }
        }
        [TestMethod]
        public void Test3()
        {
            // Arrange
            var input = new int[] { 0, 1, 2, 3, 10, 11, 12, 25 };
            var answer = new long[] { 1, 1, 2, 6, 3628800, 39916800, 479001600, 7034535277573963776 };
            var test = new long[answer.Length];
            // Act
            for (int i = 0; i < answer.Length; i++)
            {
                test[i] = _main.Task3(input[i]);
            }
            // Assert
            for (int i = 0; i < answer.Length; i++)
            {
                Assert.AreEqual(answer[i], test[i]);
            }
        }
        [TestMethod]
        public void Test4()
        {
            // Arrange
            var input = new int[]   { 0, 1, 1, 2, 3, 1, 10, 11, 12, 2 };
            var answer = new long[] { 0, 1, 1, 8, 3, 1, 100000000000, 3138428376721, 144, 1 };
            var test = new long[answer.Length];
            // Act
            for (int i = 0; i < answer.Length; i++)
            {
                test[i] = _main.Task4(input[i], input[(i + 1) % input.Length]);
            }
            // Assert
            for (int i = 0; i < answer.Length; i++)
            {
                Assert.AreEqual(answer[i], test[i]);
            }
        }
        [TestMethod]
        public void Test5()
        {
            // Arrange
            var input = new int[] { 1, 2, 10, 100, 1234, 12345, 25000, 100000000, 1000000000 };
            var answer = new int[] { 4, 4, 7,  10,  13,    16,    16,      25,      37 };
            var test = new int[answer.Length];
            // Act
            for (int i = 0; i < answer.Length; i++)
            {
                test[i] = _main.Task5(input[i]);
            }
            // Assert
            for (int i = 0; i < answer.Length; i++)
            {
                Assert.AreEqual(answer[i], test[i]);
            }
        }
        [TestMethod]
        public void Test6()
        {
            // Arrange
            var input = new double[] { 0, 0.1, 0.2, 0.3, -0.1, -0.2, 0.78, -0.95 };
            var answer = new double[] { 1, 1.010101, 1.041664, 1.0988946, 1.010101, 1.041664, 2.553503, 10.255505 };
            var test = new double[answer.Length];
            // Act
            for (int i = 0; i < answer.Length; i++)
            {
                test[i] = _main.Task6(input[i]);
            }
            // Assert
            for (int i = 0; i < answer.Length; i++)
            {
                Assert.AreEqual(answer[i], test[i], E);
            }
        }
        [TestMethod]
        public void Test7()
        {
            // Arrange
            var input = new int[] { 0, 1, 2, 10, 100, 1234, 12345, 25000, 100000000 };
            var answer = new int[] { 0, 1, 2, 4, 14, 50, 157, 224 };
            var test = new int[answer.Length];
            // Act
            for (int i = 0; i < answer.Length; i++)
            {
                test[i] = _main.Task7(input[i]);
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
                { 1000, 1000, 1000, 3400, 5000, 7000, 7000, 6666, 100,  100 },
                {    1,    2,    5,  5.2,  5.5,  5.5, 10.2,  6.6,  1,   0.1 }
            };
            var answer = new int[] { 79, 40, 16, 164, 315, 563, 304, 432, 1, 8 };
            var test = new double[answer.Length];
            // Act
            for (int i = 0; i < answer.Length; i++)
            {
                test[i] = _main.Task8(input[0, i], input[1, i]);
            }
            // Assert
            for (int i = 0; i < answer.Length; i++)
            {
                Assert.AreEqual(answer[i], test[i], E);
            }
        }
    }
}


