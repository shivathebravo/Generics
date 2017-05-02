using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstConsole
{

    public class Post
    {
        public int Id { get; set; }
        public DateTime DatePublished { get; set; }
        public string Title { get; set; }   
    }

    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class BlogDBContext : DbContext
    {
        public DbSet<Post> Posts { get; set; }
    }

    public class StudentDBContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
