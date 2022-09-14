﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CPU.MC680x
{
	public class STAB_Extended : STAB_Instruction, IExtended
	{
		public STAB_Extended(CodeBlock codeBlock)
			: base(codeBlock)
		{
		}

		public override byte OpCode { get { return 0xF7; } }
	}
}
