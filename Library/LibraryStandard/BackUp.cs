namespace LibraryStandard
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using Library;
    using Newtonsoft.Json;

    public class BackUp : IBackUp
    {
        //[kinda] move load from cat tobacklup==restore
        //[ ] restore method 
        //[ ] cat set books get allbooks -proper scopes of modifications


        public BackUp()
        {
            
        }
        public enum backupnum
        {
            Backupnumber1 = 1,
            Backupnumber2,
            Backupnumber3
        }
        public List<BackUp> BackUps { get; set; }
        public string Name { get; }
        public int BackupNumber { get; }


        //createBackup(Catalog libCatalog)

        /// <summary>
        /// LoadBookFile loads content of filename as instances of Book
        /// I think that the properties IsAvailable and AvailableWhen: should be added to each book upon init in this function
        /// </summary>
        /// <param name="fileName"></param>
        public void LoadBookFile(string fileName)
        {
            string fileContentString = "";
            try
            {
                fileContentString = File.ReadAllText(fileName);
                books = JsonConvert.DeserializeObject<List<Book>>(fileContentString); // here I made instances of classes from a JSON string in a list of class movie

            }
            catch (Exception e)
            {
                Console.WriteLine($"{e.Message}, so something is not dobra :(");
            }
        }

        /// <summary>
        /// Create, creates a new backup in one out of three available slots with a timestamp
        /// </summary>
        public void Create(backupnum backupnumber = backupnum.Backupnumber1)
        {
            // [X] make timestamp
            // [ ] serialize Books into json file
            // [X] create json file in folder backups

            //you will know the name -basedon  naming conv
            //

            int timestamp = (Int32)(DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1))).TotalSeconds;
            var SerializedBooks = JsonConvert.SerializeObject(Catalog.GetBookList());
            switch (backupnumber)
            {
                case backupnum.Backupnumber1:
                    //System.IO.File.Create("@Backups/1.json");

                    System.IO.File.WriteAllLines("@Backups/1.json", SerializedBooks);
                    break;
                case backupnum.Backupnumber2:
                    //System.IO.File.Create("@Backups/2.json");
                    System.IO.File.WriteAllLines("@Backups/2.json", SerializedBooks);
                    break;
                case backupnum.Backupnumber3:
                    //System.IO.File.Create("@Backups/3.json");
                    System.IO.File.WriteAllLines("@Backups/3.json", SerializedBooks);
                    break;
            }
            
        }

        /// <summary>
        /// RestoreProgram reads and loads backup file in current situation
        /// </summary>
        /// <param name="jsonPath"></param>
        public void RestoreProgram(backupnum backupnumber = backupnum.Backupnumber1)
        {
            List<Book> backupList;
            try
            {
                switch (backupnumber)
                {
                    case backupnum.Backupnumber1:
                        backupList = JsonConvert.DeserializeObject<List<Book>>("@Backups/1.json");
                        break;
                    case backupnum.Backupnumber2:
                        backupList = JsonConvert.DeserializeObject<List<Book>>("@Backups/2.json");
                        break;
                    case backupnum.Backupnumber3:
                        backupList = JsonConvert.DeserializeObject<List<Book>>("@Backups/3.json");
                        break;

                }

                Catalog.SetBookList = backupList;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        /// <summary>
        /// ShowBackups prints 1. backupnumber and 2. timestamp of backup file
        /// </summary>
        public void ShowBackups()
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="backupnumber"></param>
        public bool DeleteBackup(backupnum backupnumber = backupnum.Backupnumber3)
        {
            try
            {
                switch (backupnumber)
                {
                    case backupnum.Backupnumber1:
                        System.IO.File.Delete("@Backups/1.json");
                        break;
                    case backupnum.Backupnumber2:
                        System.IO.File.Delete("@Backups/2.json");
                        break;
                    case backupnum.Backupnumber3:
                        System.IO.File.Delete("@Backups/3.json");
                        break;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            return true;
        }

    }
}