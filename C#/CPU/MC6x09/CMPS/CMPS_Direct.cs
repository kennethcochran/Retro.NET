﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CPU.MC6x09
{
	public class CMPS_Direct : CMPS_Instruction, IDirect 
	{
		public CMPS_Direct(CodeBlock codeBlock)
			: base(codeBlock)
		{
		}

		public override byte? PreByte { get { return 0x11; } }
		public override byte OpCode { get { return 0x9C; } }
	}
}
