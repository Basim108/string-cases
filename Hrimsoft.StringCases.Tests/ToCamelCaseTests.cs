using Xunit;

namespace Hrimsoft.StringCases.Tests
{
    public class ToCamelCaseTests
    {
        [Fact]
        public void given_empty_string_returns_it()
        {
            Assert.Equal("", "".ToCamelCase());
        }

        [Fact]
        public void given_white_space_returns_empty_string()
        {
            Assert.Equal("", "  ".ToCamelCase());
        }

        [Fact]
        public void given_null_returns_empty_string()
        {
            Assert.Equal("", ((string)null).ToCamelCase());
        }

        [Fact]
        public void given_one_word_returns_correct()
        {
            Assert.Equal("one", "one".ToCamelCase());
            Assert.Equal("one", "One".ToCamelCase());
        }

        [Fact]
        public void given_two_spaced_words_returns_correct()
        {
            Assert.Equal("firstSecond", "First second".ToCamelCase());
        }
        
        [Fact]
        public void given_two_word_camel_returns_correct()
        {
            Assert.Equal("firstSecond", "firstSecond".ToCamelCase());
        }

        [Fact]
        public void given_two_word_snake_returns_correct()
        {
            Assert.Equal("firstSecond", "first_second".ToCamelCase());
        }
        
        [Fact]
        public void given_two_word_pascal_returns_correct()
        {
            Assert.Equal("firstSecond", "FirstSecond".ToCamelCase());
        }
        
        [Fact]
        public void given_two_word_kebab_returns_correct()
        {
            Assert.Equal("firstSecond", "first-second".ToCamelCase());
        }
        
        [Fact]
        public void given_two_word_train_returns_correct()
        {
            Assert.Equal("firstSecond", "First-Second".ToCamelCase());
        }
        
        [Fact]
        public void given_two_word_underscored_camel_returns_correct()
        {
            Assert.Equal("firstSecond", "_firstSecond".ToCamelCase());
        }
        
        [Fact]
        public void given_two_capital_letters_into_one_word() {
            Assert.Equal("countryNz",  "countryNZ".ToCamelCase());
            Assert.Equal("nz",         "NZ".ToCamelCase());
            Assert.Equal("gdprIsNotCcpa",  "GDPRisNotCCPA".ToCamelCase());
            Assert.Equal("gdpr1IsNotCcpa", "GDPR1isNotCCPA".ToCamelCase());
            Assert.Equal("1IsNotNz",   "1isNotNZ".ToCamelCase());
            Assert.Equal("1IsNot2",    "1isNot2".ToCamelCase());
        }
        
        [Fact]
        public void given_3_spaced_words_returns_correct()
        {
            Assert.Equal("firstSecondThird", "First second third".ToCamelCase());
        }

        [Fact]
        public void given_3_word_camel_returns_correct()
        {
            Assert.Equal("firstSecondThird", "firstSecondThird".ToCamelCase());
        }

        [Fact]
        public void given_3_word_snake_returns_correct()
        {
            Assert.Equal("firstSecondThird", "first_second_third".ToCamelCase());
        }

        [Fact]
        public void given_3_word_pascal_returns_correct()
        {
            Assert.Equal("firstSecondThird", "FirstSecondThird".ToCamelCase());
        }
        
        [Fact]
        public void given_3_word_train_returns_correct()
        {
            Assert.Equal("firstSecondThird", "First-Second-Third".ToCamelCase());
        }
        
        [Fact]
        public void given_3_word_kebab_returns_correct()
        {
            Assert.Equal("firstSecondThird", "first-second-third".ToCamelCase());
        }
        
        [Fact]
        public void given_3_word_underscored_camel_returns_correct()
        {
            Assert.Equal("firstSecondThird", "_firstSecondThird".ToCamelCase());
        }
        
        [Fact]
        public void given_many_delimiters_between_words_returns_correct()
        {
            Assert.Equal("firstSecondThird", "First   Second--   Third".ToCamelCase());
        }
    }
}
