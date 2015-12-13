using Xunit;

namespace LineProcessorInCyberDojo
{
    public class LineProcesserTest
    {
        [Fact]
        public void should_print_origin_string_when_string_is_not_greater_than_column_number()
        {
            string input = "Test print string";
            int columnNum = 17;

            Assert.Equal(input, LineProcesser.Wrapper(input, columnNum));
        }
        
        [Fact]
        public void should_print_empty_string_when_string_empty()
        {
            string input = "";
            int columnNum = 17;

            Assert.Equal(input, LineProcesser.Wrapper(input, columnNum));
        }
        
        [Fact]
        public void should_format_string_when_string_contain_number()
        {
            string input = "Test print string1 twice.";
            int columnNum = 18;

            Assert.Equal("Test print string1 \r\ntwice.", LineProcesser.Wrapper(input, columnNum));
        }
        

        [Fact]
        public void should_print_string_in_two_line_when_string_contain_one_more_word()
        {
            string input = "Test print string twice.";
            int columnNum = 18;

            Assert.Equal("Test print string \r\ntwice.", LineProcesser.Wrapper(input, columnNum));
        }

        [Fact]
        public void should_format_string_when_string_need_three_lines()
        {
            string input = "Test print string1 twice. Thought.";
            int columnNum = 10;

            Assert.Equal("Test print \r\nstring1 \r\ntwice. \r\nThought.", LineProcesser.Wrapper(input, columnNum));
        }
    }
}