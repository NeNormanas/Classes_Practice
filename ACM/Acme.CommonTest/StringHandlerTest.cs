﻿using System;
using Acme.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Acme.CommonTest
{
    [TestClass]
    public class StringHandlerTest
    {
        [TestMethod]
        public void InsertSpacesTestValid()
        {
            // arrange 
            var source = "SonicScrewdriver";
            var expected = "Sonic Screwdriver";
            var handler = new StringHandler();

            // Act 

            var actual = handler.InsertSpaces(source);

            // Assert 
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void InsertSpacesTestWithExistingSpace()
        {
            // arrange 
            var source = "Sonic Screwdriver";
            var expected = "Sonic Screwdriver";
            var handler = new StringHandler();

            // Act 

            var actual = handler.InsertSpaces(source);

            // Assert 
            Assert.AreEqual(expected, actual);
        }
    }
}
