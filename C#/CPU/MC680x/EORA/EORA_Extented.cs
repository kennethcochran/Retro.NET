﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CPU.MC680x
{
	public class EORA_Extended : EORA_Instruction, IExtended
	{
		public EORA_Extended(CodeBlock codeBlock)
			: base(codeBlock)
		{
		}

		public override byte OpCode { get { return 0xB8; } }
	}
}
