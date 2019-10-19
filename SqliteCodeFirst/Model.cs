using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace SqliteCodeFirst
{
    class Model
    {
        public class ClassContext : DbContext
        {
            public DbSet<Instructor> Instructors { get; set; }
            public DbSet<Class> Classes { get; set; }
            protected override void OnConfiguring(DbContextOptionsBuilder options)
                => options.UseSqlite("Data Source=C:\\Users\\Minghui Wang\\source\\repos\\SqliteCodeFirst\\SqliteCodeFirst\\classes.db");
        }

        public class Instructor
        {
            [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
            public string InstructorId { get; set; }
            public string Name { get; set; }
            public List<Class> Classes { get; } = new List<Class>();
        }

        public class Class
        {
            [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
            public int ClassId { get; set; }
            public string Title { get; set; }
            public string InstructorId { get; set; }
            public Instructor Instructor { get; set; }
        }

    }
}
