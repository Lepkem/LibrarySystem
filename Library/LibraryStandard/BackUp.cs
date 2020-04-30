namespace LibraryStandard
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using Library;
    using Newtonsoft.Json;

    public class BackUp : IBackUp
    {
        public BackUp()
        {

        }

        public enum backupnum
        {
            Backupnumber1 = 1,

            Backupnumber2,

            Backupnumber3
        }

        /// <summary>
        /// Create, creates a new backup in one out of three available slots with a timestamp
        /// </summary>
        public void Create(backupnum backupnumber = backupnum.Backupnumber1) //we could also let the user
                                                                             //input backupnumbook, user, loan and separate
                                                                             //the three in the switch case the give user more autonomy
        {
            int timestamp = (Int32)(DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1))).TotalSeconds;
            string SerializedBooks = JsonConvert.SerializeObject(Catalog.Instance.GetBookList());
            //string SerializesUsers = JsonConvert.SerializeObject(Catalog.Instance.GetUserList());
            //string SerializesLoans = JsonConvert.SerializeObject(Catalog.Instance.GetLoanList());
            switch (backupnumber)
            {
                case backupnum.Backupnumber1:
                    //System.IO.File.Create("@Backups/1.json");

                    System.IO.File.WriteAllText(Constants.bookbackup1, SerializedBooks);
                    //System.IO.File.WriteAllText(Constants.usersbackup1, SerializesUsers);
                    //System.IO.File.WriteAllText(Constants.loansbackup1, SerializesLoans);
                    break;
                case backupnum.Backupnumber2:
                    //System.IO.File.Create("@Backups/2.json");
                    System.IO.File.WriteAllText(Constants.bookbackup2, SerializedBooks);
                    //System.IO.File.WriteAllText(Constants.usersbackup2, SerializesUsers);
                    //System.IO.File.WriteAllText(Constants.loansbackup2, SerializesLoans);
                    break;
                case backupnum.Backupnumber3:
                    //System.IO.File.Create("@Backups/3.json");
                    System.IO.File.WriteAllText(Constants.bookbackup3, SerializedBooks);
                    //System.IO.File.WriteAllText(Constants.usersbackup3, SerializesUsers);
                    //System.IO.File.WriteAllText(Constants.loansbackup3, SerializesLoans);
                    break;
            }
        }

        /// <summary>
        /// RestoreFromBackup is still to be implemented
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public List<T> RestoreFromBackup<T>(string fileName)
        {
            return JsonConvert.DeserializeObject<List<T>>(fileName);
        }

        /// <summary>
        /// RestoreProgram reads and loads backup file in current situation
        /// </summary>
        /// <param name="jsonPath"></param>
        public void RestoreProgram(backupnum backupnumber = backupnum.Backupnumber1)
        {
            List<Book> bookbackupList = null;
            //List<User> userbackupList;
            //List<Loan> loanbackupList;
            try
            {
                switch (backupnumber)
                {
                    case backupnum.Backupnumber1:
                        bookbackupList = JsonConvert.DeserializeObject<List<Book>>(Constants.bookbackup1);
                        //userbackupList = JsonConvert.DeserializeObject<List<Book>>(Constants.usersbackup1);
                        //loanbackupList = JsonConvert.DeserializeObject<List<Book>>(Constants.loansbackup1);
                        break;
                    case backupnum.Backupnumber2:
                        bookbackupList = JsonConvert.DeserializeObject<List<Book>>(Constants.bookbackup2);
                        //userbackupList = JsonConvert.DeserializeObject<List<Book>>(Constants.usersbackup1);
                        //loanbackupList = JsonConvert.DeserializeObject<List<Book>>(Constants.loansbackup1);
                        break;
                    case backupnum.Backupnumber3:
                        bookbackupList = JsonConvert.DeserializeObject<List<Book>>(Constants.bookbackup3);
                        //userbackupList = JsonConvert.DeserializeObject<List<Book>>(Constants.usersbackup1);
                        //loanbackupList = JsonConvert.DeserializeObject<List<Book>>(Constants.loansbackup1);
                        break;
                }
                Catalog.Instance.SetBookList(bookbackupList);
                //Catalog.Instance.SetUserList(userbackupList);
                //Catalog.Instance.SetLoanList(loanbackupList);
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
        public void ShowBackups(backupnum backupnum = backupnum.Backupnumber1)
        {
            switch (backupnum)
            {
                case backupnum.Backupnumber1:
                    var backupbook1time = System.IO.File.GetLastWriteTime(Constants.bookbackup1);
                    Console.WriteLine(
                        $"File backup1 was last edited at:{backupbook1time} and is located at {Constants.bookbackup1}"); //this wording needs edit if backups will be split.
                    break;
                case backupnum.Backupnumber2:
                    var backupbook2time = System.IO.File.GetLastWriteTime(Constants.bookbackup2);
                    Console.WriteLine($"File backup2 was last edited at:{backupbook2time} and is located at {Constants.bookbackup2}");
                    break;
                case backupnum.Backupnumber3:
                    var backupbook3time = System.IO.File.GetLastWriteTime(Constants.bookbackup3);
                    Console.WriteLine($"File backup3 was last edited at:{backupbook3time} and is located at {Constants.bookbackup3}");
                    break;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="backupnumber"></param>
        public bool DeleteBackup(backupnum backupnumber = backupnum.Backupnumber3) //this signature plus cases needs work and thinking
        {
            try
            {
                switch (backupnumber) 
                {
                    case backupnum.Backupnumber1:
                        System.IO.File.Delete(Constants.bookbackup1); 
                        System.IO.File.Delete(Constants.usersbackup1); 
                        System.IO.File.Delete(Constants.loansbackup1); 
                        break;
                    case backupnum.Backupnumber2: 
                        System.IO.File.Delete(Constants.bookbackup2); 
                        System.IO.File.Delete(Constants.usersbackup2); 
                        System.IO.File.Delete(Constants.loansbackup2); 
                        break;
                    case backupnum.Backupnumber3: 
                        System.IO.File.Delete(Constants.bookbackup3); 
                        System.IO.File.Delete(Constants.usersbackup3); 
                        System.IO.File.Delete(Constants.loansbackup3); 
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
