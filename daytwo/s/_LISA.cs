using System;
using System.Collections.Generic;
using System.Text;

namespace s

{
    public class _LISA : _INTERFACE
    {
		// student name!
        private String std_name;
        public _LISA(String name)
        {
            this.std_name = name;
        }
		
		// student id
		public String std_id()
		{ 
			return "002"; 
		}
        
		// student department
		public String std_department()
		{ 
			return "Philosophy"; 
		}
		
		// student dreamjob
        public void dreamjob()
        {
            Console.WriteLine("Farmer");
        }
    }
}
