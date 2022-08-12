﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CPU.MC6x09
{
	public class ASRA_Inherent : Instruction, IInherent 
	{
		public override byte OpCode { get { return 0x47; } }

		public override string Mnemonic { get { return "ASRA"; } }
	}
}