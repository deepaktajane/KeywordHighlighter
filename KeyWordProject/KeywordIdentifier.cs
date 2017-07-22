using System;
using System.Collections.Generic;
using System.Linq;

namespace KeyWordProject
{
    public class KeywordIdentifier
    {
        private IDictionary<string, string> _keywords;

        public KeywordIdentifier(IDictionary<string, string> keywords)
        {
            _keywords = keywords;
        }

        public string HighlightKeyWords(string input)
        {
            return string.Join(' ',
                input.Split(' ', StringSplitOptions.RemoveEmptyEntries)
                     .Select(word => _keywords.TryGetValue(word.ToLower(), out string color) ? $"[{color}]{word}[{color}]" : word)
                     .ToArray());
        }
    }
}
