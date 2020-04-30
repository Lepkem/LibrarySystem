namespace LibraryStandard
{
    using System.Collections.Generic;

    public interface IBackUp
    {
        void Create(BackUp.backupnum backupnumber = BackUp.backupnum.Backupnumber1);

        void RestoreProgram(BackUp.backupnum backupnumber = BackUp.backupnum.Backupnumber1);

        void ShowBackups(BackUp.backupnum backupnum = BackUp.backupnum.Backupnumber1);

        bool DeleteBackup(BackUp.backupnum backupnumber = BackUp.backupnum.Backupnumber3);
    }
}