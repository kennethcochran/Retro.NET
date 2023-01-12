﻿//
// Copyright (c) 2023 James Ross
//
// Released under the GNU AFFERO GENERAL PUBLIC LICENSE Version 3
// Please see README.md, LICENSE, agpl-3.0.txt in root folder
//

namespace CPU.MC680x
{
	public class JSR_Extended : JSR_Instruction, IExtended
	{
		public JSR_Extended(CodeBlock codeBlock)
			: base(codeBlock)
		{
		}

		public override byte OpCode { get { return 0xBD; } }
	}
}
