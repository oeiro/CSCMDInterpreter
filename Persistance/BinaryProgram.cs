using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistance // TODO Read bytes from file
{
	class BinaryProgram : APIProgram
	{
		#region Constructors
		public BinaryProgram(string name) : base(name)
		{

		}
		#endregion

		#region Properties
		public List<byte> Buffer { get; } = new List<byte>();
		public byte pc { get; set; }
		#endregion
	}
}
