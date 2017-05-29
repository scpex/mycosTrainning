using System;

namespace MyFirstOOP
{
    public class MobilePhone
    {
		public void CallPersonMethod()
		{
			Console.WriteLine("Call to someone.");
		}
		
		public void PlayMusicMethod()
		{
			Console.WriteLine("Play Bruno Mar song.");
		}
		
		public void PlayInternetMethod()
		{
			Console.WriteLine("Search oop knowledge.");
		}
		
		public void TakeAPhotoMethod()
		{
			Console.WriteLine("Take a selfie.");
		}
		
		public void GPSMap()
		{
			Console.WriteLine("Find Coffee shop location.");
		}
		
		public class IphoneMobile : MobilePhone
		{
			public void Siri()
			{
				Console.WriteLine("Talk to me siri.");
			}
		}
		
		public class SamsungMobile : MobilePhone
		{
			public void Drawing()
			{
				Console.WriteLine("Draw Chiang Mai view.");
			}
			
		}
		
		class MyInheritance
		{
			static void Main(String[] args)
			{
				// Mobile Mother
				MobilePhone mbp = new MobilePhone();
				mbp.CallPersonMethod();
				mbp.PlayMusicMethod();
				mbp.PlayInternetMethod();
				mbp.TakeAPhotoMethod();
				mbp.GPSMap();
				
				// Iphone child
				IphoneMobile ipm = new IphoneMobile();
				ipm.PlayMusicMethod();
				ipm.TakeAPhotoMethod();
				ipm.Siri();
				
				// Samsung child
				SamsungMobile ssm = new SamsungMobile();
				ssm.CallPersonMethod();
				ssm.GPSMap();
				ssm.Drawing();
				
			}
		}
		
    }
}
