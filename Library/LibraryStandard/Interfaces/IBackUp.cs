namespace LibraryStandard
{
    using System.Collections.Generic;

    public interface IBackUp
    {
        string Name { get; }
        int BackupNumber { get; }
        List<BackUp> BackUps { get; set;}

        void Create(BackUp.backupnum backupnumber = BackUp.backupnum.Backupnumber1);

        public void RestoreProgram(BackUp.backupnum backupnumber = BackUp.backupnum.Backupnumber1);

        void ShowBackups();

        bool DeleteBackup(BackUp.backupnum backupnumber = BackUp.backupnum.Backupnumber3);
    }
}