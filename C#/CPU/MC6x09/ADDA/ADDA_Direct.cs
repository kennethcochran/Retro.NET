﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CPU.MC6x09
{
	public class ADDA_Direct : ADDA_Instruction, IDirect 
	{
		public override byte OpCode { get { return 0x9B; } }
	}
}
