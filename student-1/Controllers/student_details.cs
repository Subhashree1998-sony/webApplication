using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace student_1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class student_details : ControllerBase
    {
        public string first { get; set; }
        public string last { get; set; }
        public List<int> marks;
        public contactinfo Getcontactinfo(programs pg, int id)
        {
            Getcontactinfo allinfo = (From  ci in pg.contactlist where ci.ID == id
                select ci)
                .firstordefault();
            return allinfo;
        }
        public override string ToString()
        {
            return first + "" + last + ":" + ID;

        }
    }
    public class contactinfo
    {
        public int ID { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
        public override string ToString() { return email + "," + phone; }
    }
    public class scoreinfo
    {
        public double average { get; set; }
        public int ID { get; set; }
    }
    list<student_1> students = new list<student_1>()
    {
        new student_1 { first = "rahul", last = "jha", ID = 1, marks = new List<int>() { 45, 65, 87, 34 } }
        new student_1 { first = "jerry", last = "m", ID = 2, marks = new List<int>() { 95, 65, 80, 78 } }

        new student_1 { first = "abhi", last = "sukla", ID = 3, marks = new List<int>() { 76, 95, 85, 39 } }

        new student_1 { first = "tom", last = "g", ID = 4, marks = new List<int>() { 65, 69, 84, 60 } },
    };
    list<contactinfo> contactlist = new list<contactinfo>()
    {
        new contactinfo { ID = 111, email = "rahul@.com", phone = "6736437498" },
        new contactinfo { ID = 112, email = "jerryl@.com", phone = "674354898" },
        new contactinfo { ID = 113, email = "abhi@.com", phone = "6908749809" },
        new contactinfo { ID = 114, email = "tom@.com", phone = "6591605108" }
    };
    static void main(string[] args)
    {
        Program pg = new programs();
        IEnumerable<student> studentquery1 =
            from student in pg.students
            where student.ID > 1
            select student;
        Console.WriteLine("query: select range_variable");
        Console.WriteLine("name :ID");
        foreach (student_1 s in studentquery1)
        {
            Console.WriteLine(s.tostring());
        }
        Console.ReadLine();

    }
}








