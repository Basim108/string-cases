using Xunit;

namespace Hrimsoft.StringCases.Tests
{
    public class ToUnderscoredCamelCaseTests
    {
        [Fact]
        public void given_empty_string_returns_it()
        {
            Assert.Equal("", "".ToUnderscoredCamelCase());
        }

        [Fact]
        public void given_white_space_returns_empty_string()
        {
            Assert.Equal("", "  ".ToUnderscoredCamelCase());
        }

        [Fact]
        public void given_null_returns_empty_string()
        {
            string test = null;
            Assert.Equal("", test.ToUnderscoredCamelCase());
        }

        [Fact]
        public void given_one_word_returns_correct()
        {
            Assert.Equal("_one", "one".ToUnderscoredCamelCase());
            Assert.Equal("_one", "One".ToUnderscoredCamelCase());
        }

        [Fact]
        public void given_two_spaced_words_returns_correct()
        {
            Assert.Equal("_firstSecond", "First second".ToUnderscoredCamelCase());
        }
        
        [Fact]
        public void given_two_word_camel_returns_correct()
        {
            Assert.Equal("_firstSecond", "firstSecond".ToUnderscoredCamelCase());
        }

        [Fact]
        public void given_two_word_snake_returns_correct()
        {
            Assert.Equal("_firstSecond", "first_second".ToUnderscoredCamelCase());
        }
        
        [Fact]
        public void given_two_word_pascal_returns_correct()
        {
            Assert.Equal("_firstSecond", "FirstSecond".ToUnderscoredCamelCase());
        }
        
        [Fact]
        public void given_two_word_kebab_returns_correct()
        {
            Assert.Equal("_firstSecond", "first-second".ToUnderscoredCamelCase());
        }
        
        [Fact]
        public void given_two_word_train_returns_correct()
        {
            Assert.Equal("_firstSecond", "First-Second".ToUnderscoredCamelCase());
        }
        
        [Fact]
        public void given_two_word_underscored_camel_returns_correct()
        {
            Assert.Equal("_firstSecond", "_firstSecond".ToUnderscoredCamelCase());
        }
        
        [Fact]
        public void given_two_capital_letters_into_2_words()
        {
            Assert.Equal("_aA", "AA".ToUnderscoredCamelCase());
        }
        
        [Fact]
        public void given_3_spaced_words_returns_correct()
        {
            Assert.Equal("_firstSecondThird", "First second third".ToUnderscoredCamelCase());
        }

        [Fact]
        public void given_3_word_camel_returns_correct()
        {
            Assert.Equal("_firstSecondThird", "firstSecondThird".ToUnderscoredCamelCase());
        }

        [Fact]
        public void given_3_word_snake_returns_correct()
        {
            Assert.Equal("_firstSecondThird", "first_second_third".ToUnderscoredCamelCase());
        }

        [Fact]
        public void given_3_word_pascal_returns_correct()
        {
            Assert.Equal("_firstSecondThird", "FirstSecondThird".ToUnderscoredCamelCase());
        }
        
        [Fact]
        public void given_3_word_train_returns_correct()
        {
            Assert.Equal("_firstSecondThird", "First-Second-Third".ToUnderscoredCamelCase());
        }
        
        [Fact]
        public void given_3_word_kebab_returns_correct()
        {
            Assert.Equal("_firstSecondThird", "first-second-third".ToUnderscoredCamelCase());
        }
        
        [Fact]
        public void given_3_word_underscored_camel_returns_correct()
        {
            Assert.Equal("_firstSecondThird", "_firstSecondThird".ToUnderscoredCamelCase());
        }
        
        [Fact]
        public void given_many_delimiters_between_words_returns_correct()
        {
            Assert.Equal("_firstSecondThird", "First   Second--   Third".ToUnderscoredCamelCase());
        }
    }
}
