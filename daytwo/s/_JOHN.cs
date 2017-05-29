using System;
using System.Collections.Generic;
using System.Text;

namespace s

{
    public class _JOHN : _INTERFACE
    {
		// student name!
        private String std_name;
        public _JOHN(String name)
        {
            this.std_name = name;
        }
		
		// student id
		public String std_id()
		{ 
			return "001"; 
		}
        
		// student department
		public String std_department()
		{ 
			return "Electrical Engineering"; 
		}
		
		// student dreamjob
        public void dreamjob()
        {
            Console.WriteLine("Engineer");
        }
    }
}
