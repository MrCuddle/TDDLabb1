using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TDDLabb1
{
    [TestFixture]
    class TestClass
    {
        [Test]
        public void TestEnrovNull()
        {
            string test = null;
            test = rorovovaror.rovar.enrov(test);
            Assert.AreEqual(test, null);
        }
        [Test]
        public void TestDerovNull()
        {
            string test = null;
            test = rorovovaror.rovar.derov(test);
            Assert.AreEqual(test, null);
        }
        [Test]
        public void TestAllLowerCaseConsonantsEnrov()
        {
            string lowerConsonants = "bcdfghjklmnpqrstvwxz";
            foreach(char c in lowerConsonants)
            {
                string current = rorovovaror.rovar.enrov(c.ToString());
                Assert.AreEqual(current, c + "o" + c);
            }
        }

        [Test]
        public void TestAllUpperCaseConsonantsEnrov()
        {
            string upperConsonants = "BCDFGHJKLMNPQRSTVWXZ";
            foreach (char c in upperConsonants)
            {
                string current = rorovovaror.rovar.enrov(c.ToString());
                Assert.AreEqual(current, c + "O" + c);
            }
        }

        [Test]
        public void TestAllLowerCaseConsonantsDerov()
        {
            string lowerConsonants = "bcdfghjklmnpqrstvwxz";
            foreach (char c in lowerConsonants)
            {
                string current = rorovovaror.rovar.derov(c.ToString() + "o" + c.ToString());
                Assert.AreEqual(current, c.ToString());
            }
        }

        [Test]
        public void TestAllUpperCaseConsonantsDerov()
        {
            string lowerConsonants = "BCDFGHJKLMNPQRSTVWXZ";
            foreach (char c in lowerConsonants)
            {
                string current = rorovovaror.rovar.derov(c.ToString() + "O" + c.ToString());
                Assert.AreEqual(current, c.ToString());
            }
        }

        [Test]
        public void TestDerovDuplicateConsonant()
        {
            string toTest = rorovovaror.rovar.derov("rorror");
            Assert.AreEqual(toTest, "rr");
        }

        [Test]
        public void TestNumbersEnrov()
        {
            string expected = "0123456789";
            string toTest = rorovovaror.rovar.enrov("0123456789");
            Assert.AreEqual(toTest, expected);
        }

        [Test]
        public void TestNumbersDerov()
        {
            string expected = "0123456789";
            string toTest = rorovovaror.rovar.derov("0123456789");
            Assert.AreEqual(toTest, expected);
        }

        [Test]
        public void TestEmptyStringEnrov()
        {
            string expected = "";
            string toTest = rorovovaror.rovar.enrov("");
            Assert.AreEqual(expected, toTest);
        }

        [Test]
        public void TestEmptyStringDerov()
        {
            string expected = "";
            string toTest = rorovovaror.rovar.derov("");
            Assert.AreEqual(expected, toTest);
        }

        [Test]
        public void TestEscapeCharEnrov()
        {
            string expected = '\n'.ToString();
            string toTest = rorovovaror.rovar.enrov('\n'.ToString());
            Assert.AreEqual(expected, toTest);
        }

        [Test]
        public void TestEscapeCharDerov()
        {
            string expected = '\n'.ToString();
            string toTest = rorovovaror.rovar.derov('\n'.ToString());
            Assert.AreEqual(expected, toTest);
        }

        [Test]
        public void TextMixedValuesEnrov()
        {
            string toTest = rorovovaror.rovar.enrov("SimonDahlberg89@gmail.com");
            Assert.AreEqual(toTest, "SOSimomononDODahohlolboberorgog89@gogmomailol.cocomom");
        }

        [Test]
        public void TextMixedValuesDerov()
        {
            string toTest = rorovovaror.rovar.derov("SOSimomononDODahohlolboberorgog89@gogmomailol.cocomom");
            Assert.AreEqual(toTest, "SimonDahlberg89@gmail.com");
        }
    }
}
