﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CPU.MC680x
{
	public class LDAB_Extended : LDAB_Instruction, IExtended
	{
		public override byte OpCode { get { return 0xF6; } }
	}
}