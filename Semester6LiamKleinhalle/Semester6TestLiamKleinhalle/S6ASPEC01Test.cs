using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Microsoft.AspNetCore.Mvc;
using Semester6LiamKleinhalle.Controllers;
using Semester6LiamKleinhalle.Helpers;

namespace Semester6TestLiamKleinhalle
{
    public class S6ASPEC01Test
    {
        [Theory]
        [InlineData("HelloWorld", 3, "KhoorZruog")]
        [InlineData("123", 2, "345")]
        [InlineData("Test123", 5, "Yjxy678")]
        public void Encrypt_ShouldEncryptCorrectly(string input, int key, string expected)
        {
            string result = EncryptionFunctions.Encrypt(input, key);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData("KhoorZruog", 3, "HelloWorld")]
        [InlineData("345", 2, "123")]
        [InlineData("Yjxy678", 5, "Test123")]
        public void Decrypt_ShouldDecryptCorrectly(string input, int key, string expected)
        {
            string result = EncryptionFunctions.Decrypt(input, key);
            Assert.Equal(expected, result);
        }

        [Fact]
        public void S6ASPEC01_ReturnsView()
        {
            var controller = new S6ASPSEC01Controller();
            var result = controller.S6ASPEC01() as ViewResult;
            Assert.NotNull(result);
        }

        [Fact]
        public void Encrypt_ReturnsViewWithEncryptedText()
        {
            var controller = new S6ASPSEC01Controller();
            var input = "Hello";
            var key = 3;
            var expected = EncryptionFunctions.Encrypt(input, key);

            var result = controller.Encrypt(input, key) as ViewResult;

            Assert.NotNull(result);
            Assert.NotNull(controller.ViewBag.EncryptedText);
            Assert.Equal(expected, controller.ViewBag.EncryptedText);
        }

        [Fact]
        public void Decrypt_ReturnsViewWithDecryptedText()
        {
            var controller = new S6ASPSEC01Controller();
            var input = EncryptionFunctions.Encrypt("Hello", 3);
            var key = 3;
            var expected = "Hello";

            var result = controller.Decrypt(input, key) as ViewResult;

            Assert.NotNull(result);
            Assert.NotNull(controller.ViewBag.DecryptedText);
            Assert.Equal(expected, controller.ViewBag.DecryptedText);
        }
    }
}
