using QuizApp.Models;

namespace QuizApp.Repositories
{
    public interface IQuestionsRepository
    {
        List<Question> GetAllQuestions();
        Answer GetAnswer(int Id);
        Question AddQuestion(Question question);
        Question DeleteQuestion(int id);
    }
}
