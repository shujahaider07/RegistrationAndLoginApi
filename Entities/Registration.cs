namespace Entities
{
    public class Registration
    {
        public int Id { get; set; }
        public string Name{ get; set; }
        public string Password{ get; set; }

        public Registration()
        {
            Name = string.Empty;
            Password = string.Empty;
                
        }

    }
}