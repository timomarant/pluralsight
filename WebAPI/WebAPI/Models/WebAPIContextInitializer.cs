using System;
using System.Collections.Generic;
using System.Data.Entity;

namespace WebAPI.Models
{
    public class WebAPIContextInitializer : DropCreateDatabaseAlways<WebAPIContext>
    {
        protected override void Seed(WebAPIContext context)
        {
            var books = new List<Book>
            {
                new Book { Author = "War And Peace", Name = "Toltsoy", Price = 12.34m },
                new Book { Author = "War And Peace", Name = "Toltsoy", Price = 12.34m },
                new Book { Author = "War And Peace", Name = "Toltsoy", Price = 12.34m },
                new Book { Author = "War And Peace", Name = "Toltsoy", Price = 12.34m },
                new Book { Author = "War And Peace", Name = "Toltsoy", Price = 12.34m },
                new Book { Author = "War And Peace", Name = "Toltsoy", Price = 12.34m },
                new Book { Author = "War And Peace", Name = "Toltsoy", Price = 12.34m },
                new Book { Author = "War And Peace", Name = "Toltsoy", Price = 12.34m },
                new Book { Author = "War And Peace", Name = "Toltsoy", Price = 12.34m },
                new Book { Author = "War And Peace", Name = "Toltsoy", Price = 12.34m },
            };
            books.ForEach(b => context.Books.Add(b));
            context.SaveChanges();

            var order = new Order { Customer = "Jon Doe", OrderDate = new DateTime(2014, 12, 1) };
            var details = new List<OrderDetail>
            {
                new OrderDetail { Book = books[0], Quantity = 1, Order = order },
                new OrderDetail { Book = books[1], Quantity = 2, Order = order },
                new OrderDetail { Book = books[2], Quantity = 3, Order = order }
            };
            context.Orders.Add(order);
            details.ForEach(o => context.OrderDetails.Add(o));
            context.SaveChanges();

            order = new Order { Customer = "Jon Smith", OrderDate = new DateTime(2014, 9, 13) };
            details = new List<OrderDetail>
            {
                new OrderDetail { Book = books[1], Quantity = 1, Order = order },
                new OrderDetail { Book = books[1], Quantity = 1, Order = order },
                new OrderDetail { Book = books[3], Quantity = 12, Order = order },
                new OrderDetail { Book = books[4], Quantity = 3, Order = order }
            };
            context.Orders.Add(order);
            details.ForEach(o => context.OrderDetails.Add(o));
            context.SaveChanges();

            order = new Order { Customer = "Ward Bell", OrderDate = new DateTime(2014, 12, 25) };
            details = new List<OrderDetail>
            {
                new OrderDetail { Book = books[2], Quantity = 1, Order = order },
                new OrderDetail { Book = books[4], Quantity = 1, Order = order },
                new OrderDetail { Book = books[3], Quantity = 1, Order = order },
                new OrderDetail { Book = books[1], Quantity = 3, Order = order }
            };
            context.Orders.Add(order);
            details.ForEach(o => context.OrderDetails.Add(o));
            context.SaveChanges();

            base.Seed(context);
        }
    }
}