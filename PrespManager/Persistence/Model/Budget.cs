namespace PrespManager.Persistence.Model
{
    public class Budget
    {
        public string id { get; }

        public Client client { get; }

        public State state { get; set; }

        public List<Job> jobs { get; }

        public Budget(string id, Client client)
        {
            this.id = id;
            this.client = client;
        }
    }
}