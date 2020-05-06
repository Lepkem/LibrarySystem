namespace LibraryStandard
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    using Library;

    using LibraryStandard.Helpers;

    using Newtonsoft.Json;

    public class BackUp
    {

        public static void Create(string backupName = Constants.bookbackup1)
        {
            int timestamp = (Int32)(DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1))).TotalSeconds;
            DataOperator.WriteToFile(DataOperator.SerializeJson(Catalog.Instance.GetBookList()), backupName);
        }


        public static T RestoreFromBackup<T>(string backupName = Constants.bookbackup1)
        {
            return DataOperator.DeserializeJson<T>(DataOperator.ReadFromFile(backupName));
        }
    }
}
