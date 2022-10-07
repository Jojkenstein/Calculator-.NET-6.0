using Calculator_.NET_6._0;

namespace Calculator_.NET_6._0.Test
{
    public class UnitTest1
    {
        Calc calc = new Calc();

        // ADDITION
        [Fact]
        public void AddTest()
        {
            double a = 1;
            double b = 2;
            double c = 3;
            Assert.Equal(c, calc.Add(a, b));
        }

        [Fact]
        public void SumVectorTest()
        {
            double[] a = { 1, 2, 3, 4 };
            Assert.Equal(10, calc.Add(a));
        }
        [Fact]

        // SUBTRACTION
        public void SubTestInt()
        {
            Assert.Equal(1, calc.Sub(3, 2));
        }
        [Fact]
        public void SubTest3Ints()
        {
            Assert.Equal(0, calc.Sub(3, 2, 1));
        }
        [Fact]
        public void SubTestDouble()
        {
            Assert.Equal(1, calc.Sub(3, 2));
        }

        // MULTIPLICATION
        [Fact]
        public void MulTestdouble()
        {
            double a = 2;
            double b = 3;
            double c = 6;
            Assert.Equal(c, calc.Mul(a, b));
        }
        [Fact]
        public void MulTest3double()
        {
            double a = 3;
            double b = 4;
            double c = 5;
            double d = 60;
            Assert.Equal(d, calc.Mul(a, b, c));
        }

        // DIVISION
        [Fact]
        public void DivTestdoubleERROR()
        {
            double a = 1;
            double b = 0;
            double c = 1;
            Assert.Equal(c, calc.Div(a, b));
        }
        [Fact]
        public void DivTestdouble()
        {
            double a = 10;
            double b = 2.5;
            double c = 4;
            Assert.Equal(c, calc.Div(a, b));
        }
    }
}