﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CPU.MC680x
{
	public class SEV_Inherent : Instruction, IInherent
	{
		public override byte OpCode { get { return 0x0B; } }

		public override string Mnemonic { get { return "SEV"; } }
	}
}