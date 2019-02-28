using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TDDCodeAlong
{
    [TestFixture]
    public class TestSnowMan
    {
        [Test]
        public void SnowManMeltsAt33()
        {
            SnowMan s = new SnowMan();
            bool expected = true;
            bool actual = s.IsMelting(33);

            Assert.AreEqual(expected, actual, "The snow did not melt at 33f");
        }

        [Test]
        public void SnowManDoesNotMeltAt32()
        {
            SnowMan s = new SnowMan();

            bool expected = false;
            bool actual = s.IsMelting(32);

            Assert.AreEqual(expected, actual, "The snow man should not melt at 32f");
        }
    }
}
