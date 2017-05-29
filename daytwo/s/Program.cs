using System;
using System.Collections.Generic;

namespace s

{
    public class Program
    {
		static void Main(string[] args)
        {
            // Show student data
			List<Istudent> Istd = new List<Istudent>();
			
			_JOHN stdname = new _JOHN("John");
            Istd.Add(stdname);
			
			_LISA stdname = new _LISA("Lisa");
            Istd.Add(stdname);
			
			_TONY stdname = new _TONY("Tony");
            Istd.Add(stdname);
			
            foreach (var std in Istd)
                std.std_id();
				std.std_department();
				std.dreamjob();
        }
    }
}
