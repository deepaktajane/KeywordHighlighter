namespace KeyWordProject
{
    public class Keyword
    {
        public string Word { get; }
        public string Highlighter { get; }
        public string Case { get; }
        public string Style { get; }

        public Keyword(string word, string highlighter, string inputCase, string inputStyle)
        {

            Word = word;
            Highlighter = highlighter;
            Case = inputCase;
            Style = inputStyle;
        }
    }
}
