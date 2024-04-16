namespace QuizApp.Models
{
    public class Round
    {
        public int ID { get; set; }
        public int PlayerId { get; set; }
        public bool IsWon {  get; set; }

        public List<Input> Inputs { get; set; }
    }

}
