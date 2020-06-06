namespace LibraryStandard
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    using LibraryStandard.Helpers;
    using LibraryStandard.Interfaces;

    using Newtonsoft.Json;

    public sealed class BackUp :IBackUp
    {
        private static readonly BackUp _instance = new BackUp();

        static BackUp()
        {

        }

        private BackUp()
        {

        }

        public static BackUp Instance { get;}

        public void Create(string bookBackupName = Constants.bookbackup1, string userBackupName = Constants.usersbackup1, string loanBackupName = Constants.loansbackup1)
        {
            int timestamp = (Int32)(DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1))).TotalSeconds;
            DataOperator.Instance.WriteToFile(DataOperator.Instance.SerializeJson(Catalog.Instance.GetBookList()), bookBackupName);
            DataOperator.Instance.WriteToFile(DataOperator.Instance.SerializeJson(CatalogPerson.Instance.GetPersonList()), userBackupName);
            DataOperator.Instance.WriteToFile(DataOperator.Instance.SerializeJson(LoanAdministration.Instance.GetLoansList()), loanBackupName);
        }


        public List<T> RestoreFromBackup<T>( string bookBackupName = Constants.bookbackup1, string userBackupName = Constants.usersbackup1, string loanBackupName = Constants.loansbackup1)
        {
            List<T> Backups = new List<T>();
            Backups.Add(DataOperator.Instance.DeserializeJson<T>(DataOperator.Instance.ReadFromFile(bookBackupName)));
            Backups.Add(DataOperator.Instance.DeserializeJson<T>(DataOperator.Instance.ReadFromFile(userBackupName)));
            Backups.Add(DataOperator.Instance.DeserializeJson<T>(DataOperator.Instance.ReadFromFile(loanBackupName)));
            
            return Backups;
        }
    }
}
