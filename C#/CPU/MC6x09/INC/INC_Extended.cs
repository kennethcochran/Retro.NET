﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CPU.MC6x09
{
	public class INC_Extended : INC_Instruction, IExtended 
	{
		public override byte OpCode { get { return 0x7C; } }
	}
}
