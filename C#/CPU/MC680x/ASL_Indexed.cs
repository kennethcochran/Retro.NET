﻿//
// Copyright (c) 2023 James Ross
//
// Released under the GNU AFFERO GENERAL PUBLIC LICENSE Version 3
// Please see README.md, LICENSE, agpl-3.0.txt in root folder
//

namespace CPU.MC680x
{
	public class ASL_Indexed : Instruction, IIndexed
	{
		public ASL_Indexed(CodeBlock codeBlock)
			: base(codeBlock)
		{
		}

		public override byte OpCode { get { return 0x68; } }

		public override string Mnemonic { get { return "ASL"; } }
	}
}
