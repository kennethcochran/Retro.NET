﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CPU.MC680x
{
	public class ORAA_Extended : ORAA_Instruction, IExtended
	{
		public override byte OpCode { get { return 0xBA; } }
	}
}