﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CPU.MC6x09
{
	public class CMPF_Immediate : CMPF_Instruction, IImmediate 
	{
		public CMPF_Immediate(CodeBlock codeBlock)
			: base(codeBlock)
		{
		}

		public override byte? PreByte { get { return 0x11; } }
		public override byte OpCode { get { return 0xC1; } }
	}
}
