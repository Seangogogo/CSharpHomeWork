﻿using Microsoft.VisualStudio.TestTools.UnitTesting;

using static CSharpHomework6_1.OrderServiceSource;

using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;

using System.IO;



namespace CSharpHomework6_1.Tests

{

    [TestClass()]

    public class OrderServiceTests

    {

        [TestMethod()]

        [ExpectedException(typeof(NullReferenceException))]

        public void AddOrderTest1()

        {

            OrderService orderService = new OrderService();

            orderService.AddOrder(null);

        }



        [TestMethod()]

        [ExpectedException(typeof(MatchException))]

        public void AddOrderTest2()

        {

            OrderService orderService = new OrderService();

            Order order = new Order(0, "tester");

            orderService.AddOrder(order);

            orderService.AddOrder(order);

        }



        [TestMethod()]

        public void AddOrderTest3()

        {

            OrderService orderService = new OrderService();

            Order order = new Order(0, "tester");

            orderService.AddOrder(order);

            Assert.IsTrue(orderService.order_amount == 1);

        }



        [TestMethod()]

        [ExpectedException(typeof(NullReferenceException))]

        public void AddOrderItemTest1()

        {

            OrderService orderService = new OrderService();

            Order order = new Order(0, "tester");

            orderService.AddOrder(order);

            orderService.AddOrderItem(0, null);

        }



        [TestMethod()]

        [ExpectedException(typeof(MatchException))]

        public void AddOrderItemTest2()

        {

            OrderService orderService = new OrderService();

            Order order = new Order(0, "tester");

            orderService.AddOrder(order);

            OrderItem orderItem = new OrderItem(0, "test", 0, 0);

            orderService.AddOrderItem(1, orderItem);

        }



        [TestMethod()]

        [ExpectedException(typeof(MatchException))]

        public void AddOrderItemTest3()

        {

            OrderService orderService = new OrderService();

            Order order = new Order(0, "tester");

            orderService.AddOrder(order);

            OrderItem orderItem = new OrderItem(0, "test", 0, 0);

            orderService.AddOrderItem(0, orderItem);

            orderService.AddOrderItem(0, orderItem);

        }



        [TestMethod()]

        public void AddOrderItemTest4()

        {

            OrderService orderService = new OrderService();

            Order order = new Order(0, "tester");

            orderService.AddOrder(order);

            OrderItem orderItem = new OrderItem(0, "test", 0, 0);

            orderService.AddOrderItem(0, orderItem);

            Assert.IsTrue(orderService.GetFirst().orderitems.Count == 1);

        }



        [TestMethod()]

        [ExpectedException(typeof(MatchException))]

        public void DeleteOrderTest1()

        {

            OrderService orderService = new OrderService();

            Order order = new Order(0, "tester");

            orderService.AddOrder(order);

            orderService.DeleteOrder(1);

        }



        [TestMethod()]

        public void DeleteOrderTest2()

        {

            OrderService orderService = new OrderService();

            Order order = new Order(0, "tester");

            orderService.AddOrder(order);

            orderService.DeleteOrder(0);

            Assert.IsTrue(orderService.order_amount == 0);

        }



        [TestMethod()]

        [ExpectedException(typeof(MatchException))]

        public void DeleteOrderItemTest1()

        {

            OrderService orderService = new OrderService();

            Order order = new Order(0, "tester");

            orderService.AddOrder(order);

            OrderItem orderItem = new OrderItem(0, "test", 0, 0);

            orderService.AddOrderItem(0, orderItem);

            orderService.DeleteOrderItem(1, 0);

        }



        [TestMethod()]

        [ExpectedException(typeof(MatchException))]

        public void DeleteOrderItemTest2()

        {

            OrderService orderService = new OrderService();

            Order order = new Order(0, "tester");

            orderService.AddOrder(order);

            OrderItem orderItem = new OrderItem(0, "test", 0, 0);

            orderService.AddOrderItem(0, orderItem);

            orderService.DeleteOrderItem(0, 1);

        }



        [TestMethod()]

