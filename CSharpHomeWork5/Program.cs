//写一个订单管理的控制台程序，能够实现添加订单、删除订单、修改订单、查询订单
//（按照订单号、商品名称、客户等字段进行查询）功能。
//提示：主要的类有Order（订单）、OrderItem（订单明细项），OrderService（订单服务），
//订单数据可以保存在OrderService中一个List中。
//在Program里面可以调用OrderService的方法完成各种订单操作。
//要求：
//（1）使用LINQ语言实现各种查询功能，查询结果按照订单总金额排序返回。
//（2）在订单删除、修改失败时，能够产生异常并显示给客户错误信息。
//（3）作业的订单和订单明细类需要重写Equals方法，确保添加的订单不重复，
//     每个订单的订单明细不重复。
//（4）订单、订单明细、客户、货物等类添加ToString方法，用来显示订单信息。
//（5）OrderService提供排序方法对保存的订单进行排序。默认按照订单号排序，
//     也可以使用Lambda表达式进行自定义排序。
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace CSharpHomework5

{

    class Program

    {

        class MatchException : Exception

        {

            private int code;

            public MatchException(string message, int code) : base(message)

            {

                this.code = code;

            }

            public int Code { get => code; }

        }



        public class OrderService

        {

            private List<Order> orders;

            public int order_amount { get => orders.Count; }



            public OrderService()

            {

                orders = new List<Order>();

            }



            private bool CheckOrder(Order order)

            {

                foreach (Order order_this in orders)

                {

                    if (order_this.Equals(order))

                        return true;

                }

                return false;

            }



            private Order FindOrderID(int ID)

            {

                foreach (Order order_this in orders)

                {

                    if (order_this.ID == ID)

                    {

                        return order_this;

                    }

                }

                return null;

            }



            public void AddOrder(Order order)

            {

                if (CheckOrder(order))

                {

                    throw new MatchException("Add order match error", 1);

                }

                orders.Add(new Order(order));

            }



            public void AddOrderItem(int ID, OrderItem orderitem)

            {

                Order order = FindOrderID(ID);

                if (order == null)

                {

                    throw new MatchException("Order match error", 0);

                }

                order.AddOrderItem(orderitem);

            }



            public void DeleteOrder(int ID)

            {

                Order order = FindOrderID(ID);

                if (order == null)

                {

                    throw new MatchException("Delete order match error", 2);

                }

                orders.Remove(order);

            }



            public void DeleteOrderItem(int Order_ID, int OrderItem_ID)

            {

                Order order = FindOrderID(Order_ID);

                if (order == null)

                {

                    throw new MatchException("Order match error", 0);

                }

                order.DeleteOrderItem(OrderItem_ID);

            }



            public void UpdateOrder(int ID, Order order)

            {

                DeleteOrder(ID);

                AddOrder(order);

            }



            public void UpdateOrderList(int Order_ID, int OrderItem_ID, OrderItem orderitem)

            {

                Order order = FindOrderID(Order_ID);

                if (order == null)

                {

                    throw new MatchException("Order match error", 0);

                }

                order.DeleteOrderItem(OrderItem_ID);

                order.AddOrderItem(orderitem);

            }



            public List<Order> FindOrder(Func<Order, bool> func)

            {

                var query = orders.Where(func).OrderBy(order => order.TotalPrice);

                return query.ToList<Order>();

            }



            public List<OrderItem> FindOrderItem(int Order_ID, Func<OrderItem, bool> func)

            {

                Order order = FindOrderID(Order_ID);

                if (order == null)

                {

                    throw new MatchException("Order match error", 0);

                }

                var query = order.orderitems.Where(func).OrderBy(orderitem => orderitem.Price * orderitem.Quantity);

                return query.ToList<OrderItem>();

            }



            public void SortOrder()

            {

                orders.Sort((order1, order2) => order1.ID - order2.ID);

            }



            public void SortOrder(Func<Order, Order, int> func)

            {

                orders.Sort((order1, order2) => func(order1, order2));

            }



            public Order GetFirst()

            {

                if (order_amount > 0)

                    return new Order(orders[0]);

                else

                    return null;

            }

        }



        public class Order

        {

            public int ID { get; set; }

            public string CustomerName { get; set; }

            public double TotalPrice

            {

                get

                {

                    var query = from orderitem in orderitems

                                select orderitem.Price * orderitem.Quantity;

                    return query.Sum();

                }

            }

            public List<OrderItem> orderitems;



            public Order(int ID, string CustomerName)

            {

                this.ID = ID;

                this.CustomerName = CustomerName;

                orderitems = new List<OrderItem>();

            }



            public Order(Order order)

            {

                ID = order.ID;

                CustomerName = order.CustomerName;

                orderitems = new List<OrderItem>();

                foreach (OrderItem orderItem in order.orderitems)

                {

                    orderitems.Add(new OrderItem(orderItem));

                }

            }



            public override bool Equals(object obj)

            {

                Order order = obj as Order;

                return order != null && ID == order.ID;

            }



            public override int GetHashCode()

            {

                var hashCode = -221969603;

                hashCode = hashCode * -1521134295 + ID.GetHashCode();

                hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(CustomerName);

                hashCode = hashCode * -1521134295 + TotalPrice.GetHashCode();

                hashCode = hashCode * -1521134295 + EqualityComparer<List<OrderItem>>.Default.GetHashCode(orderitems);

                return hashCode;

            }



            public override string ToString()

            {

                return $"Order_ID: {ID} CustomerName: {CustomerName} TotalPrice: {TotalPrice}";

            }



            private bool CheckOrderItem(OrderItem orderitem)

            {

                foreach (OrderItem orderitem_this in orderitems)

                {

                    if (orderitem_this.Equals(orderitem))

                    {

                        return true;

                    }

                }

                return false;

            }



            private OrderItem FindOrderItemID(int ID)

            {

                foreach (OrderItem orderitem in orderitems)

                {

                    if (orderitem.ID == ID)

                    {

                        return orderitem;

                    }

                }

                return null;

            }



            public void AddOrderItem(OrderItem orderitem)

            {

                if (CheckOrderItem(orderitem))

                {

                    throw new MatchException("Add orderItem match error", 3);

                }

                orderitems.Add(new OrderItem(orderitem));

            }



            public void DeleteOrderItem(int ID)

            {

                OrderItem orderitem = FindOrderItemID(ID);

                if (orderitem == null)

                {

                    throw new MatchException("Delete orderItem match error", 4);

                }

                orderitems.Remove(orderitem);

            }

        }



        public class OrderItem

        {

            public int ID { get; set; }

            public string ProductName { get; set; }

            public double Price { get; set; }

            public int Quantity { get; set; }



            public OrderItem(int ID, string ProductName, double Price, int Quantity)

            {

                this.ID = ID;

                this.ProductName = ProductName;

                this.Price = Price;

                this.Quantity = Quantity;

            }



            public OrderItem(OrderItem orderitem)

            {

                ID = orderitem.ID;

                ProductName = orderitem.ProductName;

                Price = orderitem.Price;

                Quantity = orderitem.Quantity;

            }



            public override bool Equals(object obj)

            {

                OrderItem orderitem = obj as OrderItem;

                return orderitem != null && ID == orderitem.ID;

            }



            public override int GetHashCode()

            {

                var hashCode = -1799128887;

                hashCode = hashCode * -1521134295 + ID.GetHashCode();

                hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(ProductName);

                hashCode = hashCode * -1521134295 + Price.GetHashCode();

                hashCode = hashCode * -1521134295 + Quantity.GetHashCode();

                return hashCode;

            }



            public override string ToString()

            {

                return $"OrderItem_ID: {ID} ProductName: {ProductName} Price: {Price} Quantity: {Quantity}";

            }

        }



        static void Main(string[] args)

        {

            OrderService orderService = new OrderService();

            try

            {

                for (int i = 9; i >= 0; i--)

                {

                    orderService.AddOrder(new Order(i, $"Customer{i}"));

                    for (int j = 0; j < 10; j++)

                    {

                        orderService.AddOrderItem(i, new OrderItem(j, $"Product{i}", j, j));

                    }

                }

                Console.WriteLine(orderService.GetFirst().ToString());

                orderService.SortOrder();

                Console.WriteLine(orderService.GetFirst().ToString());

                for (int i = 0; i < 11; i++) //match error

                {

                    List<OrderItem> list = orderService.FindOrderItem(i, o => o.Price < 5);

                    foreach (OrderItem orderiten in list)

                    {

                        Console.WriteLine(orderiten.ToString());

                    }

                }

            }

            catch (MatchException me)

            {

                Console.WriteLine(me.Message);

            }

            Console.ReadKey();

        }

    }

}