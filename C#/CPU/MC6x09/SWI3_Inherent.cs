﻿//
// Copyright (c) 2023 James Ross
//
// Released under the GNU AFFERO GENERAL PUBLIC LICENSE Version 3
// Please see README.md, LICENSE, agpl-3.0.txt in root folder
//

namespace CPU.MC6x09
{
	public class SWI3_Inherent : Instruction, IInherent 
	{
		public SWI3_Inherent(CodeBlock codeBlock)
			: base(codeBlock)
		{
		}

		public override byte? PreByte { get { return 0x11; } }
		public override byte OpCode { get { return 0x3F; } }

		public override string Mnemonic { get { return "SWI3"; } }
	}
}
