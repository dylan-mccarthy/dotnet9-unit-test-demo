using Xunit;
using TestLib;

namespace TestLib.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var demo = new Demo();
            Assert.Equal("Hello, World!", demo.SayHello("World"));
        }

        [Fact]
        public void Test2()
        {
            var demo = new Demo();
            Assert.Equal("Goodbye, World!", demo.SayGoodbye("World"));
        }

        [Fact]
        public void ShortRunningMethodTest()
        {
            // Given
            var demo = new Demo();
        
            // When
            demo.ShortRunningMethod();
        
            // Then
            Assert.True(true);
        }

        [Fact]
        public void MediumRunningMethodTest()
        {
            // Given
            var demo = new Demo();
        
            // When
            demo.MediumRunningMethod();
        
            // Then
            Assert.True(true);
        }

        [Fact]
        public void LongRunningMethodTest()
        {
            // Given
            var demo = new Demo();
        
            // When
            demo.LongRunningMethod();
        
            // Then
            Assert.True(true);
        }

    }
}
