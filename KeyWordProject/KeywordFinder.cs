using KeyWordProject.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace KeyWordProject
{
    public class KeywordFinder : IKeywordFinder
    {
        private readonly Dictionary<string, Keyword> _keywords;

        public KeywordFinder(IEnumerable<Keyword> keywords)
        {
            _keywords = keywords.ToDictionary(k => k.Word, v => v);
        }

        public bool IsKeyword(string value, out Keyword keyword)
        {
            return _keywords.TryGetValue(value.ToLower(), out keyword);
        }
    }
}
