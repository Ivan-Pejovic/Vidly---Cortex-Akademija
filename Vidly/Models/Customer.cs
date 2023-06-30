namespace Vidly.Models
{
    public class Customer
    {
        public int? Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Customer(int? id, string name, string lastName)
        {
            this.Id = id;
            this.FirstName = name;
            this.LastName = lastName;

        }

        public Customer() : this (0, "", "")
        {
            
        }
    }
}
