﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CPU.MC680x
{
	public class RTS_Inherent : Instruction, IInherent
	{
		public override byte OpCode { get { return 0x39; } }

		public override string Mnemonic { get { return "RTS"; } }
	}
}