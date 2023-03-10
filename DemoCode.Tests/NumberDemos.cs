using AutoFixture;
using FluentAssertions;

namespace DemoCode.Tests
{
    public class NumberDemos
    {
        [Fact]
        public void Ints()
        {
            // arrange
            var sut = new IntCalculator();
            var fixture = new Fixture();

            // act
            sut.Subtract(fixture.Create<int>());

            // assert
            sut.Value.Should().BeLessThan(0);
        }
    }
}
