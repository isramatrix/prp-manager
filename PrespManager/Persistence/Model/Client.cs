namespace PrespManager.Persistence.Model
{
    public class Client
    {
        public string dni { get; }

        public string name { get; }

        public string surname { get; }

        public string mainAddress { get; }

        public Client(string dni, string name)
        {
            this.dni = dni;
            this.name = name;
        }
    }
}