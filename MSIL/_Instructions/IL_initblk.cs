﻿using System;
using System.Collections.Generic;
using System.Text;

using Cecil = Mono.Cecil;

namespace MSIL
{
	// 0xFE18 | initblk | Set all bytes in a block of memory to a given byte value. | Base instruction

	public class IL_initblk : Instruction 
	{
		public override string OpCode { get { return "FE18"; } }

		public override string Mnemonic { get { return "initblk"; } }

		public override string Description { get { return "Set all bytes in a block of memory to a given byte value."; } }
		public override string Category { get { return "Base instruction"; } }

		public IL_initblk(Cecil.Cil.Instruction cecilInstruction, MethodDefinition parentMethod) 
			: base(cecilInstruction, parentMethod)
		{
		}

		public override void Execute() 
		{
			this.ParentMethod.CurrentInstructionIndex++;
			throw new Exception("Instruction [initblk] not done!");
		}

		public override void MC6801_UnOptimized_Code(StringBuilder sb) 
		{
			this.OutputDescCategoryLine(sb);
		}

		public override void MC6801_Optimized_Code(StringBuilder sb) 
		{
			this.OutputDescCategoryLine(sb);
		}

		public override void MC6809_Simulate() 
		{
			throw new Exception("M6x09_Simulate [initblk] not done!");
		}

		public override void MC6809_UnOptimized_Code(StringBuilder sb) 
		{
			this.OutputDescCategoryLine(sb);
		}

		public override void MC6809_Optimized_Code(StringBuilder sb) 
		{
			this.OutputDescCategoryLine(sb);
		}
	}
}