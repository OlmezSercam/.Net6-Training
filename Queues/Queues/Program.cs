namespace Queues
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
              // defining a queue of integers
            Queue<int> queue = new Queue<int>();

              //sıranın sonuna element ekler ----> Enqueue()
            queue.Enqueue(1);

              //printing the element at the front of the queue ---> Peek()
            Console.WriteLine("The value at the front of the queue is {0}", queue.Peek());

 
              //Arkaya eklemek öndekini değiştirmez Stack gibi değil
            queue.Enqueue(2);
            Console.WriteLine("The value at the front of the queue is {0}", queue.Peek());
            queue.Enqueue(3);
            Console.WriteLine("The value at the front of the queue is {0}", queue.Peek());

              //Sıranın önündekini çıkartmak ----> Dequeue()
            queue.Dequeue();
            Console.WriteLine("The value at the front of the queue is {0}", queue.Peek());
              //Sıranın önündekini storelamak
            //int Siraonu = queue.Dequeue();

            while (queue.Count > 0)
            {
                //Dequeue() will return the element that was removed from the queue
                Console.WriteLine("The front value {0} was removed from the queue",queue.Dequeue());

                //Print the queue count
                Console.WriteLine("Current queue count is : {0}", queue.Count);
            }*/
            Queue<Order> ordersQueue = new Queue<Orders>();

            foreach (Order O in RecieveOrdersFromBranch1()) 
            {
                //add each order to the queue
                ordersQueue.Enqueue(O);
            }
            foreach (Order O in RecieveOrdersFromBranch2())
            {
                ordersQueue.Enqueue(O);
            }
            while (ordersQueue.Count > 0);
            {
                //remove the order at the front of the queue
                //and store it in a variable called currentOrder
                Order currentOrder = ordersQueue.Dequeue();
                //process the order
                currentOrder.ProcessOrder();
            }
        }
        // this method will create an array of orders and return it
        static Order[] RecieveOrdersFromBranch1()
        {
            //creating new orders array
            Order[] orders = new Order[]
            {
                new Order(1,5),
                new Order(2,4),
                new Order(6,10)
            };
            return orders;
        }
        static Order[] RecieveOrdersFromBranch2()
        {
            //creating new orders array
            Order[] orders = new Order[]
            {
                new Order(3,5),
                new Order(4,4),
                new Order(5,10)
            };
            return orders;
        }
    }
    class Order
    {
        // order ID
        public int OrderID { get; set; }

        // quantity of order
        public int OrderQuantity { get; set; }

        //simple Constructor
        public Order(int id, int orderQuantity)
        {
            this.OrderId = id;
            this.OrderQuantity = orderQuantity;
        }

        //print message on the screen that the order was processed
        public void ProcessOrder()
        {
            Console.WriteLine($"Order {OrderId} processed!.");
        }
    }
}   
