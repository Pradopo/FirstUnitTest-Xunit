using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xunit;
using FirstUnitTest;

namespace FirstUnitTest.Test
{
    public class Calculation_test
    {
        [Fact]
        public void TestAdd()
        {
            var cal = new FirstUnitTest.Calculation();
            Assert.Equal(4, cal.Add(2, 2));

        }

        [Fact]
        public void TestMultiple()
        {
            var cal = new FirstUnitTest.Calculation();
            Assert.Equal(6, cal.Multiple(2, 3));

        }

        [Fact]
        public void TestDevideByZero()
        {
            var cal = new FirstUnitTest.Calculation();
            Assert.Throws<DivideByZeroException>(() => cal.Divide(2, 0));

        }

        [Fact]
        public void TestDevide()
        {
            var cal = new FirstUnitTest.Calculation();
            Assert.Equal(10,cal.Divide(20, 2));

        }
    }
}
