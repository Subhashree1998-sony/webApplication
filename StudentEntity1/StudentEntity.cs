using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using entity;

namespace entity
{
    [Table("student")]
    public class studentEntity
    {
        [Key]
        public int rollno { get; set; }
        public string name { get; set; }
        public string Emailid { get; set;}
        }
    }


