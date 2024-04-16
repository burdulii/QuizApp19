using QuizApp.Context;
using QuizApp.Models;
using System.Numerics;

namespace QuizApp.Repositories
{
    public class PlayerRepository : IPlayerRepository
    {
        private readonly QuizAppDbContext _context;
        public PlayerRepository(QuizAppDbContext context)
        {
            _context = context;
        }

        public Player AddPlayer(Player player)
        {
           _context.Players.Add(player);
            _context.SaveChanges();
            return player;
        }

        public Player UpdatePlayer(Player player)
        {
            _context.Players.Update(player);
            _context.SaveChanges();
            return player;
        }

        public Round UpdateRound(Round round)
        {
            _context.Rounds.Update(round);
            _context.SaveChanges();
            return round;
        }

        public Round GetRound(int id )
        {
           var round = _context.Rounds.FirstOrDefault(x => x.ID == id);
            return round;
        }

        public List<Player> GetAllPlayers()
        {
            return _context.Players.ToList();
        }

        public Player DeletePlayer(int id)
        {
            var player = _context.Players.FirstOrDefault(x => x.ID == id);
            _context.Players.Remove(player);
            _context.SaveChanges();
            return player;
        }
    }
}
