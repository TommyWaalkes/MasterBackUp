using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzTDD
{
    [TestFixture]
    class NumstoWordConverterTest
    {
        public NumstoWordConverter nwc;
        [SetUp]
        public void Init()
        {
            nwc = new NumstoWordConverter();
        }

        [Test]
        public void ConvertOneToNine()
        {
            string result = nwc.Convert(1);
            Assert.AreEqual("one", result);

            result = nwc.Convert(2);
            Assert.AreEqual("two", result);

            result = nwc.Convert(7);
            Assert.AreEqual("seven", result);
        }

        [Test]
        public void ConvertTwentyAndSixty() {
            string result = nwc.Convert(20);
            Assert.AreEqual("twenty", result);

            result = nwc.Convert(60);
            Assert.AreEqual("sixty", result);
        }
    }
}
