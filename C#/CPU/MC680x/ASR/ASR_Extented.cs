﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CPU.MC680x
{
	public class ASR_Extended : ASR_Instruction, IExtended
	{
		public override byte OpCode { get { return 0x77; } }
	}
}