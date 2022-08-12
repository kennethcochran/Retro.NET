﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CPU.MC6x09
{
	public class BIAND_Memory : Instruction, IMemory 
	{
		public override byte? PreByte { get { return 0x11; } }
		public override byte OpCode { get { return 0x31; } }

		public override string Mnemonic { get { return "BIAND"; } }
	}
}
