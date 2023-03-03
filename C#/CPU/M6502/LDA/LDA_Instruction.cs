﻿//
// Copyright (c) 2023 James Ross
//
// Released under the GNU AFFERO GENERAL PUBLIC LICENSE Version 3
// Please see README.md, LICENSE, agpl-3.0.txt in root folder
//

namespace CPU.M6502
{
    public class LDA_Instruction : Instruction
    {
        public LDA_Instruction(CodeBlock codeBlock)
            : base(codeBlock)
        {
        }

        public override string Mnemonic { get { return "LDA"; } }
    }
}
