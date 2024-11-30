using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace BiblWorm.Bibl
{
    internal class Book : Item
    {
        public string author { get; set; }
        public string publishHouse { get; set; }
        public int year { get; set; }
        public int pages { get; set; }
        
        public Book(string title, string author, string publishHouse, int pages, int year, int invNumber, bool available)
        {
            this.title = title;
            this.author = author;
            this.publishHouse = publishHouse;
            this.pages = pages;
            this.year = year;
            this.invNumber = invNumber;
            this.available = available;
        }

        public override string DisplayInfo()
        {
            return $"Title: {title}, Author: {author}, PublishHouse: {publishHouse}, Pages: {pages}, Year: {year}, Inventory Number: {invNumber}, Available: {available}";
        }
    }
}
