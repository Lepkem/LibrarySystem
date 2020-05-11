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

        public void Create(string backupName = Constants.bookbackup1)
        {
            int timestamp = (Int32)(DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1))).TotalSeconds;
            DataOperator.Instance.WriteToFile(DataOperator.Instance.SerializeJson(Catalog.Instance.GetBookList()), backupName);
        }


        public T RestoreFromBackup<T>(string backupName = Constants.bookbackup1)
        {
            return DataOperator.Instance.DeserializeJson<T>(DataOperator.Instance.ReadFromFile(backupName));
        }
    }
}
