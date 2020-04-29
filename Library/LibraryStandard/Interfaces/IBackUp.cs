namespace LibraryStandard
{
    public interface IBackUp
    {
        void Create();

        void RestoreProgram(string jsonPath);
    }
}