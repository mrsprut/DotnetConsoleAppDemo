namespace ConsoleAppDemo
{
    public class Order
    {
        private static int lastId;
        public int Id { get; }

        public Order()
        {
            Id = ++lastId;
        }

        /* public int getId()
        {
            return id;
        } */
    }
}