﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CPU.MC680x
{
	public class SUBB_Direct : SUBB_Instruction, IDirect
	{
		public SUBB_Direct(CodeBlock codeBlock)
			: base(codeBlock)
		{
		}

		public override byte OpCode { get { return 0xD0; } }
	}
}
