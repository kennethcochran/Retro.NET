﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CPU.MC680x
{
	public class TPA_Inherent : Instruction, IInherent
	{
		public override byte OpCode { get { return 0x07; } }

		public override string Mnemonic { get { return "TPA"; } }
	}
}