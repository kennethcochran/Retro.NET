﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CPU.MC6x09
{
	public class CMPX_Extended : CMPX_Instruction, IExtended 
	{
		public override byte OpCode { get { return 0xBC; } }
	}
}
