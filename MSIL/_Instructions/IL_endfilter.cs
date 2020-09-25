﻿using System;
using System.Collections.Generic;
using System.Text;

using Cecil = Mono.Cecil;

namespace MSIL
{
	// 0xFE11 | endfilter | End an exception handling filter clause. | Base instruction

	public class IL_endfilter : Instruction 
	{
		public override string OpCode { get { return "FE11"; } }

		public override string Mnemonic { get { return "endfilter"; } }

		public override string Description { get { return "End an exception handling filter clause."; } }
		public override string Category { get { return "Base instruction"; } }

		public IL_endfilter(Cecil.Cil.Instruction cecilInstruction, MethodDefinition parentMethod) 
			: base(cecilInstruction, parentMethod)
		{
		}

		public override void Execute() 
		{
			this.ParentMethod.CurrentInstructionIndex++;
			throw new Exception("Instruction [endfilter] not done!");
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
			throw new Exception("M6x09_Simulate [endfilter] not done!");
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