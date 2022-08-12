﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CPU.MC680x
{
	public class TAP_Inherent : Instruction, IInherent
	{
		public override byte OpCode { get { return 0x06; } }

		public override string Mnemonic { get { return "TAP"; } }
	}
}