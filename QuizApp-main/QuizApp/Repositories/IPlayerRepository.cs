using QuizApp.Models;

namespace QuizApp.Repositories
{
    public interface IPlayerRepository
    {
        List<Player> GetAllPlayers();
        public Player AddPlayer(Player player);
        public Player UpdatePlayer (Player player);
        public Round UpdateRound (Round round);

        public Round GetRound (int  id);
        public Player DeletePlayer (int id);
    }
}
