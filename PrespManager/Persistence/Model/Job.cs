namespace PrespManager.Persistence.Model
{
    public class Job
    {
        public string name { get; }

        public double prize { get; }

        public Budget(string name, double prize)
        {
            this.name = name;
            this.prize = prize;
        }
    }
}