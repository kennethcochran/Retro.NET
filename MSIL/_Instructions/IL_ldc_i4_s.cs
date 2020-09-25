﻿using System;
using System.Collections.Generic;
using System.Text;

using Cecil = Mono.Cecil;

namespace MSIL
{
	// 0x1F | ldc.i4.s | Push num onto the stack as int32, short form. | Base instruction

	public class IL_ldc_i4_s : Instruction 
	{
		public override string OpCode { get { return "1F"; } }

		public override string Mnemonic { get { return "ldc.i4.s"; } }

		public override string Description { get { return "Push num onto the stack as int32, short form."; } }
		public override string Category { get { return "Base instruction"; } }

		public int Number { get; private set; }

		public IL_ldc_i4_s(Cecil.Cil.Instruction cecilInstruction, MethodDefinition parentMethod) 
			: base(cecilInstruction, parentMethod)
		{
			// Console.WriteLine("IL_ldc_i4_s: " + cecilInstruction.Operand.GetType());
			this.Number = System.Convert.ToInt32(cecilInstruction.Operand);
		}

		public override void Execute() 
		{
			this.ParentMethod.ParentType.ParentModule.MethodStack.Push(this.Number);
			this.ParentMethod.CurrentInstructionIndex++;
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
			throw new Exception("M6x09_Simulate [ldc.i4.s] not done!");
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