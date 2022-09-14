﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CPU.MC6x09
{
	public class LBNE_Relative : Instruction, IRelative 
	{
		public LBNE_Relative(CodeBlock codeBlock)
			: base(codeBlock)
		{
		}

		public override byte? PreByte { get { return 0x10; } }
		public override byte OpCode { get { return 0x26; } }

		public override string Mnemonic { get { return "LBNE"; } }
	}
}
