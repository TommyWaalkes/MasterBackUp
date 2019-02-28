using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TDDCodeAlong
{
    [TestFixture]
    class TestPrime
    {
        [Test]
        public void ThreeIsPrime()
        {
            PrimeNumCalc p = new PrimeNumCalc();
            bool expected = true;
            bool actual = p.IsPrime(3);

            Assert.AreEqual(expected, actual, "3 should be prime");
        }

        [Test]
        public void FourIsNotPrime()
        {
            PrimeNumCalc p = new PrimeNumCalc();
            bool expected = false;
            bool actual = p.IsPrime(4);
            Assert.AreEqual(expected, actual, "4 Should not be prime");
        }

        [Test]
        public void NineIsNotPrime()
        {
            PrimeNumCalc p = new PrimeNumCalc();
            bool expected = false;
            bool actual = p.IsPrime(9);

            Assert.AreEqual(expected, actual, "9 should not be prime");
        }

        [Test]
        public void ElevenIsPrime()
        {
            PrimeNumCalc p = new PrimeNumCalc();
            bool expected = true;
            bool actual = p.IsPrime(11);

            Assert.AreEqual(expected, actual, "11 should be prime");
        }

        [Test]
        public void FiftyThreeIsPrime()
        {
            PrimeNumCalc p = new PrimeNumCalc();
            bool expected = true;
            bool actual = p.IsPrime(53);

            Assert.AreEqual(expected, actual, "53 should be prime");
        }


        [Test]
        public void FiftyFiveIsNotPrime()
        {
            PrimeNumCalc p = new PrimeNumCalc();
            bool expected = false;
            bool actual = p.IsPrime(55);

            Assert.AreEqual(expected, actual, "55 should not be prime");
        }

        [Test]
        public void TestAll()
        {
            PrimeNumCalc p = new PrimeNumCalc();
            int[] primes = { 4, 3, 5, 7, 11 };
            for (int i = 0; i<primes.Length; i++)
            {
                bool expected = true;
                int num = primes[i];
                bool actual = p.IsPrime(num);
                Assert.AreEqual(expected, actual);
                
            }


        }
    }
}
