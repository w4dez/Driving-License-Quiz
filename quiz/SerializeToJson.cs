using quiz;
using System.Text.Json;
using System.IO;

public class SerializeToJson
{
  private static void SaveJson<T>(string fileName, T obj)
  {

    File.WriteAllText(fileName, JsonSerializer.Serialize(obj, new JsonSerializerOptions
    {
      WriteIndented = true
    }));
  }

  public static void Serialize()
  {
    var user = new User
    {
      Id = 1,
      FirstName = "",
      LastName = "",
      IsAdmin = false
    };
    SaveJson("User.json", user);

    var question = new Question
    {
      Id = 1,
      CategoryId = 1,
      Explanation = "",
      QuestionText = ""
    };
    SaveJson("Question.json", question);

    var answer = new Answer
    {
      Id = 1,
      QeustionId = 1,
      AnswerText = "",
      IsCorrect = true
    };
    SaveJson("Answer.json", answer);

    var category = new Category
    {
      Id = 1,
      Name = "",
      Description = ""
    };
    SaveJson("Category.json", category);

    var quiz = new Quiz
    {
      Id = 1,
      UserId = 1,
      Attemp = 1,
      StartedAt = new DateTime(),
      FinishedAt = new DateTime()
    };
    SaveJson("quiz.json", quiz);

    var quizResult = new QuizResult
    {
      Id = 1,
      QuizId = 1,
      AnswerId = 1,
      Score = 1
    };
    SaveJson("quizResult.json", quizResult);
  }
}
