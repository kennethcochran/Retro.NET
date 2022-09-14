﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CPU.MC6x09
{
	public class SUBW_Indexed : SUBW_Instruction, IIndexed 
	{
		public SUBW_Indexed(CodeBlock codeBlock)
			: base(codeBlock)
		{
		}

		public override byte? PreByte { get { return 0x10; } }
		public override byte OpCode { get { return 0xA0; } }
	}
}
