﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CPU.MC680x
{
	public class ANDB_Direct : ANDB_Instruction, IDirect
	{
		public override byte OpCode { get { return 0xD4; } }
	}
}
