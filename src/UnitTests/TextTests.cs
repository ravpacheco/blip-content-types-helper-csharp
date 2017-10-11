using Lime.Messaging.Contents;
using Shouldly;
using System;
using Take.Blip.ContentTypesHelper.Facebook;
using Xunit;

namespace Take.Blip.ContentTypesHelper.Tests
{
    public class TextTests
    {
        [Fact]
        public void CreateValidText()
        {
            //Arrange
            var expectedText = new PlainText
            {
                Text = "Hi"
            };

            //Act
            var text = BlipHelper.CreateText("Hi");

            //Assert
            text.ToString().ShouldBe(expectedText.ToString());
        }
    }
}
