﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CPU.MC6x09
{
	public class STW_Instruction : Instruction 
	{
		public override string Mnemonic { get { return "STW"; } }
	}
}