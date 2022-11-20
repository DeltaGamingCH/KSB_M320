namespace Assoziation
{
	internal class Hotel
	{
		static void Main(string[] args)
		{	
		}
	}
	public class Hotel
	{
		private Zimmer[] zimmer = new Zimmer[10];
		
		public Hotel()
		{
			this.zimmer = new Zimmer[10]; 
		}

		public class Reception
		{
			public string TelefonNummer { get; set; }
			public string EmailAdresse { get; set; }
		}
		

		public class Zimmer
		{
			public void AddZimmer()
			{
				this.zimmer.Add(new Zimmer());
			}
			public void AddZimmer(Zimmer zimmer)
			{
				this.zimmer.Add(zimmer);
			}

			public Zimmer()
			{
				this.bett = new Bett[2]
			}
			
			public class Bett
			{
				
			}
			public Bett(Zimmer zimmer)
			{
				zimmer.AddBett(this);
			}
		}
		

		public class Sitzungszimmer
		{
			
			public void AddBeamer(Beamer beamer); 
			{
				
			}
			public Beamer(Sitzungszimmer sitzungszimmer)
			{
				Sitzungszimmer.AddBeamer(this);
			}
		}
	}
	
}