        [ExpectedException(typeof(MatchException))]

        public void UpdateOrderTest1()

        {

            OrderService orderService = new OrderService();

            Order order_1 = new Order(0, "tester");

            Order order_2 = new Order(1, "tester");

            orderService.AddOrder(order_1);

            OrderItem orderItem_1 = new OrderItem(0, "test", 0, 0);

            OrderItem orderItem_2 = new OrderItem(1, "test", 1, 1);

            orderService.AddOrderItem(0, orderItem_1);

            orderService.UpdateOrder(1, order_2);

        }



        [TestMethod()]

        [ExpectedException(typeof(MatchException))]

        public void UpdateOrderTest2()

        {

            OrderService orderService = new OrderService();

            Order order_1 = new Order(0, "tester");

            Order order_2 = new Order(1, "tester");

            orderService.AddOrder(order_1);

            orderService.AddOrder(order_2);

            OrderItem orderItem_1 = new OrderItem(0, "test", 0, 0);

            OrderItem orderItem_2 = new OrderItem(1, "test", 1, 1);

            orderService.AddOrderItem(0, orderItem_1);

            orderService.UpdateOrder(0, order_2);

        }



        [TestMethod()]

        [ExpectedException(typeof(MatchException))]

        public void UpdateOrderItemTest1()

        {

            OrderService orderService = new OrderService();

            Order order = new Order(0, "tester");

            orderService.AddOrder(order);

            OrderItem orderItem_1 = new OrderItem(0, "test", 0, 0);

            OrderItem orderItem_2 = new OrderItem(1, "test", 1, 1);

            orderService.AddOrderItem(0, orderItem_1);

            orderService.UpdateOrderItem(1, 0, orderItem_2);

        }



        [TestMethod()]

        [ExpectedException(typeof(MatchException))]

        public void UpdateOrderItemTest2()

        {

            OrderService orderService = new OrderService();

            Order order = new Order(0, "tester");

            orderService.AddOrder(order);

            OrderItem orderItem_1 = new OrderItem(0, "test", 0, 0);

            OrderItem orderItem_2 = new OrderItem(1, "test", 1, 1);

            orderService.AddOrderItem(0, orderItem_1);

            orderService.UpdateOrderItem(0, 1, orderItem_2);

        }



        [TestMethod()]

        [ExpectedException(typeof(MatchException))]

        public void UpdateOrderItemTest3()

        {

            OrderService orderService = new OrderService();

            Order order = new Order(0, "tester");

            orderService.AddOrder(order);

            OrderItem orderItem_1 = new OrderItem(0, "test", 0, 0);

            OrderItem orderItem_2 = new OrderItem(1, "test", 1, 1);

            orderService.AddOrderItem(0, orderItem_1);

            orderService.AddOrderItem(0, orderItem_2);

            orderService.UpdateOrderItem(0, 0, orderItem_2);

        }



        [TestMethod()]

        public void FindOrderTest1()

        {

            OrderService orderService = new OrderService();

            Order order_0 = new Order(0, "tester");

            orderService.AddOrder(order_0);

            Order order_1 = orderService.FindOrder(0);

            Assert.AreEqual(order_0, order_1);

        }



        [TestMethod()]

        [ExpectedException(typeof(MatchException))]

        public void FindOrderTest2()

        {

            OrderService orderService = new OrderService();

            Order order_0 = new Order(0, "tester");

            orderService.AddOrder(order_0);

            Order order_1 = orderService.FindOrder(1);

        }



        [TestMethod()]

        public void FindOrderTest3()

        {

            OrderService orderService = new OrderService();

            Order order_0 = new Order(0, "tester");

            Order order_1 = new Order(1, "tester");

            Order order_2 = new Order(2, "tester");

            orderService.AddOrder(order_0);

            orderService.AddOrder(order_1);

            orderService.AddOrder(order_2);

            List<Order> orders = orderService.FindOrder("tester");

            Assert.IsTrue(orders.Count == 3);

        }



        [TestMethod()]

        public void FindOrderTest4()

