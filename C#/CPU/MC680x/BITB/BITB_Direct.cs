﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CPU.MC680x
{
	public class BITB_Direct : BITB_Instruction, IDirect
	{
		public override byte OpCode { get { return 0xD5; } }
	}
}