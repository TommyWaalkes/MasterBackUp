using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzTDD
{
    [TestFixture]
    class FizzBuzzTest
    {
        [Test]
        public void TwoIsPrime()
        {
            FizzBuzz fb = new FizzBuzz();

            string result = fb.IsEven(2);

            Assert.AreEqual("prime", result);
        }

        [Test]
        public void FiveIsPrime()
        {
            FizzBuzz fb = new FizzBuzz();

            string result = fb.IsEven(5);

            Assert.AreEqual("prime", result);
        }

        [Test]
        public void ElevenIsPrime()
        {
            FizzBuzz fb = new FizzBuzz();

            string result = fb.IsEven(11);

            Assert.AreEqual("prime", result);
        }

        [Test]
        public void FifteenIsOdd()
        {
            FizzBuzz fb = new FizzBuzz();

            string result = fb.IsEven(15);

            Assert.AreEqual("odd", result);
        }


    }
}
