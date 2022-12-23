using AutoFixture;
using FluentAssertions;
using Xunit;

namespace DemoCode.Tests
{
    public class StringDemos
    {
        [Fact]
        public void BasicStrings()
        {
            // arrange
            var fixture = new Fixture();
            var sut = new NameJoiner();

            var firstName = fixture.Create("First_");
            var lastName = fixture.Create("Last_");

            // act
            var result = sut.Join(firstName, lastName);

            // assert
            result.Should().BeEquivalentTo(firstName + " " + lastName);        }
    }
}
