using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace PrimeString
{
    [TestClass]
    public class UnitTest1
    {

        //Task
        //The string is called prime if it cannot be constructed by concatenating some (more than one) equal strings together.
        //For example, "abac" is prime, but "xyxy" is not("xyxy"="xy"+"xy").
        //Given a string determine if it is prime or not.
        //Input/Output
        //[input] string s
        //string containing only lowercase English letters
        //[output] a boolean value
        //true if the string is prime, false otherwise

        [TestMethod]
        public void String_Empty_IsPrime()
        {
            var primeString = new PrimeString();
            var result = primeString.IsPrime(string.Empty);
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void String_a_IsPrime()
        {
            var primeString = new PrimeString();
            var result = primeString.IsPrime("a");
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void String_aa_IsPrime()
        {
            var primeString = new PrimeString();
            var result = primeString.IsPrime("aa");
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void String_ab_IsPrime()
        {
            var primeString = new PrimeString();
            var result = primeString.IsPrime("ab");
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void String_aaa_IsPrime()
        {
            var primeString = new PrimeString();
            var result = primeString.IsPrime("aaa");
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void String_aab_IsPrime()
        {
            var primeString = new PrimeString();
            var result = primeString.IsPrime("aab");
            Assert.AreEqual(true, result);
        }
    }

    
    public class PrimeString
    {
        public bool IsPrime(string inputString)
        {
            if (inputString.Length > 1)
            {
                for (int i = 0; i < inputString.Length; i++)
                {
                    var expectString = inputString.Substring(0, i + 1);
                    for (int j = 1; j < Math.Ceiling((double)(inputString.Length/(i + 1))); j++)
                    {
                        expectString += string.Concat(inputString[0]);  
                    }
                    if (string.Equals(inputString, expectString, StringComparison.OrdinalIgnoreCase))
                    {
                        return true;
                    }
                }
                return false;
            }
            return true;
        }
    }
}
