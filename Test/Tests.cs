using RiderUnitTest;
using Xunit;

namespace Test
{
    public class Tests
    {
        [Fact]
        public void Test1()
        {
            var foo = new Foo();
            Assert.Equal("A", foo.Bar());
        }
    }
}