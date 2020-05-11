namespace LibraryStandard.Interfaces
{
    using LibraryStandard.Helpers;

    public interface IBackUp
    {

        void Create(string backupName = Constants.bookbackup1);

        T RestoreFromBackup<T>(string backupName = Constants.bookbackup1);

    }
}