﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CPU.MC6x09
{
	public class JMP_Direct : JMP_Instruction, IDirect 
	{
		public override byte OpCode { get { return 0x0E; } }
	}
}