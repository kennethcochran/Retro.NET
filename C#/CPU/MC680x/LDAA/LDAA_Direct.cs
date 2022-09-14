﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CPU.MC680x
{
	public class LDAA_Direct : LDAA_Instruction, IDirect
	{
		public LDAA_Direct(CodeBlock codeBlock)
			: base(codeBlock)
		{
		}

		public override byte OpCode { get { return 0x96; } }
	}
}
