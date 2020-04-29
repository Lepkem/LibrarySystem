namespace LibraryStandard
{
    using System;

    public class BackUp : IBackUp
    {
        public void Create()
        {
            // create json file in folder backups
            // serialize Books into json file
            // make timestamp
            throw new System.NotImplementedException();
        }

        public void RestoreProgram(string jsonPath)
        {
            throw new System.NotImplementedException();
        }
    }
}