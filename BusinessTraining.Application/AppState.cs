using System.Collections.Generic;

namespace BusinessTraining
{
    public static class AppState
    {
        public static List<QuestionAndAnswers> Questions { get; set; }
        public static string LastTestResult { get; set; }
        public static bool Attempt { get; set; } = true;
        public static string UserName { get; set; }
        public static bool IsManager { get; set; } = false;
        public static string TrainingTitle { get; set; }
        public static bool SendMessageProblems { get; set; } = false;
    }
}
