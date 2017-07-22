using System;
using System.Collections.Generic;
using System.Linq;

namespace KeyWordProject
{
    public class KeywordIdentifier
    {
        private IDictionary<string, Tuple<string, string>> _keywords;

        public KeywordIdentifier(IDictionary<string, Tuple<string, string>> keywords)
        {
            _keywords = keywords;
        }

        public string HighlightKeyWords(string input)
        {
            return string.Join(' ',
                input.Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Select(word => _keywords.TryGetValue(word.ToLower(), out Tuple<string, string> color)
                        ? $"[{color.Item1}]{(color.Item2 == "capital" ? word.ToUpper() : word.ToLower())}[{color.Item1}]"
                        : word)
                    .ToArray());
        }
    }
}
