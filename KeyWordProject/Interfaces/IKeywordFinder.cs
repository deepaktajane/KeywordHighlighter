namespace KeyWordProject.Interfaces
{
    public interface IKeywordFinder
    {
        bool IsKeyword(string value, out Keyword keyword);
    }
}