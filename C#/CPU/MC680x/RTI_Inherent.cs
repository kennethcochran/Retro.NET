﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CPU.MC680x
{
	public class RTI_Inherent : Instruction, IInherent
	{
		public override byte OpCode { get { return 0x3B; } }

		public override string Mnemonic { get { return "RTI"; } }
	}
}
