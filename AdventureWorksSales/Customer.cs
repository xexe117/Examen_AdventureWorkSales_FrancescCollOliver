namespace AdventureWorksSales
{
    internal class Customer
    {
        public int PersonID { get; set; }
        public int CustomerID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public override string ToString()
        {
            return $"{ CustomerID }  { FirstName }";
        }
    }
}