﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CPU.MC6x09
{
	public class AIM_Indexed : AIM_Instruction, IIndexed 
	{
		public override byte OpCode { get { return 0x62; } }
	}
}
