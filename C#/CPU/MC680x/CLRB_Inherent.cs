﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CPU.MC680x
{
	public class CLRB_Inherent : Instruction, IInherent
	{
		public override byte OpCode { get { return 0x5F; } }

		public override string Mnemonic { get { return "CLRB"; } }
	}
}
