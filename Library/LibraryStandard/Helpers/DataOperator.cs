namespace LibraryStandard.Helpers
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    using Newtonsoft.Json;

    public class DataOperator
    {
        public static T DeserializeJson<T>(string strValue)
        {
            return JsonConvert.DeserializeObject<T>(strValue);
         }

        public static string SerializeJson(object objToSave)
        {
            return JsonConvert.SerializeObject(objToSave);
            //System.IO.File.WriteAllText(Constants.bookbackup1, content);
        }

        public static string ReadFromFile(string filepath)
        {
            try
            {
                string content = System.IO.File.ReadAllText(filepath);
                return content;
            }
            catch (Exception e)
            {
                StandardMessages.FilePathError(filepath);
            }


            return "";


        }

        public static void WriteToFile(string content, string filepath)
        {
            try
            {
                Directory.CreateDirectory("Backups");

                System.IO.File.WriteAllText(filepath, content);
            }
            catch (Exception e)
            {
                StandardMessages.FilePathError(filepath);
            }
            
        }
    }
}