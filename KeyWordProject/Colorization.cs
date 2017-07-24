using KeyWordProject.Interfaces;

namespace KeyWordProject
{
    public class Colorization : IDecorater
    {
        #region Implementation of IDecorater

        public string Decorate(Keyword keyword, string decorated, string word)
        {
            return $"[{keyword.Highlighter}]{decorated}[{keyword.Highlighter}]";
        }

        #endregion
    }
}
