using System;
using System.Collections.Generic;
using System.Linq;

namespace KeyWordProject
{
    public class KeywordIdentifier
    {
        private List<string> _keywords;

        public KeywordIdentifier(List<string> keywords)
        {
            _keywords = keywords;
        }

        public string HighlightKeyWords(string input)
        {
            return string.Join(' ',
                input.Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Select(word => _keywords.Contains(word.ToLower()) ? $"[blue]{word}[blue]" : word).ToArray());
        }
    }
}
