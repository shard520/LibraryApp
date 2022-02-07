using FluentAssertions;
using LibraryApp.Extensions;
using LibraryApp.People;
using Moq;
using NUnit.Framework;
using System;
using System.IO;

namespace LibraryAppTests
{
    public class StudentTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void When_NewStudentCreated_Then_AgeIsCalculatedFromDateOfBirthString()
        {
            // Arrange
            var mockDate = new Mock<DateWrapper>();
            mockDate.SetupGet(d => d.Today)
                .Returns(new DateTime(2020, 4, 30));

            var dateOfBirthString = "13/04/2002";

            // Act
            var sut = new Student("Stephen Doyle", dateOfBirthString, 1001);
            sut.Date = mockDate.Object;
            

            // Assert
            sut.Age.Should().Be(18);
        }
        
        [Test]
        public void WhenNewStudentCreated_Then_PropertiesAreSet()
        {
            // Arrange
            var expectedName = "Kim Whittle";
            var expectedDateOfBirth = "23/11/2001";
            var expectedCourseId = 1001;

            // Act
            var sut = new Student(expectedName, expectedDateOfBirth, expectedCourseId);

            // Assert
            sut.Name.Should().Be(expectedName);
            sut.DateOfBirth.Should().Be(expectedDateOfBirth);
            sut.CourseId.Should().Be(expectedCourseId);
        }

        [Test]
        public void WhenNewStudentCreated_Then_isAdminIsFalse()
        {
            var student = new Student("Heather Brown", "30/09/2002", 1001);
            student.isAdmin.Should().Be(false);
        }

        [Test]
        public void WhenStudentGreetingIsCalled_Then_GreetingShouldIncludeName()
        {
            // Arrange
            var expectedName = "Heather Brown";
            var student = new Student(expectedName, "30/09/2002", 1001);
            var expectedMessage = $"Hi {expectedName}";
            var stringWriter = new StringWriter();
            Console.SetOut(stringWriter);

            // Act
            student.Greeting();
            var result = stringWriter.ToString().Trim();

            // Assert
            result.Should().Be(expectedMessage);
        }
    }
}