﻿//
// Copyright (c) 2023 James Ross
//
// Released under the GNU AFFERO GENERAL PUBLIC LICENSE Version 3
// Please see README.md, LICENSE, agpl-3.0.txt in root folder
//

using System.Text;

using Cecil = Mono.Cecil;

namespace MSIL
{
	// 0x46 | ldind.i1 | Indirect load value of type int8 as int32 on the stack. | Base instruction

	public class IL_ldind_i1 : Instruction 
	{
		public override string OpCode { get { return "46"; } }

		public override string Mnemonic { get { return "ldind.i1"; } }

		public override string Description { get { return "Indirect load value of type int8 as int32 on the stack."; } }
		public override string Category { get { return "Base instruction"; } }

		public IL_ldind_i1(MethodDefinition parentMethod, Cecil.Cil.Instruction cecilInstruction = null) 
			: base(parentMethod, cecilInstruction)
		{
		}

		public override void Execute() 
		{
			this.ParentMethod.CurrentInstructionIndex++;
			throw new Exception("Instruction [ldind.i1] not done!");
		}

		public override void MC680x_UnOptimized_Code(StringBuilder sb) 
		{
			this.OutputDescCategoryLine(sb);
		}

		public override void MC680x_Optimized_Code(StringBuilder sb) 
		{
			this.OutputDescCategoryLine(sb);
		}

		public override void MC6x09_UnOptimized_Code(StringBuilder sb) 
		{
			this.OutputDescCategoryLine(sb);
		}

		public override void MC6x09_Optimized_Code(StringBuilder sb) 
		{
			this.OutputDescCategoryLine(sb);
		}
	}
}
