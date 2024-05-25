using FiapTechChallenge.ContactBook.Domain.Core.Entities;

namespace FiapTechChallenge.ContactBook.Tests.Domain.Core.Entities
{
    public class ContactTests
    {
        [Theory]
        [InlineData("11987654321", true)]
        [InlineData("1187654321", true)]
        [InlineData("abc", false)]
        [InlineData("123456789012", false)]
        [InlineData("", false)]
        [InlineData(null, false)]
        public void IsValidPhoneNumber_ValidatesPhoneNumber(string phone, bool expectedResult)
        {
            // Arrange
            var contact = new Contact { Phone = phone };

            // Act
            var result = contact.IsValidPhoneNumber();

            // Assert
            Assert.Equal(expectedResult, result);
        }

        [Theory]
        [InlineData("11987654321", "11")]
        [InlineData("2187654321", "21")]
        public void ExtractDDD_ExtractsDDD(string phone, string expectedDDD)
        {
            // Arrange
            var contact = new Contact { Phone = phone };

            // Act
            var result = contact.ExtractDDD();

            // Assert
            Assert.Equal(expectedDDD, result);
        }
    }
}
