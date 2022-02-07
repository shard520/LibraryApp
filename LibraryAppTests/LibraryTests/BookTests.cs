using FluentAssertions;
using LibraryApp.Library;
using NUnit.Framework;

namespace LibraryAppTests
{
    public class BookTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void When_NewBookIsCreated_Then_TitleIsSet()
        {
            var expectedTitle = "The Beano";
            var sut = new Book(expectedTitle);

            sut.Title.Should().Be(expectedTitle);
        }
    }

}