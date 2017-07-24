using KeyWordProject.Interfaces;

namespace KeyWordProject
{
    public class WordCasing : IDecorater
    {
        #region Implementation of IDecorater

        public string Decorate(Keyword keyword, string decorated, string word)
        {
            return keyword.Case == "capital" ? word.ToUpper() : word.ToLower();
        }

        #endregion
    }
}
