﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CPU.MC680x
{
	public class JSR_Direct : JSR_Instruction, IDirect
	{
		public override byte OpCode { get { return 0x9D; } }
	}
}