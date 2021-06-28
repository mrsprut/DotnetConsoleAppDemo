namespace ConsoleAppDemo
{
    public class Order
    {
        private static int lastId = 0;
        private int id;

        public Order()
        {
            this.id = ++lastId;
        }

        public int getId()
        {
            return id;
        }
    }
}