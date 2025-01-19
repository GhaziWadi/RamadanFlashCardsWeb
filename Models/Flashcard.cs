// Models/Flashcard.cs
namespace RamadanFlashcardsWeb.Models
{
    public class Flashcard
    {
        public string Question { get; set; }
        public string Answer { get; set; }

          public int   Id  { get; set; }
          public string       QuestionArabic  { get; set; }
           public string      QuestionEnglish  { get; set; }
           public string      AnswerArabic { get; set; }
          public string       AnswerEnglish { get; set; }
         public string        Category  { get; set; }
        public string         Difficulty  { get; set; }
    }
}
