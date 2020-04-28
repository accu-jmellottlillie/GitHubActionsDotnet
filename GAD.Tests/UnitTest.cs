using GAD.Lib;
using Xunit;

namespace GAD.Tests
{
    public class UnitTest
    {
        [Fact]
        public void MeaningOfLife()
        {
            Assert.Equal(42, new Foo().MeaningOfLife);
        }

        [Fact]
        public void HatersGonnaHate()
        {
            Assert.Equal(0, new Foo().MeaningOfLife);
        }
    }
}
