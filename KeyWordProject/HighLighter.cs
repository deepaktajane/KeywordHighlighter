using KeyWordProject.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace KeyWordProject
{
    public class HighLighter
    {
        private readonly IKeywordFinder _keywordFinder;
        private readonly IEnumerable<IDecorater> _decoraters;

        public HighLighter(IKeywordFinder keywordFinder, IEnumerable<IDecorater> decoraters)
        {
            _keywordFinder = keywordFinder;
            _decoraters = decoraters;
        }

        public string HighLight(string input)
        {
            return string.Join(' ', input.Split(' ').Select(word => _keywordFinder.IsKeyword(word, out Keyword keyword) ? Decorate(keyword, word) : word));
        }

        private string Decorate(Keyword keyword, string word)
        {
            return _decoraters.Aggregate(word, (current, decorater) => decorater.Decorate(keyword, current, word));
        }
    }
}