        {

            OrderService orderService = new OrderService();

            Order order_0 = new Order(0, "tester");

            orderService.AddOrder(order_0);

            List<Order> orders = orderService.FindOrder("tester_0");

            Assert.IsTrue(orders.Count == 0);

        }



        [TestMethod()]

        public void FindOrderTest5()

        {

            OrderService orderService = new OrderService();

            Order order_0 = new Order(0, "tester");

            Order order_1 = new Order(1, "tester");

            Order order_2 = new Order(2, "tester");

            OrderItem orderItem_0 = new OrderItem(0, "test", 0, 0);

            OrderItem orderItem_1 = new OrderItem(0, "test", 1, 1);

            OrderItem orderItem_2 = new OrderItem(0, "test", 2, 2);

            orderService.AddOrder(order_0);

            orderService.AddOrder(order_1);

            orderService.AddOrder(order_2);

            orderService.AddOrderItem(0, orderItem_0);

            orderService.AddOrderItem(1, orderItem_1);

            orderService.AddOrderItem(2, orderItem_2);

            List<Order> orders = orderService.FindOrder(o => o.TotalPrice > 0);

            Assert.IsTrue(orders.Count == 2);

        }



        [TestMethod()]

        public void FindOrderItemTest1()

        {

            OrderService orderService = new OrderService();

            Order order = new Order(0, "tester");

            OrderItem orderItem_0 = new OrderItem(0, "test", 0, 0);

            orderService.AddOrder(order);

            orderService.AddOrderItem(0, orderItem_0);

            OrderItem orderItem_1 = orderService.FindOrderItem(0, 0);

            Assert.AreEqual(orderItem_0, orderItem_1);

        }



        [TestMethod()]

        [ExpectedException(typeof(MatchException))]

        public void FindOrderItemTest2()

        {

            OrderService orderService = new OrderService();

            Order order = new Order(0, "tester");

            OrderItem orderItem = new OrderItem(0, "test", 0, 0);

            orderService.AddOrder(order);

            orderService.AddOrderItem(0, orderItem);

            orderService.FindOrderItem(1, 0);

        }



        [TestMethod()]

        [ExpectedException(typeof(MatchException))]

        public void FindOrderItemTest3()

        {

            OrderService orderService = new OrderService();

            Order order = new Order(0, "tester");

            OrderItem orderItem = new OrderItem(0, "test", 0, 0);

            orderService.AddOrder(order);

            orderService.AddOrderItem(0, orderItem);

            orderService.FindOrderItem(0, 1);

        }



        [TestMethod()]

        public void FindOrderItemTest4()

        {

            OrderService orderService = new OrderService();

            Order order_0 = new Order(0, "tester");

            OrderItem orderItem_0 = new OrderItem(0, "test", 0, 0);

            OrderItem orderItem_1 = new OrderItem(1, "test", 1, 1);

            OrderItem orderItem_2 = new OrderItem(2, "test", 2, 2);

            orderService.AddOrder(order_0);

            orderService.AddOrderItem(0, orderItem_0);

            orderService.AddOrderItem(0, orderItem_1);

            orderService.AddOrderItem(0, orderItem_2);

            List<OrderItem> orderItems = orderService.FindOrderItem(0, "test");

            Assert.IsTrue(orderItems.Count == 3);

        }



        [TestMethod()]

        public void FindOrderItemTest5()

        {

            OrderService orderService = new OrderService();

            Order order_0 = new Order(0, "tester");

            OrderItem orderItem_0 = new OrderItem(0, "test", 0, 0);

            OrderItem orderItem_1 = new OrderItem(1, "test", 1, 1);

            OrderItem orderItem_2 = new OrderItem(2, "test", 2, 2);

            orderService.AddOrder(order_0);

            orderService.AddOrderItem(0, orderItem_0);

            orderService.AddOrderItem(0, orderItem_1);

            orderService.AddOrderItem(0, orderItem_2);

            List<OrderItem> orderItems = orderService.FindOrderItem(0, "test_0");

            Assert.IsTrue(orderItems.Count == 0);

        }



        [TestMethod()]

