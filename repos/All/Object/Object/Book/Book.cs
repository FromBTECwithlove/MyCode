using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object.Book
{
    public class Book
    {
        string title;
        string author;
        string publisher;
        int quantity;
        float price;
        int copiesSold;
        string id;
        public Book()
        {

        }
        public Book(string id,string title,string author, string publisher, int quantity,float price, int copiesSold)
        {
            this.id = id; 
            this.title = title;
            this.author = author;
            this.publisher = publisher;
            this.quantity = quantity;
            this.price = price;
            this.copiesSold = copiesSold;
        }

        internal void add()
        {
            throw new NotImplementedException();
        }

        public string getId()
        {
            return id;
        }
        public void setId(string id)
        {
            this.id = id;
        }
        public void setTitle(string title)
        {
            this.title = title;
        }
        public void setAuthor(string author)
        {
            this.author = author;
        }
        public void setPublisher(string publisher)
        {
            this.publisher = publisher;
        }
        public void setQuantity(int quantity)
        {
            this.quantity = quantity;
        }
        public void setPrice(float price)
        {
            this.price = price;
        }
        public void setCopiesSold(int copiesSold)
        {
            this.copiesSold = copiesSold;
        }
        public string getTitle()
        {
            return title;
        }
        public string getAuthor()
        {
            return author;
        }
        public string getPublisher()
        {
            return publisher;
        }
        public int getQuantity()
        {
            return quantity;
        }
        public float getPrice()
        {
            return price;
        }
        public int getCopiesSold()
        {
            return copiesSold;
        }
        public void EnterInforOfBook()
        {
            Console.Write("Enter title of book:       ");
            title = Console.ReadLine();
            Console.Write("Enter author of book:      ");
            author = Console.ReadLine();
            Console.Write("Enter publisher of book:   ");
            publisher = Console.ReadLine();
            Console.Write("Enter quantity of book:    ");
            quantity = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter price of book:       ");
            price = float.Parse(Console.ReadLine());
            Console.Write("Enter copies sold of book: ");
            copiesSold = Convert.ToInt32(Console.ReadLine());
            Console.Write("");
        }
        public string toString()
        {
            return "Title:"+this.title+"--Author:"+this.author+"--Publisher:"+this.publisher
                +"--Quantity:"+this.quantity+"--Price:"+this.price+"--Copies Sold:"+this.copiesSold;
        }
        public void Display()
        {
            Console.Write("");
            Console.Write("");
            Console.Write("");
            Console.Write("");
            Console.Write("");
            Console.Write("");
            Console.Write("");
        }
    }
}
