﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CPU.MC680x
{
	public class DEX_Inherent : Instruction, IInherent
	{
		public DEX_Inherent(CodeBlock codeBlock)
			: base(codeBlock)
		{
		}

		public override byte OpCode { get { return 0x09; } }

		public override string Mnemonic { get { return "DEX"; } }
	}
}
