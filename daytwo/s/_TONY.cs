using System;
using System.Collections.Generic;
using System.Text;

namespace s

{
    public class _TONY : _INTERFACE
    {
		// student name!
        private String std_name;
        public _TONY(String name)
        {
            this.std_name = name;
        }
		
		// student id
		public String std_id()
		{ 
			return "003"; 
		}
        
		// student department
		public String std_department()
		{ 
			return "Business Management"; 
		}
		
		// student dreamjob
        public void dreamjob()
        {
            Console.WriteLine("President of the United States");
        }
    }
}
