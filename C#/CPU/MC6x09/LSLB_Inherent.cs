﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CPU.MC6x09
{
	public class LSLB_Inherent : Instruction, IInherent 
	{
		public override byte OpCode { get { return 0x58; } }

		public override string Mnemonic { get { return "LSLB"; } }
	}
}