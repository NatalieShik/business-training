using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Text.Json;
using System.Xml.Serialization;

namespace BusinessTraining
{
    public static class FileHelper
    {
        static BinaryFormatter binaryFormatter = new BinaryFormatter();
        static XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<QuestionsAndAnswers>));

        public static List<QuestionsAndAnswers> LoadFromFileOrCreateNew(string filePath)
        {
            if (!File.Exists(filePath))
            {
                SaveToFile(filePath, new List<QuestionsAndAnswers>());
            }
            return LoadFromFile(filePath);
        }

        public static List<QuestionsAndAnswers> LoadFromFile(string filePath)
        {
            List <QuestionsAndAnswers> result;
            switch (Path.GetExtension(filePath).ToLower())
            {
                case ".bin":
                    result = LoadFromFileAsBinary(filePath);
                    break;
                case ".xml":
                    result = LoadFromFileAsXml(filePath);
                    break;
                case ".json":
                    result = LoadFromFileAsJson(filePath);
                    break;
                case ".txt":
                    result = LoadFromFileAsTxt(filePath);
                    break;
                default: 
                    result = new List<QuestionsAndAnswers>(); 
                    break;
            }
            return result;
        }

        public static void SaveToFile(string filePath, List<QuestionsAndAnswers> questions)
        {
            switch (Path.GetExtension(filePath).ToLower())
            {
                case ".bin":
                    SaveToFileAsBinary(filePath, questions);
                    break;
                case ".xml":
                    SaveToFileAsXml(filePath, questions);
                    break;
                case ".json":
                    SaveToFileAsJson(filePath, questions);
                    break;
                case ".txt":
                    SaveToFileAsTxt(filePath, questions);
                    break;
            }
        }

        private static List<QuestionsAndAnswers> LoadFromFileAsBinary(string filePath)
        {
            List<QuestionsAndAnswers> result = new List<QuestionsAndAnswers>();
            using (FileStream fileStream = new FileStream(filePath, FileMode.Open))
            {
                if (fileStream.Length > 0)
                    result = (List<QuestionsAndAnswers>)binaryFormatter.Deserialize(fileStream);
            }
            return result;
        }

        private static void SaveToFileAsBinary(string filePath, List<QuestionsAndAnswers> questions)
        {
            using (FileStream fileStream = new FileStream(filePath, FileMode.Create))
            {
                binaryFormatter.Serialize(fileStream, questions);
            }
        }

        private static List<QuestionsAndAnswers> LoadFromFileAsXml(string filePath)
        {
            List<QuestionsAndAnswers> result = new List<QuestionsAndAnswers>();
            using (FileStream fileStream = new FileStream(filePath, FileMode.Open))
            {
                if (fileStream.Length > 0)
                    result = (List<QuestionsAndAnswers>)xmlSerializer.Deserialize(fileStream);
            }
            return result;
        }

        private static void SaveToFileAsXml(string filePath, List<QuestionsAndAnswers> questions)
        {
            using (FileStream fileStream = new FileStream(filePath, FileMode.Create))
            {
                xmlSerializer.Serialize(fileStream, questions);
            }
        }

        private static List<QuestionsAndAnswers> LoadFromFileAsJson(string filePath)
        {
            List<QuestionsAndAnswers> result = new List<QuestionsAndAnswers>();
            using (FileStream fileStream = new FileStream(filePath, FileMode.Open))
            {
                if (fileStream.Length > 0)
                    result = JsonSerializer.Deserialize<List<QuestionsAndAnswers>>(fileStream);
            }
            return result;
        }

        private static void SaveToFileAsJson(string filePath, List<QuestionsAndAnswers> questions)
        {
            string jsonString = SerializationHelper.Serialize(questions);
            File.WriteAllText(filePath, jsonString);
        }

        private static List<QuestionsAndAnswers> LoadFromFileAsTxt(string filePath)
        {
            List<QuestionsAndAnswers> result = new List<QuestionsAndAnswers>();
            
            using (StreamReader sr = new StreamReader(filePath, Encoding.UTF8))
            {
                string line, question = "", answer = "", direction = "", section;
                int i = 1;
                while ((line = sr.ReadLine()) != null)
                {
                    if (line == String.Empty)
                        continue;
                    switch (i)
                    {
                        case 1:
                            question = line.Replace("Вопрос: ", String.Empty).Trim();
                            break;
                        case 2:
                            answer = line.Replace("Ответ: ", String.Empty).Trim();
                            break;
                        case 3:
                            direction = line.Replace("Направление: ", String.Empty).Trim();
                            break;
                        case 4:
                            section = line.Replace("Раздел: ", String.Empty).Trim();
                            QuestionsAndAnswers QandA = new QuestionsAndAnswers(question, answer, direction, section);
                            result.Add(QandA);
                            i = 0;
                            break;
                    }
                    i++;
                }
            }
            return result;
        }

        private static void SaveToFileAsTxt(string filePath, List<QuestionsAndAnswers> questions)
        {
            using (StreamWriter writer = new StreamWriter(filePath, false, Encoding.UTF8))
            {
                foreach (var question in questions)
                {
                    writer.WriteLine("Вопрос: " + question.Question);
                    writer.WriteLine("Ответ: " + question.Answer);
                    //foreach
                    writer.WriteLine("Направление: " + question.Direction);
                    writer.WriteLine("Раздел: " + question.Section);
                    writer.WriteLine();
                }
            }
        }
    }
}
