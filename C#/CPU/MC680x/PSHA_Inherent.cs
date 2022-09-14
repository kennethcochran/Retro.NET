﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CPU.MC680x
{
	public class PSHA_Inherent : Instruction, IInherent
	{
		public PSHA_Inherent(CodeBlock codeBlock)
			: base(codeBlock)
		{
		}

		public override byte OpCode { get { return 0x36; } }

		public override string Mnemonic { get { return "PSHA"; } }
	}
}
