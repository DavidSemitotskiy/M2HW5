using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace M2HW5
{
    public static class FileService
    {
        static FileService()
        {
            Config config = JsonConvert.DeserializeObject<Config>(File.ReadAllText("config.json"));
            if (!Directory.Exists(config.Logger.DirectoryPath))
            {
                Directory.CreateDirectory(config.Logger.DirectoryPath);
            }
        }

        public static void SaveToFile(Logger logger)
        {
            if (logger == null || logger.Logs.Count == 0)
            {
                return;
            }

            Config config = JsonConvert.DeserializeObject<Config>(File.ReadAllText("config.json"));
            DirectoryInfo dir = new DirectoryInfo(config.Logger.DirectoryPath);
            var files = dir.GetFiles();
            if (files.Length >= 3)
            {
                var min = files[0].CreationTime;
                int index = 0;
                for (int i = 1; i < files.Length; i++)
                {
                    if (files[i].CreationTime < min)
                    {
                        min = files[i].CreationTime;
                        index = i;
                    }
                }

                File.Delete(files[index].FullName);
            }

            File.WriteAllText($@"{config.Logger.DirectoryPath}\{DateTime.Now.ToString(config.Logger.FileName)}{config.Logger.FileExtension}", logger.GetString());
        }
    }
}
