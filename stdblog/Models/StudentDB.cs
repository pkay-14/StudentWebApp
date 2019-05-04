using stdblog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace stdblog
{
    public class StudentDB
    {
        public StudentDB()
        {

        }
        public StudentDB(blogpost rows)
        {
            id = rows.id;
            title = rows.title;
            author = rows.author;
            datemodified = rows.datemodified;
            content = rows.content;
            postimage = rows.postimage;
        }

        public int id { get; set; }
        public string title { get; set; }
        public string author { get; set; }
        public Nullable<System.DateTime> datemodified { get; set; }
        public string content { get; set; }
        public byte[] postimage { get; set; }
    }
}