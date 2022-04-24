using System;
using System.Collections.Generic;

namespace HappyPet.Data.Models
{
    public class Article
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ShortContent { get; set; }
        public List<string> Pictures { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }
        public DateTime CreationTime { get; set; }
    }
}
