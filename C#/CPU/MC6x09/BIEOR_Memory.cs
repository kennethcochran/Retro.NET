﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CPU.MC6x09
{
	public class BIEOR_Memory : Instruction, IMemory 
	{
		public BIEOR_Memory(CodeBlock codeBlock)
			: base(codeBlock)
		{
		}

		public override byte? PreByte { get { return 0x11; } }
		public override byte OpCode { get { return 0x35; } }

		public override string Mnemonic { get { return "BIEOR"; } }
	}
}
