﻿using System;
using System.Diagnostics.Metrics;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Transactions;
using ExerEnum.Entities;
using ExerEnum.Entities.Enums;

namespace ExerEnum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter cliente data:");
            Console.Write("Name: ");
            string nome = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Birth date (DD/MM/YYYY): ");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());
            
            Console.WriteLine("Enter order data:");
            Console.Write("Status: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());
            
            Client client = new Client(nome, email, birthDate);
            Order order = new Order(DateTime.Now, status, client);

            
            Console.WriteLine("How many items to this order?: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++) 
            {
                Console.WriteLine($"Enter #{i} item data:");
                Console.Write("Product name: ");
                string prodName = Console.ReadLine();
                Console.Write("Product price: ");
                double prodPrice = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Product product = new Product(prodName, prodPrice);
                
                Console.Write("Quantity: ");
                int prodQuantity = int.Parse(Console.ReadLine());

                OrderItem orderItem = new OrderItem(prodQuantity, prodPrice, product);

                order.AddItem(orderItem);

            }

            Console.WriteLine("ORDER SUMMARY: ");
            Console.WriteLine(order.ToString());
            




        }
    }
}
