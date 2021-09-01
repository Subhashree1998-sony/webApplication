using System;
using System.Collections.Generic;
using System.Linq;
using DataAccess;
using entity;

namespace businesslogic
{
    public class Bilogic1 : IBusinesslogic
    {

        //studentEntity Entityobj = new studentEntity();
        //int? a = null;
        // TeacherEntity Entityobj = new TeacherEntity();
        List<studentEntity> entityList = new List<studentEntity>();
        //{
        //    new studentEntity{name="Tom", rollno=4, Emailid="sony123@gmail.com"},
        //    new studentEntity{name="jerry", rollno=5, Emailid="rony123@gmail.com"},
        //    new studentEntity{name="Ronaldo", rollno=6, Emailid="dony123@gmail.com"},
        //    new studentEntity{name="Ronali", rollno=7, Emailid="rona123@gmail.com"},
        //    new studentEntity{name="Ravi", rollno=8, Emailid="ravi123@gmail.com"},
        //    new studentEntity{name="sanjay", rollno=9, Emailid="sanju123@gmail.com"},
        //};
        StudentDbContext dbctx;
        public Bilogic1()
        {
            //dbctx = cdb;
        }
        public Bilogic1(StudentDbContext cdb)
        {
            dbctx = cdb;
        }
        public int AddTwoNumber(int a, int b)
        {
            return a + b;
        }

        public studentEntity getfilteredstudentrecord(int rollno)
        {
            var studentList = entityList.Find(x => x.rollno == rollno);
           
            return studentList;
        }

        public studentEntity getfilteredstudentrecordbyname(string name)
        {
            for(int i=0; i<entityList.Count;i++)
            {
                if (entityList[i].name.ToUpper().Contains(name.ToUpper()) ==true)
                   return entityList[i];

            }
            return null;

       }
        public bool SaveStudentRecord(studentEntity stdEntity)
        {
            entityList.Add(stdEntity);
            dbctx.SaveChanges();
            return true;

        }
        public studentEntity getRandomStudent()
        {
            entityList = dbctx.studentEntity.ToList();
           int num = new  Random().Next(0,entityList.Count-1);

           return entityList[num];
        }


    }
}
