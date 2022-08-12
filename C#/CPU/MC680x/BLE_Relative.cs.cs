﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CPU.MC680x
{
	public class BLE_Relative : Instruction, IRelative
	{
		public override byte OpCode { get { return 0x2F; } }

		public override string Mnemonic { get { return "BLE"; } }
	}
}