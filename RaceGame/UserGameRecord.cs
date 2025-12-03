namespace Race
{
    public class UserGameRecord
    {
        public User Player { get; set; }
        public int Score { get; set; }
        public int Coins { get; set; }
        public DateTime RecordDate { get; set; }

        public UserGameRecord(User player, int score, int coins, DateTime recordDate)
        {
            Player = player;
            Score = score;
            Coins = coins;
            RecordDate = recordDate;
        }
    }
}