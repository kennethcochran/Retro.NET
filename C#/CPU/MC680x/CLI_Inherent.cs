﻿//
// Copyright (c) 2023 James Ross
//
// Released under the GNU AFFERO GENERAL PUBLIC LICENSE Version 3
// Please see README.md, LICENSE, agpl-3.0.txt in root folder
//

namespace CPU.MC680x
{
	public class CLI_Inherent : Instruction, IInherent
	{
		public CLI_Inherent(CodeBlock codeBlock)
			: base(codeBlock)
		{
		}

		public override byte OpCode { get { return 0x0E; } }

		public override string Mnemonic { get { return "CLI"; } }
	}
}
