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
            Assert.Equal("", ((string)null).ToPascalCase());
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
        public void given_two_capital_letters_into_one_word() {
            Assert.Equal("CountryNz",  "countryNZ".ToPascalCase());
            Assert.Equal("Nz",         "NZ".ToPascalCase());
            Assert.Equal("GdprIsNotCcpa",  "GDPRisNotCCPA".ToPascalCase());
            Assert.Equal("Gdpr1IsNotCcpa", "GDPR1isNotCCPA".ToPascalCase());
            Assert.Equal("1IsNotNz",   "1isNotNZ".ToPascalCase());
            Assert.Equal("1IsNot2",    "1isNot2".ToPascalCase());
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
