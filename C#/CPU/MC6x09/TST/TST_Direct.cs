﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CPU.MC6x09
{
	public class TST_Direct : TST_Instruction, IDirect 
	{
		public override byte OpCode { get { return 0x0D; } }
	}
}
