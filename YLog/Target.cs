﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YLog
{
	public abstract class Target
	{
		public string Name { get; set; }
		public string Type { get; set; }

		public void Write()
		{ }
	}
}