﻿using System;
using System.Collections.Generic;
using System.Text;

using Cecil = Mono.Cecil;

namespace MSIL
{
	// 0x93 | ldelem.u2 | Load the element with type unsigned int16 at index onto the top of the stack as an int32. | Object model instruction

	public class IL_ldelem_u2 : Instruction 
	{
		public override string OpCode { get { return "93"; } }

		public override string Mnemonic { get { return "ldelem.u2"; } }

		public override string Description { get { return "Load the element with type unsigned int16 at index onto the top of the stack as an int32."; } }
		public override string Category { get { return "Object model instruction"; } }

		public IL_ldelem_u2(Cecil.Cil.Instruction cecilInstruction, MethodDefinition parentMethod) 
			: base(cecilInstruction, parentMethod)
		{
		}

		public override void Execute() 
		{
			this.ParentMethod.CurrentInstructionIndex++;
			throw new Exception("Instruction [ldelem.u2] not done!");
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
			throw new Exception("M6x09_Simulate [ldelem.u2] not done!");
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