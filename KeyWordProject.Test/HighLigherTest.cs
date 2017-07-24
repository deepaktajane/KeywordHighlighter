using KeyWordProject.Interfaces;
using System.Collections.Generic;
using Xunit;

namespace KeyWordProject.Test
{
    public class HighLigherTest
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



            as    :    blue    :    capital    :    normal
if    :    red    :     lower        :    bold
and    :    red    :    capital    :    bold
then    :    green    :    lower        :    normal
when    :    blue    :    lower     :    normal
         */
        [Fact]
        public void Should_Highlight_Keywords_In_Input()
        {
            List<Keyword> keywords = new List<Keyword>
            {
                new Keyword("as", "blue", "capital", "normal"),
                new Keyword("if", "red", "lower", "bold"),
                new Keyword("and", "red", "capital", "bold"),
                new Keyword("then", "green", "lower", "normal"),
                new Keyword("when", "blue", "lower", "normal"),
            };

            //string input = "If we write a program and compile it, then we can run the program to get output";
            string input = "If we write a program and compile it, then as we run the program, we will get output";

            var keywordFinder = new KeywordFinder(keywords);
            var highLigher = new HighLighter(
                                             keywordFinder,
                                             new IDecorater[]
                                             {
                                                 new WordCasing(),
                                                 new WordStyle(),
                                                 new Colorization(),
                                             });

            var result = highLigher.HighLight(input);

            //var expected = "[red]If[red] we write a program [red]and[red] compile it, [blue]then[blue] we can run the program to get output";
            //var expected = "[red]If[red] we write a program [red]and[red] compile it, [green]then[green] [blue]as[blue] we run the program, we will get output";
            //var expected = "[red]if[red] we write a program [red]AND[red] compile it, [green]then[green] [blue]AS[blue] we run the program, we will get output";
            var expected = "[red][bold]if[bold][red] we write a program [red][bold]AND[bold][red] compile it, [green]then[green] [blue]AS[blue] we run the program, we will get output";
            Assert.Equal(expected, result);
        }
    }
}
