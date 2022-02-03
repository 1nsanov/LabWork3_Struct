namespace Task1
{
    public struct HockeyPlayer
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int CountGame { get; set; }
        public int CountGoal { get; set; }

        public HockeyPlayer(string name, int age, int countGame, int countGoal)
        {
            Name = name;
            Age = age;
            CountGame = countGame;
            CountGoal = countGoal;
        }

        public override string ToString()
        {
            return $"{Name, -16} | {Age, -7} | {CountGame, -14} | {CountGoal}";
        }
    }
}
