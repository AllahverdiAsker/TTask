using System;
using System.Collections.Generic;
using System.Text;

namespace TTask
{
    class Student
    {
        public Student()
        {
            TotalCount++;
            No = TotalCount;
        }
       
        public int No  {get;}
        public string FullName;
        private  string _groupno;
        public static int TotalCount;
        public string GroupNo
            
        {

            get => _groupno;
           set
            {
                _groupno = value;
                if (_groupno.Length == 4) { 

                    for (int i = 0; i < _groupno.Length; i++)
                        
                {

                        
                        if (char.IsUpper(_groupno[0]) && char.IsDigit(_groupno[1]) && char.IsDigit(_groupno[2]) && char.IsDigit(_groupno[3])){

                            GroupNo = _groupno;
                        }
                    }
                }




            }

        }
        
      



    }
}
