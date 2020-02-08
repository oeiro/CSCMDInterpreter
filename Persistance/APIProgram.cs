using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft;

namespace Persistance
{
	class APIProgram
	{
		#region Constructors
		public APIProgram(string name)
		{
			Name = name;
		}
		#endregion

		#region Methods
		public void Quit()
		{
			Running = false;
		}

		override public string ToString() 
		{
			return Name;
		}
		#endregion

		#region Properties
		public string Name { get; set; }
		public bool Running { get; set; } = true;
		#endregion
	}
}
