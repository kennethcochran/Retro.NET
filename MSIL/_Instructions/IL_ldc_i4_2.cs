﻿using System;
using System.Collections.Generic;
using System.Text;

using Cecil = Mono.Cecil;

namespace MSIL
{
	// 0x18 | ldc.i4.2 | Push 2 onto the stack as int32. | Base instruction

	public class IL_ldc_i4_2 : Instruction 
	{
		public override string OpCode { get { return "18"; } }

		public override string Mnemonic { get { return "ldc.i4.2"; } }

		public override string Description { get { return "Push 2 onto the stack as int32."; } }
		public override string Category { get { return "Base instruction"; } }

		public IL_ldc_i4_2(Cecil.Cil.Instruction cecilInstruction, MethodDefinition parentMethod) 
			: base(cecilInstruction, parentMethod)
		{
		}

		public override void Execute() 
		{
			this.ParentMethod.CurrentInstructionIndex++;
			throw new Exception("Instruction [ldc.i4.2] not done!");
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
			throw new Exception("M6x09_Simulate [ldc.i4.2] not done!");
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