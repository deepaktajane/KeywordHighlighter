using KeyWordProject.Interfaces;

namespace KeyWordProject
{
    public class WordStyle : IDecorater
    {
        #region Implementation of IDecorater

        public string Decorate(Keyword keyword, string decorated, string word)
        {
            return keyword.Style == "bold" ? $"[{keyword.Style}]{decorated}[{keyword.Style}]" : decorated;
        }

        #endregion
    }
}
