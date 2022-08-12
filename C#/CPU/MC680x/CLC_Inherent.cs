﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CPU.MC680x
{
	public class CLC_Inherent : Instruction, IInherent
	{
		public override byte OpCode { get { return 0x0C; } }

		public override string Mnemonic { get { return "CLC"; } }
	}
}
