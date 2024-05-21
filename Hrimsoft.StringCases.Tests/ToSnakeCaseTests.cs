using Xunit;

namespace Hrimsoft.StringCases.Tests
{
    public class ToSnakeCaseTests
    {
        [Fact]
        public void given_empty_string_returns_it()
        {
            Assert.Equal("", "".ToSnakeCase());
        }

        [Fact]
        public void given_white_spaced_string_returns_empty_string()
        {
            Assert.Equal("", "  ".ToSnakeCase());
        }

        [Fact]
        public void given_null_returns_empty_string()
        {
            Assert.Equal("", ((string)null).ToSnakeCase());
        }

        [Fact]
        public void given_one_word_returns_correct()
        {
            Assert.Equal("one", "one".ToSnakeCase());
            Assert.Equal("one", "One".ToSnakeCase());
        }

        [Fact]
        public void given_two_spaced_words_returns_correct()
        {
            Assert.Equal("first_second", "First second".ToSnakeCase());
        }
        
        [Fact]
        public void given_two_word_camel_returns_correct()
        {
            Assert.Equal("first_second", "firstSecond".ToSnakeCase());
        }

        [Fact]
        public void given_two_word_snake_returns_correct()
        {
            Assert.Equal("first_second", "first_second".ToSnakeCase());
        }
        
        [Fact]
        public void given_two_word_pascal_returns_correct()
        {
            Assert.Equal("first_second", "FirstSecond".ToSnakeCase());
        }
        
        [Fact]
        public void given_two_word_kebab_returns_correct()
        {
            Assert.Equal("first_second", "first-second".ToSnakeCase());
        }
        
        [Fact]
        public void given_two_word_train_returns_correct()
        {
            Assert.Equal("first_second", "First-Second".ToSnakeCase());
        }
        
        [Fact]
        public void given_two_word_underscored_camel_returns_correct()
        {
            Assert.Equal("first_second", "_firstSecond".ToSnakeCase());
        }
        
        [Fact]
        public void given_two_capital_letters_into_one_word()
        {
            Assert.Equal("country_nz",     "countryNZ".ToSnakeCase());
            Assert.Equal("nz",             "NZ".ToSnakeCase());
            Assert.Equal("gdpr_is_not_ccpa",   "GDPRisNotCCPA".ToSnakeCase());
            Assert.Equal("gdpr_1_is_not_ccpa", "GDPR1isNotCCPA".ToSnakeCase());
            Assert.Equal("1_is_not_nz",    "1isNotNZ".ToSnakeCase());
            Assert.Equal("1_is_not_2",     "1isNot2".ToSnakeCase());
        }

        [Fact]
        public void given_3_spaced_words_returns_correct()
        {
            Assert.Equal("first_second_third", "First second third".ToSnakeCase());
        }

        [Fact]
        public void given_3_word_camel_returns_correct()
        {
            Assert.Equal("first_second_third", "firstSecondThird".ToSnakeCase());
        }

        [Fact]
        public void given_3_word_snake_returns_correct()
        {
            Assert.Equal("first_second_third", "first_second_third".ToSnakeCase());
        }

        [Fact]
        public void given_3_word_pascal_returns_correct()
        {
            Assert.Equal("first_second_third", "FirstSecondThird".ToSnakeCase());
        }
        
        [Fact]
        public void given_3_word_train_returns_correct()
        {
            Assert.Equal("first_second_third", "First-Second-Third".ToSnakeCase());
        }
        
        [Fact]
        public void given_3_word_kebab_returns_correct()
        {
            Assert.Equal("first_second_third", "first-second-third".ToSnakeCase());
        }
        
        [Fact]
        public void given_3_word_underscored_camel_returns_correct()
        {
            Assert.Equal("first_second_third", "_firstSecondThird".ToSnakeCase());
        }
        
        [Fact]
        public void given_many_delimiters_between_words_returns_correct()
        {
            Assert.Equal("first_second_third", "First   Second--   Third".ToSnakeCase());
        }
    }
}
