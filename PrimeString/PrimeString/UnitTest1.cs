﻿using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

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
        public void String_aa_IsNotPrime()
        {
            var primeString = new PrimeString();
            var result = primeString.IsPrime("aa");
            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void String_ab_IsPrime()
        {
            var primeString = new PrimeString();
            var result = primeString.IsPrime("ab");
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void String_aaa_IsNotPrime()
        {
            var primeString = new PrimeString();
            var result = primeString.IsPrime("aaa");
            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void String_aab_IsPrime()
        {
            var primeString = new PrimeString();
            var result = primeString.IsPrime("aab");
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void String_abc_IsPrime()
        {
            var primeString = new PrimeString();
            var result = primeString.IsPrime("abc");
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void String_abab_IsNotPrime()
        {
            var primeString = new PrimeString();
            var result = primeString.IsPrime("abab");
            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void String_abcab_IsPrime()
        {
            var primeString = new PrimeString();
            var result = primeString.IsPrime("abcab");
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void String_abcabc_IsNotPrime()
        {
            var primeString = new PrimeString();
            var result = primeString.IsPrime("abcabc");
            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void String_abcabcabc_IsNotPrime()
        {
            var primeString = new PrimeString();
            var result = primeString.IsPrime("abcabcabc");
            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void String_fdsyffdsyffdsyffdsyffdsyf_IsNotPrime()
        {
            var primeString = new PrimeString();
            var result = primeString.IsPrime("fdsyffdsyffdsyffdsyffdsyf");
            Assert.AreEqual(false, result);
        }
    }

    
    public class PrimeString
    {
        public bool IsPrime(string inputString)
        {
            if (inputString.Length > 1)
            {
                return !inputString.Select((x, index) =>
                    new
                    {
                        subString = inputString.Substring(0, index + 1),
                        copyTime = inputString.Length / (index + 1)
                    })
                    .Where(x => x.copyTime > 1).ToList()
                    .Exists(x => string.Equals(inputString, string.Concat(Enumerable.Repeat(x.subString, x.copyTime)), StringComparison.OrdinalIgnoreCase));
            }
            return true;
        }
    }
}
