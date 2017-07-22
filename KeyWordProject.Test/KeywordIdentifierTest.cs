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

            List<string> keywords = new List<string>()
            {
                "as","if","and","then","when"
            };

            string input = "If we write a program and compile it, then we can run the program to get output";

            var keywordIdentifier = new KeywordIdentifier(keywords);

            var result = keywordIdentifier.HighlightKeyWords(input);

            var expected = "[blue]If[blue] we write a program [blue]and[blue] compile it, [blue]then[blue] we can run the program to get output";

            Assert.Equal(expected, result);
        }
    }
}
