﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CPU.MC680x
{
	public class LDD_Instruction : Instruction
	{
		public override string Mnemonic { get { return "LDD"; } }
	}
}