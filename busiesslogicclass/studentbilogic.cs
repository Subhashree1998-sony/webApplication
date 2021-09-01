 using System;
 using System.Collections.Generic;

 using entity;

 namespace businesslogicclass
{
    public class studentbilogic
    {

        //studentEntity Entityobj = new studentEntity();
        //int? a = null;
       // TeacherEntity Entityobj = new TeacherEntity();
        List<studentEntity> entityList = new List<studentEntity>
        {
            new studentEntity{name="Tom", rollno=4},
            new studentEntity{name="jerry", rollno=5},
            new studentEntity{name="Ronaldo", rollno=6},
        };


        
            public studentEntity getfilteredstudentrecord(int rollno)
        {
            for(int i=0; i<entityList.Count;i++)
            {
                if(entityList[i].rollno==rollno)
                {
                    return  entityList[i];
                }
            }
            return null;
        }


    }
}
