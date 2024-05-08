using Spire.Doc;
using Spire.Doc.Documents;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;

namespace BusinessTraining
{
    public static class FileHelper
    {
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
            List<QuestionsAndAnswers> result;
            switch (Path.GetExtension(filePath).ToLower())
            {
                case ".json":
                    result = LoadFromFileAsJson(filePath);
                    break;
                case ".txt":
                    result = LoadFromFileAsTxt(filePath);
                    break;
                case ".docx":
                    result = LoadFromFileAsDocx(filePath);
                    break;
                case ".training":
                    result = LoadFromFileAsTraining(filePath);
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
                case ".json":
                    SaveToFileAsJson(filePath, questions);
                    break;
                case ".txt":
                    SaveToFileAsTxt(filePath, questions);
                    break;
                case ".docx":
                    SaveToFileAsDocx(filePath, questions);
                    break;
                case ".training":
                    SaveToFileAsTraining(filePath, questions);
                    break;
            }
        }

        private static List<QuestionsAndAnswers> LoadFromFileAsJson(string filePath)
        {
            List<QuestionsAndAnswers> result = new List<QuestionsAndAnswers>();
            using (FileStream fileStream = new FileStream(filePath, FileMode.Open))
            {
                if (fileStream.Length > 0)
                    result = SerializationHelper.Deserialize<List<QuestionsAndAnswers>>(fileStream);
            }
            return result;
        }

        private static void SaveToFileAsJson(string filePath, List<QuestionsAndAnswers> questions)
        {
            string jsonString = SerializationHelper.Serialize(questions);
            File.WriteAllText(filePath, jsonString, Encoding.UTF8);
        }

        private static List<QuestionsAndAnswers> LoadFromFileAsTraining(string filePath)
        {
            string encodedJsonString = File.ReadAllText(filePath, Encoding.UTF8);
            string jsonString = CryptoHelper.Decrypt(encodedJsonString);
            List<QuestionsAndAnswers> result = SerializationHelper.Deserialize<List<QuestionsAndAnswers>>(jsonString);
            return result;
        }

        private static void SaveToFileAsTraining(string filePath, List<QuestionsAndAnswers> questions)
        {
            string jsonString = SerializationHelper.Serialize(questions);
            string encryptedContent = CryptoHelper.Encrypt(jsonString);
            File.WriteAllText(filePath, encryptedContent, Encoding.UTF8);
        }
        private static List<QuestionsAndAnswers> LoadFromFileAsTxt(string filePath)
        {
            List<QuestionsAndAnswers> result = new List<QuestionsAndAnswers>();
            using (StreamReader sr = new StreamReader(filePath, Encoding.UTF8))
            {
                string line, question = "", answer = "", direction = "", section;
                List<string> wrongAnswers = new List<string>();
                while ((line = sr.ReadLine()) != null)
                {
                    if (line == String.Empty)
                        continue;
                    if (line.StartsWith("Вопрос: "))
                        question = line.Replace("Вопрос: ", String.Empty).Trim();
                    else if (line.StartsWith("Ответ: "))
                        answer = line.Replace("Ответ: ", String.Empty).Trim();
                    else if (line.StartsWith("Неправильный ответ: "))
                        wrongAnswers.Add(line.Replace("Неправильный ответ: ", String.Empty).Trim());
                    else if (line.StartsWith("Направление: "))
                        direction = line.Replace("Направление: ", String.Empty).Trim();
                    else if (line.StartsWith("Раздел: "))
                    {
                        section = line.Replace("Раздел: ", String.Empty).Trim();
                        QuestionsAndAnswers QandA = new QuestionsAndAnswers(question, answer, wrongAnswers, direction, section);
                        result.Add(QandA);
                        wrongAnswers = new List<string>();
                    }
                }
            }
            if (result.Count == 0)
                throw new InvalidOperationException("Неверный формат файла.");
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

                    foreach (var wrongAnswer in question.WrongAnswers)
                        writer.WriteLine("Неправильный ответ: " + wrongAnswer);

                    writer.WriteLine("Направление: " + question.Direction);
                    writer.WriteLine("Раздел: " + question.Section);
                    writer.WriteLine();
                }
            }
        }

        private static List<QuestionsAndAnswers> LoadFromFileAsDocx(string filePath)
        {
            string tempFileName = Path.GetTempFileName();
            Debug.WriteLine(tempFileName);
            Document doc = new Document();
            doc.LoadFromFile(filePath);
            doc.SaveToTxt(tempFileName, Encoding.UTF8);

            var result = LoadFromFileAsTxt(tempFileName);

            return result;
        }

        private static void SaveToFileAsDocx(string filePath, List<QuestionsAndAnswers> questions)
        {
            string lineBreak = "\v";
            Document doc = new Document();
            Paragraph paragraph = doc.AddSection().AddParagraph();
            foreach (var question in questions)
            {
                paragraph.AppendText("Вопрос: " + question.Question + lineBreak);
                paragraph.AppendText("Ответ: " + question.Answer + lineBreak);

                foreach (var wrongAnswer in question.WrongAnswers)
                    paragraph.AppendText("Неправильный ответ: " + wrongAnswer + lineBreak);

                paragraph.AppendText("Направление: " + question.Direction + lineBreak);
                paragraph.AppendText("Раздел: " + question.Section + lineBreak);
                paragraph.AppendText(lineBreak);
            }
            doc.SaveToFile(filePath);
        }
    }
}
