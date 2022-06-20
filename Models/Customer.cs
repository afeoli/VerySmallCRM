namespace VerySmallCRM.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string CustomerName { get; set; }
        public string CustomerEmail { get; set; }
        public int CustomerPhone { get; set; }
        public string CustomerNotes { get; set; }

        public Customer()
        {

        }
    }
}
