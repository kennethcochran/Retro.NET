﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CPU.MC680x
{
	public class BITA_Immediate : BITA_Instruction, IImmediate
	{
		public BITA_Immediate(CodeBlock codeBlock)
			: base(codeBlock)
		{
		}

		public override byte OpCode { get { return 0x85; } }
	}
}
