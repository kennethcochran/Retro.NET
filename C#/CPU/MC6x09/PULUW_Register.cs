﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CPU.MC6x09
{
	public class PULUW_Register : Instruction, IRegister 
	{
		public override byte? PreByte { get { return 0x10; } }
		public override byte OpCode { get { return 0x3B; } }

		public override string Mnemonic { get { return "PULUW"; } }
	}
}