        public void FindOrderItemTest6()

        {

            OrderService orderService = new OrderService();

            Order order_0 = new Order(0, "tester");

            OrderItem orderItem_0 = new OrderItem(0, "test", 0, 0);

            OrderItem orderItem_1 = new OrderItem(1, "test", 1, 1);

            OrderItem orderItem_2 = new OrderItem(2, "test", 2, 2);

            orderService.AddOrder(order_0);

            orderService.AddOrderItem(0, orderItem_0);

            orderService.AddOrderItem(0, orderItem_1);

            orderService.AddOrderItem(0, orderItem_2);

            List<OrderItem> orderItems = orderService.FindOrderItem(0, o => o.Quantity > 0);

            Assert.IsTrue(orderItems.Count == 2);

        }



        [TestMethod()]

        public void SortOrderTest1()

        {

            OrderService orderService = new OrderService();

            for (int i = 10; i > 0; i--)

            {

                orderService.AddOrder(new Order(i, "tester" + i));

            }

            orderService.SortOrder();

            Assert.IsTrue(orderService.GetFirst().ID == 1);

        }



        [TestMethod()]

        public void SortOrderTest2()

        {

            OrderService orderService = new OrderService();

            for (int i = 10; i > 0; i--)

            {

                orderService.AddOrder(new Order(i, "tester" + i));

                orderService.AddOrderItem(i, new OrderItem(i, "test" + i, i, i));

            }

            orderService.SortOrder((o1, o2) =>

            {

                if (o1.TotalPrice < o2.TotalPrice)

                {

                    return -1;

                }

                if (o1.TotalPrice > o2.TotalPrice)

                {

                    return 1;

                }

                return 0;

            });

            Assert.IsTrue(orderService.GetFirst().ID == 1);

        }



        [TestMethod()]

        public void GetFirstTest1()

        {

            OrderService orderService = new OrderService();

            Order order = new Order(0, "tester");

            orderService.AddOrder(order);

            Assert.AreEqual(order, orderService.GetFirst());

        }



        [TestMethod()]

        public void GetFirstTest2()

        {

            OrderService orderService = new OrderService();

            Assert.AreEqual(null, orderService.GetFirst());

        }



        [TestMethod()]

        public void ExportTest1()

        {

            OrderService orderService = new OrderService();

            Order order = new Order(0, "tester");

            orderService.AddOrder(order);

            OrderItem orderItem = new OrderItem(0, "test", 0, 0);

            orderService.AddOrderItem(0, orderItem);

            orderService.Export("OrderList");

            if (File.Exists("OrderList.xml"))

            {

                OrderService orderService_1 = new OrderService();

                orderService_1.Import("OrderList.xml");

                Assert.AreEqual(order, orderService_1.GetFirst());

            }

            else

            {

                Assert.Fail();

            }

        }



        [TestMethod()]

        public void ExportTest2()

        {

            OrderService orderService = new OrderService();

            Order order = new Order(0, "tester");

            orderService.AddOrder(order);

            OrderItem orderItem = new OrderItem(0, "test", 0, 0);

            orderService.AddOrderItem(0, orderItem);

            orderService.Export();

            if (File.Exists("OrderList.xml"))

            {

                OrderService orderService_1 = new OrderService();

                orderService_1.Import("OrderList.xml");

                Assert.AreEqual(order, orderService_1.GetFirst());

            }

            else

            {

                Assert.Fail();

            }

        }



        [TestMethod()]

        public void ImportTest()

        {

            OrderService orderService = new OrderService();

            Order order = new Order(0, "tester");

            orderService.AddOrder(order);

            OrderItem orderItem = new OrderItem(0, "test", 0, 0);

            orderService.AddOrderItem(0, orderItem);

            orderService.Export();

            if (File.Exists("OrderList.xml"))

            {

                OrderService orderService_1 = new OrderService();

                orderService_1.Import("OrderList.xml");

                Assert.AreEqual(order, orderService_1.GetFirst());

            }

            else

            {

                Assert.Fail();

            }

        }

    }

}