﻿using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    [TestFixture]
    public class NunitTests : IntegrationTestsBase<AssertionException>
    {
        [Test]
        public void StringContains_should_have_message()
        {
            CheckIfMessageIsValid("StringAssert.Contains(\"test\", actual);");
        }

        [Test]
        public void AreEqual_should_have_message_for_object()
        {
            CheckIfMessageIsValid("Assert.AreEqual(expected, actual);");
        }

        [Test]
        public void AreEqual_should_have_message_for_int()
        {
            CheckIfMessageIsValid("Assert.AreEqual(expected, actual);");
        }

        [Test]
        public void AreNotEqual_should_have_message()
        {
            CheckIfMessageIsValid("Assert.AreNotEqual(expected, actual);");
        }

        [Test]
        public void AreEqual_should_have_message_orginal_message()
        {
            CheckIfMessageIsValid(message =>
            {
                StringAssert.Contains("orginal_message", message);
                StringAssert.DoesNotContain("Assert.AreEqual(", message);
            });            
        }

        [Test]
        public void AreEqual_should_have_message_orginal_formated_message()
        {
            CheckIfMessageIsValid(message =>
            {
                StringAssert.Contains("orginal_message", message);
                StringAssert.DoesNotContain("Assert.AreEqual(", message);
            });
        }

        [Test]
        public void Contains_should_have_message()
        {
            CheckIfMessageIsValid("Assert.Contains(expected, collection);");
        }

        [Test]
        public void IsTrue_should_have_message()
        {
            CheckIfMessageIsValid("Assert.IsTrue(actual);");
        }

        [Test]
        public void False_should_have_message()
        {
            CheckIfMessageIsValid("Assert.False(actual);");
        }

        [Test]
        public void IsEmpty_should_have_message_for_collection()
        {
            CheckIfMessageIsValid("Assert.IsEmpty(actual);");
        }

        [Test]
        public void IsInstanceOf_should_have_message()
        {
            CheckIfMessageIsValid("Assert.IsInstanceOf<int>(actual);");
        }

        [Test]
        public void Throws_should_have_message()
        {
            CheckIfMessageIsValid("Assert.Throws<Exception>(action);");
        }

        [Test]
        public void Fail_should_have_message()
        {
            CheckIfMessageIsValid("Assert.Fail();");
        }
    }
}
