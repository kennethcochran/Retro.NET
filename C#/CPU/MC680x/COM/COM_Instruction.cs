﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CPU.MC680x
{
	public class COM_Instruction : Instruction
	{
		public override string Mnemonic { get { return "COM"; } }
	}
}