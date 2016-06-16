using System;
using NUnit.Framework;
using PasswordSystem;

namespace PasswordSystemTests
{
    [TestFixture]
    public class PasswordVerifierTests
    {
        private PasswordVerifier _passwordVerifier;

        [SetUp]
        public void SetUp()
        {
            _passwordVerifier = new PasswordVerifier();
        }

        [Test]
        public void Password_Cannot_Be_Null()
        {
            var passwordVerifier = new PasswordVerifier();

            Assert.Throws<ArgumentNullException>(() => passwordVerifier.Verify(null));
        }

        [Test]
        public void NotNullPassword_DoesNotThrow()
        {
            var password = "abc";
            Assert.DoesNotThrow(()=>_passwordVerifier.Verify(password));
        }

        [Test]
        public void Password_Is_Atleast_Eight_Characters()
        {
            var password = "1234567";
            Assert.Throws<ArgumentException>(() => _passwordVerifier.Verify(password));

        }
    }
}