﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CPU.MC6x09
{
	public class LSL_Instruction : Instruction 
	{
		public LSL_Instruction(CodeBlock codeBlock)
			: base(codeBlock)
		{
		}

		public override string Mnemonic { get { return "LSL"; } }
	}
}
