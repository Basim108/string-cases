using System.Linq;
using Xunit;

namespace Hrimsoft.StringCases.Tests
{
    public class StringSplitOnToPartsTests
    {
        [Fact]
        public void Should_split_2syllables_camel_case()
        {
            var parts = "ReUse".SplitOnToParts();
            Assert.NotNull(parts);
            Assert.NotEmpty(parts);
            Assert.Equal(2, parts.Count);
            Assert.Equal("re", parts.ToList()[0]);
            Assert.Equal("use", parts.ToList()[1]);
        }
        
        [Fact]
        public void Should_split_1syllables_camel_case()
        {
            var parts = "Re".SplitOnToParts();
            Assert.NotNull(parts);
            Assert.Single(parts);
            Assert.Equal("re", parts.ToList()[0]);
        }
        
        [Fact]
        public void Should_split_2syllables_snake_case()
        {
            var parts = "re_use".SplitOnToParts();
            Assert.NotNull(parts);
            Assert.NotEmpty(parts);
            Assert.Equal(2, parts.Count);
            Assert.Equal("re", parts.ToList()[0]);
            Assert.Equal("use", parts.ToList()[1]);
        }
        
        [Fact]
        public void Should_split_1syllables_snake_case()
        {
            var parts = "re".SplitOnToParts();
            Assert.NotNull(parts);
            Assert.Single(parts);
            Assert.Equal("re", parts.ToList()[0]);
        }
    }
}
