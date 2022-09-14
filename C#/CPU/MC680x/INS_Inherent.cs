﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CPU.MC680x
{
	public class INS_Inherent : Instruction, IInherent
	{
		public INS_Inherent(CodeBlock codeBlock)
			: base(codeBlock)
		{
		}

		public override byte OpCode { get { return 0x31; } }

		public override string Mnemonic { get { return "INS"; } }
	}
}
