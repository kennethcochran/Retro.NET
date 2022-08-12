﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CPU.MC680x
{
	public class TSTB_Inherent : Instruction, IInherent
	{
		public override byte OpCode { get { return 0x5D; } }

		public override string Mnemonic { get { return "TSTB"; } }
	}
}