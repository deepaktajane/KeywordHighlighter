using System.Collections.Generic;
using Xunit;

namespace KeyWordProject.Test
{
    public class KeywordIdentifierTest
    {
        /*
         * Story 1
When given a set of keywords we need to identify the occurrences of keywords in given input text and mark them with [blue] color attribute

Sample Keywords:
as if and then when

Sample Input:
If we write a program and compile it, then we can run the program to get output

Sample Output:
[blue]If[blue] we write a program [blue]and[blue] compile it, [blue]then[blue] we can run the program to get output
         */
        [Fact]
        public void Should_Highlight_Keywords_In_Input()
        {
            Dictionary<string, string> keywords = new Dictionary<string, string>
            {
                { "as","blue"},
                { "if","red"},
                { "and","red"},
                { "then","green"},
                { "when","blue"},
            };

            //string input = "If we write a program and compile it, then we can run the program to get output";

            string input = "If we write a program and compile it, then as we run the program, we will get output";

            var keywordIdentifier = new KeywordIdentifier(keywords);

            var result = keywordIdentifier.HighlightKeyWords(input);

            //var expected = "[blue]If[blue] we write a program [blue]and[blue] compile it, [blue]then[blue] we can run the program to get output";
            var expected = "[red]If[red] we write a program [red]and[red] compile it, [green]then[green] [blue]as[blue] we run the program, we will get output";

            Assert.Equal(expected, result);
        }
    }
}
