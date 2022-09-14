﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CPU.MC680x
{
	public class CMPB_Immediate : CMPB_Instruction, IImmediate
	{
		public CMPB_Immediate(CodeBlock codeBlock)
			: base(codeBlock)
		{
		}

		public override byte OpCode { get { return 0xC1; } }
	}
}
