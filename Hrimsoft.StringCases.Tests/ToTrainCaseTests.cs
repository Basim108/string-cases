using Xunit;

namespace Hrimsoft.StringCases.Tests
{
    public class ToTrainCaseTests
    {
        [Fact]
        public void given_empty_string_returns_it()
        {
            Assert.Equal("", "".ToTrainCase());
        }

        [Fact]
        public void given_white_space_returns_empty_string()
        {
            Assert.Equal("", "  ".ToTrainCase());
        }

        [Fact]
        public void given_null_returns_empty_string()
        {
            Assert.Equal("", ((string)null).ToTrainCase());
        }

        [Fact]
        public void given_one_word_returns_correct()
        {
            Assert.Equal("One", "one".ToTrainCase());
            Assert.Equal("One", "One".ToTrainCase());
        }

        [Fact]
        public void given_two_spaced_words_returns_correct()
        {
            Assert.Equal("First-Second", "First second".ToTrainCase());
        }

        [Fact]
        public void given_two_word_camel_returns_correct()
        {
            Assert.Equal("First-Second", "firstSecond".ToTrainCase());
        }

        [Fact]
        public void given_two_word_snake_returns_correct()
        {
            Assert.Equal("First-Second", "first_second".ToTrainCase());
        }

        [Fact]
        public void given_two_word_pascal_returns_correct()
        {
            Assert.Equal("First-Second", "FirstSecond".ToTrainCase());
        }
        
        [Fact]
        public void given_two_word_train_returns_correct()
        {
            Assert.Equal("First-Second", "First-Second".ToTrainCase());
        }
        
        [Fact]
        public void given_two_word_kebab_returns_correct()
        {
            Assert.Equal("First-Second", "first-second".ToTrainCase());
        }
        
        [Fact]
        public void given_two_word_underscored_camel_returns_correct()
        {
            Assert.Equal("First-Second", "_firstSecond".ToTrainCase());
        }
        
        [Fact]
        public void given_two_capital_letters_into_one_word() {
            Assert.Equal("Country-Nz",     "countryNZ".ToTrainCase());
            Assert.Equal("Nz",             "NZ".ToTrainCase());
            Assert.Equal("Gdpr-Is-Not-Ccpa",   "GDPRisNotCCPA".ToTrainCase());
            Assert.Equal("Gdpr-1-Is-Not-Ccpa", "GDPR1isNotCCPA".ToTrainCase());
            Assert.Equal("1-Is-Not-Nz",    "1isNotNZ".ToTrainCase());
            Assert.Equal("1-Is-Not-2",     "1isNot2".ToTrainCase());
        }
        
        [Fact]
        public void given_3_spaced_words_returns_correct()
        {
            Assert.Equal("First-Second-Third", "First second third".ToTrainCase());
        }

        [Fact]
        public void given_3_word_camel_returns_correct()
        {
            Assert.Equal("First-Second-Third", "firstSecondThird".ToTrainCase());
        }

        [Fact]
        public void given_3_word_snake_returns_correct()
        {
            Assert.Equal("First-Second-Third", "first_second_third".ToTrainCase());
        }

        [Fact]
        public void given_3_word_pascal_returns_correct()
        {
            Assert.Equal("First-Second-Third", "FirstSecondThird".ToTrainCase());
        }
        
        [Fact]
        public void given_3_word_train_returns_correct()
        {
            Assert.Equal("First-Second-Third", "First-Second-Third".ToTrainCase());
        }
        
        [Fact]
        public void given_3_word_kebab_returns_correct()
        {
            Assert.Equal("First-Second-Third", "first-second-third".ToTrainCase());
        }
        
        [Fact]
        public void given_3_word_underscored_camel_returns_correct()
        {
            Assert.Equal("First-Second-Third", "_firstSecondThird".ToTrainCase());
        }
        
        [Fact]
        public void given_many_delimiters_between_words_returns_correct()
        {
            Assert.Equal("First-Second-Third", "First   Second--   Third".ToTrainCase());
        }
    }
}