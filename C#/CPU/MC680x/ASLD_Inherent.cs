﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CPU.MC680x
{
	public class ASLD_Inherent : Instruction, IInherent
	{
		public ASLD_Inherent(CodeBlock codeBlock)
			: base(codeBlock)
		{
		}

		public override byte OpCode { get { return 0x05; } }

		public override string Mnemonic { get { return "ASLD"; } }
	}
}
