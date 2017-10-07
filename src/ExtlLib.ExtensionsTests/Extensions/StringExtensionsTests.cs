﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using ExtlLib.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtlLib.Extensions.Tests
{
    [TestClass()]
    public class StringExtensionsTests
    {
        [TestMethod()]
        public void SplitTest()
        {
            string[] s = "1,2;3,4;5".Split(new string[] { ",", ";" });
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] != (i + 1).ToString())
                    Assert.Fail();
            }
        }

        [TestMethod()]
        public void SplitTest1()
        {
            string[] s = "1,2,3,4,5".Split(new string[] { ",", ";" });
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] != (i + 1).ToString())
                    Assert.Fail();
            }
        }

        [TestMethod()]
        public void SubstringTest()
        {
            int rs = 0;
            string s = "1,2,3,4,5".Substring(ref rs, 2);
            if (s != "1," || rs != 2)
                Assert.Fail();
        }
    }
}