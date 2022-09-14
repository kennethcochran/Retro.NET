﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CPU.MC6x09
{
	public class CLRE_Inherent : Instruction, IInherent 
	{
		public CLRE_Inherent(CodeBlock codeBlock)
			: base(codeBlock)
		{
		}

		public override byte? PreByte { get { return 0x11; } }
		public override byte OpCode { get { return 0x4F; } }

		public override string Mnemonic { get { return "CLRE"; } }
	}
}
