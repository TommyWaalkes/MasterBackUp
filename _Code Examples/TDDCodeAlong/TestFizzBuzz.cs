using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TDDCodeAlong
{
    [TestFixture]
    class TestFizzBuzz
    {
        [Test]
        public void FizzBuzzOnlyAcceptsInputLessThan101()
        {
            FizzBuzz fb = new FizzBuzz();
            string expected = "NotInRange";
            string actual = fb.EvaluateNum(101);

            Assert.AreEqual(expected, actual, "Fizz Buzz must not accept nums over 100");
        }

        [Test]
        public void FizzBuzzOnlyAcceptsInputGreaterThan0()
        {
            FizzBuzz fb = new FizzBuzz();
            string expected = "NotInRange";
            string actual = fb.EvaluateNum(0);

            Assert.AreEqual(expected, actual, "Fizz Buzz must not accept nums under 1");
        }

        [Test]
        public void FizzBuzzReturnsFizzForMultiplesOf3()
        {
            FizzBuzz fb = new FizzBuzz();
            string actual = fb.EvaluateNum(3);
            string expected = "Fizz";
            Assert.AreEqual(expected,actual, "EvalNum Should with param 3 should return Fizz");
        }

        [Test]
        public void FizzBuzzReturnsBuzzForMutiplesof5()
        {
            FizzBuzz fb = new FizzBuzz();
            string expected = "Buzz";
            string actual = fb.EvaluateNum(5);

            Assert.AreEqual(expected, actual, "Eval Num should return Buzz for param 5");
        }
    }
}
