﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CPU.MC680x
{
	public class SUBB_Indexed : SUBB_Instruction, IIndexed
	{
		public SUBB_Indexed(CodeBlock codeBlock)
			: base(codeBlock)
		{
		}

		public override byte OpCode { get { return 0xE0; } }
	}
}
