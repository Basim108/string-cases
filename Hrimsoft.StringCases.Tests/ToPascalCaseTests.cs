using Xunit;

namespace Hrimsoft.StringCases.Tests
{
    public class ToPascalCaseTests
    {
        [Fact]
        public void given_empty_string_returns_it()
        {
            Assert.Equal("", "".ToPascalCase());
        }

        [Fact]
        public void given_white_spaced_string_returns_empty_string()
        {
            Assert.Equal("", "  ".ToPascalCase());
        }

        [Fact]
        public void given_null_returns_empty_string()
        {
            string test = null;
            Assert.Equal("", test.ToPascalCase());
        }

        [Fact]
        public void given_one_word_returns_correct()
        {
            Assert.Equal("One", "one".ToPascalCase());
            Assert.Equal("One", "One".ToPascalCase());
        }

        [Fact]
        public void given_two_spaced_words_returns_correct()
        {
            Assert.Equal("FirstSecond", "First second".ToPascalCase());
        }
        
        [Fact]
        public void given_two_word_camel_returns_correct()
        {
            Assert.Equal("FirstSecond", "firstSecond".ToPascalCase());
        }

        [Fact]
        public void given_two_word_snake_returns_correct()
        {
            Assert.Equal("FirstSecond", "first_second".ToPascalCase());
        }
        
        [Fact]
        public void given_two_word_pascal_returns_correct()
        {
            Assert.Equal("FirstSecond", "FirstSecond".ToPascalCase());
        }
        
        [Fact]
        public void given_two_word_kebab_returns_correct()
        {
            Assert.Equal("FirstSecond", "first-second".ToPascalCase());
        }
        
        [Fact]
        public void given_two_word_train_returns_correct()
        {
            Assert.Equal("FirstSecond", "First-Second".ToPascalCase());
        }
        
        [Fact]
        public void given_two_word_underscored_camel_returns_correct()
        {
            Assert.Equal("FirstSecond", "_firstSecond".ToPascalCase());
        }

        [Fact]
        public void given_two_capital_letters_into_2_words()
        {
            Assert.Equal("AA", "AA".ToPascalCase());
        }
        
        [Fact]
        public void given_3_spaced_words_returns_correct()
        {
            Assert.Equal("FirstSecondThird", "First second third".ToPascalCase());
        }

        [Fact]
        public void given_3_word_camel_returns_correct()
        {
            Assert.Equal("FirstSecondThird", "firstSecondThird".ToPascalCase());
        }

        [Fact]
        public void given_3_word_snake_returns_correct()
        {
            Assert.Equal("FirstSecondThird", "first_second_third".ToPascalCase());
        }

        [Fact]
        public void given_3_word_pascal_returns_correct()
        {
            Assert.Equal("FirstSecondThird", "FirstSecondThird".ToPascalCase());
        }
        
        [Fact]
        public void given_3_word_train_returns_correct()
        {
            Assert.Equal("FirstSecondThird", "First-Second-Third".ToPascalCase());
        }
        
        [Fact]
        public void given_3_word_kebab_returns_correct()
        {
            Assert.Equal("FirstSecondThird", "first-second-third".ToPascalCase());
        }
        
        [Fact]
        public void given_3_word_underscored_camel_returns_correct()
        {
            Assert.Equal("FirstSecondThird", "_firstSecondThird".ToPascalCase());
        }
        
        [Fact]
        public void given_many_delimiters_between_words_returns_correct()
        {
            Assert.Equal("FirstSecondThird", "First   Second--   Third".ToPascalCase());
        }
    }
}
