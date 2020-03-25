using System;
using System.Collections.Generic;
using System.Text;



//Hvordan kan man få fat i et tyggegummi her? Burde maskinen ikke kunne levere et tyggegummi til det stakkels lille barn der gerne vil have et?
//Flot du har brug singletom

namespace TyggegumiMaskine
{
    public class GumMachine
    {
		private static GumMachine instance;

		private bool dispenserempty;

		public bool DispenserEmpty
		{
			get { return dispenserempty; }
			set { dispenserempty = value; }
		}

		private double redgum;

		public double RedGum
		{
			get { return redgum; }
			set { redgum = value; }
		}

		private double bluegum;

		public double BlueGum
		{
			get { return bluegum; }
			set { bluegum = value; }
		}

		private double greengum;

		public double GreenGum
		{
			get { return greengum; }
			set { greengum = value; }
		}

		private double yellowgum;

		public double YellowGum
		{
			get { return yellowgum; }
			set { yellowgum = value; }
		}

		private double purplegum;

		public double PurpleGum
		{
			get { return purplegum; }
			set { purplegum = value; }
		}

		private double orangegum;

		public double OrangeGum
		{
			get { return orangegum; }
			set { orangegum = value; }
		}


		private GumMachine()
		{
			redgum = 7.7;
			greengum = 5.5;
			bluegum = 13.75;
			orangegum = 10.45;
			purplegum = 6.6;
			yellowgum = 11;
		}

		public static GumMachine Instance
		{
			get
			{
				if (instance == null)
				{
					instance = new GumMachine();
				}
				return instance;
			}
		}


		/// <summary>
		/// Method to register if the machine is empty
		/// </summary>
		public void RegEmpty()
		{
			double temp = redgum + greengum + bluegum + orangegum + purplegum + yellowgum;

			if (temp <= 0)
			{
				dispenserempty = true;
			}
		}


		/// <summary>
		/// method to refill the machine
		/// </summary>
		public void Refill()
		{
			redgum = 7.7;
			greengum = 5.5;
			bluegum = 13.75;
			orangegum = 10.45;
			purplegum = 6.6;
			yellowgum = 11;
			dispenserempty = false;
		}
	}
}
