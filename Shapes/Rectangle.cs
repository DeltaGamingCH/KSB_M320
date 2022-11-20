using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
	public class Rectangle
	{
		// Ein Feld mit einem für Felder typischen Zugriffsmodifizierer
		private string name = "Black Rectangle";
		private int width = 10;
		private int height = 10;
		private int radius = 6;

		// Konstruktoren
		public Rectangle(string name, int width, int height, int radius)
		{
			this.name = name;
			this.width = width;
			this.height = height;
			this.radius = radius;
		}

		public Rectangle(Color color) : this(color.Name + " Rectangle", 10, 10, 10)
		{
			this.color = color;
		}

		public Rectangle(int width, int height)
		{
			this.width = width;
			this.height = height;
		}

		// Ein Feld, dessen Wert während der Lebensdauer eines Objekts nicht verändert werden kann.
		private readonly int area;

		// Ein Feld, für welches ein Standardwert zugewiesen wird
		private Color color = System.Drawing.Color.Black;

		// Eine selber implementierte, read-only Eigenschaft.
		public int Area
		{
			get { return width * height; }
		}

		// Eine selber implementierte, read-write Eigenschaft
		public string Name
		{
			get { return name; }
			set { name = value; }
		}
		// Eine selber implementierte, write-only Eigenschaft
		public int Radius
		{
			private get { return radius; }
			set { radius = value; }
		}

		// Eine automatisch implementierte, read-only Eigenschaft.

		public int Top { get; }
		public int Bottom { get; }

		// Eine automatisch implementierte, read-write Eigenschaft
		public string Color { get; set; }

		// Eine automatisch implementierte, write-only Eigenschaft
		public bool Enabled { private get; set; }

		// Zwei verschiedene Eigenschaften mit jeweils unterschiedlicher Anwendung der expression body Schreibweise.
		public bool IsEven
		{
			get { return width % 2 == 0 && height % 2 == 0; }
			set { width = 10; height = 10; }
		}

		public string RadiusAsString
		{
			get => $"Radius: {radius}";
			set => radius = int.Parse(value);
		}

		public String SizeAsString
		{
			get { return $"Width: {width} | Height: {height}"; }
			set
			{
				string[] sizes = value.Split('|');
				int start1 = sizes[0].IndexOf(':') + 1;
				int end1 = sizes[0].Length - 1;
				width = int.Parse(value.Substring(start1, end1));

				int start2 = sizes[0].IndexOf(':') + 1;
				int end2 = sizes[0].Length;
				height = int.Parse(value.Substring(start2, end2));
			}
		}

	}
}