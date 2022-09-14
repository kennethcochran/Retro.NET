﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CPU.MC6x09
{
	public class LSRW_Inherent : Instruction, IInherent 
	{
		public LSRW_Inherent(CodeBlock codeBlock)
			: base(codeBlock)
		{
		}

		public override byte? PreByte { get { return 0x10; } }
		public override byte OpCode { get { return 0x54; } }

		public override string Mnemonic { get { return "LSRW"; } }
	}
}
