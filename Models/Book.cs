using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Atelier.Models
{
    internal class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }

        private static int _id;

        public Book(string title)
        {
            _id++;
            Id = _id;
            Title = title;
        }
    }

}
