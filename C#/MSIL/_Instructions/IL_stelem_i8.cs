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
	// 0x9F | stelem.i8 | Replace array element at index with the int64 value on the stack. | Object model instruction

	public class IL_stelem_i8 : Instruction 
	{
		public override string OpCode { get { return "9F"; } }

		public override string Mnemonic { get { return "stelem.i8"; } }

		public override string Description { get { return "Replace array element at index with the int64 value on the stack."; } }
		public override string Category { get { return "Object model instruction"; } }

		public IL_stelem_i8(MethodDefinition parentMethod, Cecil.Cil.Instruction cecilInstruction = null) 
			: base(parentMethod, cecilInstruction)
		{
		}

		public override void Execute() 
		{
			this.ParentMethod.CurrentInstructionIndex++;
			throw new Exception("Instruction [stelem.i8] not done!");
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
