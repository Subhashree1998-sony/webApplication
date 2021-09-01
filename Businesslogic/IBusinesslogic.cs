using entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace businesslogic
{
   public interface IBusinesslogic
    {
        public studentEntity getfilteredstudentrecord(int rollno);
        public studentEntity getfilteredstudentrecordbyname(string name);
         public bool SaveStudentRecord(studentEntity stdEntity);
         public studentEntity getRandomStudent();
        


    }
}
