namespace LibraryStandard.Helpers
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using Newtonsoft.Json;
    using LibraryStandard.Interfaces;


    public sealed class DataOperator : IDataOperator
    {
        private static readonly DataOperator instance = new DataOperator();

        static DataOperator()
        {

        }

        private DataOperator()
        {

        }

        public static DataOperator Instance
        {
            get
            {
                return instance;
            }
        }


        public T DeserializeJson<T>(string strValue)
        {
            return JsonConvert.DeserializeObject<T>(strValue);
         }

        public string SerializeJson(object objToSave)
        {
            return JsonConvert.SerializeObject(objToSave);
            //System.IO.File.WriteAllText(Constants.bookbackup1, content);
        }

        public string ReadFromFile(string filepath)
        {
            try
            {
                string content = System.IO.File.ReadAllText(filepath);
                return content;
            }
            catch (Exception )
            {
                StandardMessages.FilePathError(filepath);
            }


            return "";


        }

        public void WriteToFile(string content, string filepath)
        {
            try
            {
                Directory.CreateDirectory("Backups");

                System.IO.File.WriteAllText(filepath, content);
            }
            catch (Exception )
            {
                StandardMessages.FilePathError(filepath);
            }
            
        }
    }
}