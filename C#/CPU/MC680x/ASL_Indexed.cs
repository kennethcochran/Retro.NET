﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CPU.MC680x
{
	public class ASL_Indexed : Instruction, IIndexed
	{
		public ASL_Indexed(CodeBlock codeBlock)
			: base(codeBlock)
		{
		}

		public override byte OpCode { get { return 0x68; } }

		public override string Mnemonic { get { return "ASL"; } }
	}
}
