﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CPU.MC680x
{
	public class LDD_Immediate : LDD_Instruction, IImmediate
	{
		public override byte OpCode { get { return 0xCC; } }
	}
}
