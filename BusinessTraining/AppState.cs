using System.Collections.Generic;

namespace BusinessTraining
{
    public static class AppState
    {
        public static List<QuestionsAndAnswers> Questions { get; set; }
        public static string LastTestResult { get; set; }
        public static string UserName { get; set; }
        public static string TrainingTitle { get; set; }
    }
}
