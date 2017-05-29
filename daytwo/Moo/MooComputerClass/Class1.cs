using System;

namespace MooComputerClass
{
    public class ComputerClass
    {
	
        public void SearchInternet()  
        {  
            Console.WriteLine("Welcome");  
        }  
		public void karaoke()  
        {  
            Console.WriteLine("Let's Go! sing a song");  
        }  
		public void CodingProgram()  
        {  
            Console.WriteLine("Hello world");  
        }  
    }
	public class Laptop : ComputerClass  
    {  
        public void VideoCall()  
        {  
            Console.WriteLine("VideoCall");  
        }  
    }  
	public class PC : ComputerClass  
    {  
        public void PlayGame()  
        {  
            Console.WriteLine("PlayGame");  
        }  
    }  
	class Inheritance  
    {  
        
        static void Main(string[] args)  
        {  
  
            ComputerClass Com = new ComputerClass();  
            Com.karaoke();  
   
            Laptop Lap = new Laptop();  
            Lap.VideoCall();  
            Lap.SearchInternet();  
			
			PC myPc = new PC();  
            myPc.CodingProgram();  
            myPc.PlayGame(); 
        }  
    }  
}
