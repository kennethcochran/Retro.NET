﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CPU.MC680x
{
	public class BITA_Extended : BITA_Instruction, IExtended
	{
		public override byte OpCode { get { return 0xB5; } }
	}
}