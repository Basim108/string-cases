using Xunit;

namespace Hrimsoft.StringCases.Tests
{
    public class ToKebabCaseTests
    {
        [Fact]
        public void given_empty_string_returns_it()
        {
            Assert.Equal("", "".ToKebabCase());
        }

        [Fact]
        public void given_white_space_returns_empty_string()
        {
            Assert.Equal("", "  ".ToKebabCase());
        }

        [Fact]
        public void given_null_returns_empty_string()
        {
            string test = null;
            Assert.Equal("", test.ToKebabCase());
        }

        [Fact]
        public void given_one_word_returns_correct()
        {
            Assert.Equal("one", "one".ToKebabCase());
            Assert.Equal("one", "One".ToKebabCase());
        }

        [Fact]
        public void given_two_spaced_words_returns_correct()
        {
            Assert.Equal("first-second", "First second".ToKebabCase());
        }

        [Fact]
        public void given_two_word_camel_returns_correct()
        {
            Assert.Equal("first-second", "firstSecond".ToKebabCase());
        }

        [Fact]
        public void given_two_word_snake_returns_correct()
        {
            Assert.Equal("first-second", "first_second".ToKebabCase());
        }

        [Fact]
        public void given_two_word_pascal_returns_correct()
        {
            Assert.Equal("first-second", "FirstSecond".ToKebabCase());
        }
        
        [Fact]
        public void given_two_word_train_returns_correct()
        {
            Assert.Equal("first-second", "First-Second".ToKebabCase());
        }
        
        [Fact]
        public void given_two_word_kebab_returns_correct()
        {
            Assert.Equal("first-second", "first-second".ToKebabCase());
        }
        
        [Fact]
        public void given_two_word_underscored_camel_returns_correct()
        {
            Assert.Equal("first-second", "_firstSecond".ToKebabCase());
        }
        
        [Fact]
        public void given_two_capital_letters_into_2_words()
        {
            Assert.Equal("a-a", "AA".ToKebabCase());
        }
        
        [Fact]
        public void given_3_spaced_words_returns_correct()
        {
            Assert.Equal("first-second-third", "First second third".ToKebabCase());
        }

        [Fact]
        public void given_3_word_camel_returns_correct()
        {
            Assert.Equal("first-second-third", "firstSecondThird".ToKebabCase());
        }

        [Fact]
        public void given_3_word_snake_returns_correct()
        {
            Assert.Equal("first-second-third", "first_second_third".ToKebabCase());
        }

        [Fact]
        public void given_3_word_pascal_returns_correct()
        {
            Assert.Equal("first-second-third", "FirstSecondThird".ToKebabCase());
        }
        
        [Fact]
        public void given_3_word_train_returns_correct()
        {
            Assert.Equal("first-second-third", "First-Second-Third".ToKebabCase());
        }
        
        [Fact]
        public void given_3_word_kebab_returns_correct()
        {
            Assert.Equal("first-second-third", "first-second-third".ToKebabCase());
        }
        
        [Fact]
        public void given_3_word_underscored_camel_returns_correct()
        {
            Assert.Equal("first-second-third", "_firstSecondThird".ToKebabCase());
        }
        
        [Fact]
        public void given_many_delimiters_between_words_returns_correct()
        {
            Assert.Equal("first-second-third", "First   Second--   Third".ToKebabCase());
        }
    }
}