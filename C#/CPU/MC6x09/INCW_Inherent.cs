﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CPU.MC6x09
{
	public class INCW_Inherent : Instruction, IInherent 
	{
		public INCW_Inherent(CodeBlock codeBlock)
			: base(codeBlock)
		{
		}

		public override byte? PreByte { get { return 0x10; } }
		public override byte OpCode { get { return 0x5C; } }

		public override string Mnemonic { get { return "INCW"; } }
	}
}
