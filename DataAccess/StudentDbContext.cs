using entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess
{
    public class StudentDbContext : DbContext
    {
        public DbSet<studentEntity> studentEntity { get; set; }

        public StudentDbContext(DbContextOptions<StudentDbContext> options): base(options)
        {

        }
    }
}
