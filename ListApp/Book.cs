using System;
using System.Collections.Generic;
using System.Text;

namespace ListApp
{
    class Book
    {
        private static int _id=10;
        public int Id { get; set; }
        public string Name { get; set; }
        public string AuthorName { get; set; }
        public int PageCount { get; set; }
        public string Code { get; set; }
        public Book(string name,string authorname,int pagecount,string code)
        {
            _id++;
            Id = _id;
            Name = name;
            AuthorName = authorname;
            PageCount = pagecount;
            Code = code.Substring(0, 2).ToUpper() + Id;
        }
    }
}
