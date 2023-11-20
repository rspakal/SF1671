using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;


namespace SF1671
{
    [TestFixture]
    public class CalculatorTests
    {
        public Calculator c = new Calculator();

        [Test]
        public void Additional_MustReturnCorrectValue()
        {
        Assert.That(c.Additional(3, 4) == 7);
        }

        [Test]
        public void Subtruction_MustReturnCorrectValue()
        {
            Assert.That(c.Subtraction(3, 4) == -1);
        }

        [Test]
        public void Miltiplication_MustReturnCorrectValue()
        {
            Assert.That(c.Miltiplication(3, 4) == 12);
        }

        [Test]
        public void Division_MustReturnCorrectValue()
        {
            Assert.That(c.Division(12, 4) == 3);
        }
    }
}
