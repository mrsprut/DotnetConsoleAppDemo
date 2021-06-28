namespace ConsoleAppDemo
{
    // public struct Order
    public class Order
    {
        private static int lastId;

        public delegate void PrintInfoDelegate();
        public int Id { get; }
        public int UserId { get; }
        public int ProductId { get; }
        public int Quantity { get; }
        public decimal Price { get; }

        /* public Order()
        {
            Id = ++lastId;
        } */

        public Order(int userId, int productId, int quantity, decimal price)// : this()
        {
            Id = ++lastId;
            UserId = userId;
            ProductId = productId;
            Quantity = quantity;
            Price = price;
        }

        /* public int getId()
        {
            return id;
        } */

        public void PrintInfo(PrintInfoDelegate printer)
        {
            printer.Invoke();
        }

        public override string ToString()
        {
            return $"Id = {Id}, Price = {Price}, Quantity = {Quantity}";
        }
    }
}