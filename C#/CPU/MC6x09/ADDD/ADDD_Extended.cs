﻿//
// Copyright (c) 2023 James Ross
//
// Released under the GNU AFFERO GENERAL PUBLIC LICENSE Version 3
// Please see README.md, LICENSE, agpl-3.0.txt in root folder
//

namespace CPU.MC6x09
{
	public class ADDD_Extended : ADDD_Instruction, IExtended 
	{
		public ADDD_Extended(CodeBlock codeBlock)
			: base(codeBlock)
		{
		}

		public override byte OpCode { get { return 0xF3; } }
	}
}
