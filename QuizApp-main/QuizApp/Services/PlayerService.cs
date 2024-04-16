using QuizApp.Models;
using QuizApp.Repositories;

namespace QuizApp.Services
{
    public class PlayerService
    {
        private readonly IPlayerRepository _playerRepo;
        private readonly IQuestionsRepository _questionRepo;
        public PlayerService(IPlayerRepository playerRepo, IQuestionsRepository questionsRepo)
        {
            _playerRepo = playerRepo;
            _questionRepo = questionsRepo;
        }

        public Player CreatePlayer(string name)
        {
            var newplayer = new Player(name);
            var player = _playerRepo.AddPlayer(newplayer);
            return player;
        }
        public Round UpdateRound(int roundId, int answerId)
        {
            var round = _playerRepo.GetRound(roundId);
            var answer = _questionRepo.GetAnswer(answerId);
            var input = new Input();
            round.Inputs.Add(input);
            return round;
        }
    }
}
