﻿using System;
using System.Collections.Generic;
using System.Text;

using System.IO;

using Cecil = Mono.Cecil;

namespace MSIL
{
	public class ModuleDefinition
	{
		public string AssemblyFilePath { get; private set; }

		public string AssemblyName { get; set; }

		public string MC680xPath { get; set; }
		public string MC6x09Path { get; set; }
		public string Z80Path { get; set; }
		public string MOS6502Path { get; set; }
		public string MC68000Path { get; set; }

		public Cecil.ModuleDefinition CecilModule { get; set; }

		public List<TypeDefinition> TypeDefinitions { get; } = new List<TypeDefinition>();
		public Dictionary<string, TypeDefinition> TypeDefinitionDictionary { get; } = new Dictionary<string, TypeDefinition>();

		public Dictionary<string, Sys.TypeDefinition> SysTypeDefinitionDictionary { get; } = new Dictionary<string, Sys.TypeDefinition>();

		public int StringConstantCount { get; set; }
		public Dictionary<string, string> StringConstantDictionary { get; } = new Dictionary<string, string>();

		public MSILStack MethodStack { get; } = new MSILStack();

		public MethodDefinition MainMethod { get; set; }

		public ModuleDefinition(string assemblyFilePath = null) 
		{
			this.AssemblyFilePath = assemblyFilePath;
			//if (!File.Exists(this.AssemblyFilePath))
			//	throw new Exception($"Assembly {this.AssemblyFilePath} does not exist!");
		}

		public void Initialize() 
		{
			if (this.AssemblyFilePath != null)
			{
				if (!File.Exists(this.AssemblyFilePath))
					throw new Exception($"Assembly {this.AssemblyFilePath} does not exist!");

				this.LoadCecilModule();
				this.LoadCecilTypeDefinitions();
				this.LoadRunTimeTypeDefinitions();
			}
		}

		public void LoadCecilModule() 
		{
			this.CecilModule = Cecil.ModuleDefinition.ReadModule(this.AssemblyFilePath);
		}

		public void LoadCecilTypeDefinitions() 
		{
			foreach (Cecil.TypeDefinition type in this.CecilModule.Types)
			{
				TypeDefinition typeDefinition = new TypeDefinition(this, type);
				this.TypeDefinitions.Add(typeDefinition);
				this.TypeDefinitionDictionary.Add(type.FullName, typeDefinition);

				typeDefinition.Initialize();
			}
		}

		public void LoadRunTimeTypeDefinitions() 
		{
			Sys.TypeDefinition sysDefinition = new Sys.Console.TypeDefinition();
			this.SysTypeDefinitionDictionary.Add(sysDefinition.FullName, sysDefinition);

			sysDefinition = new Sys.String.TypeDefinition();
			this.SysTypeDefinitionDictionary.Add(sysDefinition.FullName, sysDefinition);
		}

		public void Execute() 
		{
			if (this.MainMethod != null)
			{
				// I need to push main's params on the stack ... 
				if (this.MainMethod.CecilMethodDefinition.Parameters.Count > 0)
				{
					foreach (var param in this.MainMethod.CecilMethodDefinition.Parameters)
					{
						// Console.WriteLine("param: [" + param.ParameterType.Name + "] " + param.ParameterType.GetType());
						// THIS IS WRONG -- it's just a temporary holder to make it work
						this.MethodStack.Push(param.ParameterType.Name);
					}
				}

				this.MainMethod.Execute();
			}
			else
				throw new Exception("Not Finished!");

			// Console.WriteLine("end stack size: " + this.MethodStack.Length);
		}

		public void CilListing() 
		{
			Console.WriteLine("*** Listing MODULE: " + this.CecilModule.Name);

			foreach (var typeDefinition in this.TypeDefinitions)
				typeDefinition.CilListing();

			Console.WriteLine("*** End Listing");
		}

		// ----- MC680x

		public void MC680x_AssemblyLanguage(string path = null) 
		{
			if (path != null)
				this.MC680xPath = path;

			StringBuilder sb = new StringBuilder();
			this.MC680x_Preamble(sb);

			foreach (var str in this.StringConstantDictionary.Keys)
				sb.AppendLine($"{this.StringConstantDictionary[str]}\tFCC \"{str}\"");

			foreach (var typeDefinition in this.TypeDefinitions)
				typeDefinition.MC680x_TypeDefinition(sb);

			this.MC680x_Epilogue(sb);

			File.WriteAllText(this.MC680xPath, sb.ToString());
		}

		public void MC680x_Preamble(StringBuilder sb) 
		{
			sb.AppendLine("; ---------------------------------------------------------------------");
			sb.AppendLine("; 6801 code generated by Retro.NET");
			sb.AppendLine("; ---------------------------------------------------------------------");
			sb.AppendLine("\t.org $4800");  // what's ideal? 
			sb.AppendLine("start:");
		}

		public void MC680x_Epilogue(StringBuilder sb) 
		{
			// sb.AppendLine("System_Console_WriteLine_String equ $");
			// sb.AppendLine("\trts");
			// sb.AppendLine();
			sb.AppendLine("; ---------------------------------------------------------------------");
			sb.AppendLine("\t.end start");
		}

		// ----- MC6809

		public void MC6x09_AssemblyLanguage(string path = null) 
		{
			if (path != null)
				this.MC6x09Path = path;

			StringBuilder sb = new StringBuilder();
			this.MC6x09_Preamble(sb);

			foreach (var str in this.StringConstantDictionary.Keys)
				sb.AppendLine($"{this.StringConstantDictionary[str]}\tFCC \"{str}\"");

			foreach (var typeDefinition in this.TypeDefinitions)
				typeDefinition.MC6x09_TypeDefinition(sb);
			
			this.MC6x09_Epilogue(sb);
			
			File.WriteAllText(this.MC6x09Path, sb.ToString());
		}

		public void MC6x09_Preamble(StringBuilder sb) 
        {
            sb.AppendLine("*----------------------------------------------------------------------");
            sb.AppendLine("*");
            sb.AppendLine("* 6809 Code Compiled by Retro.NET");
            sb.AppendLine("*");
            sb.AppendLine("*----------------------------------------------------------------------");
            sb.AppendLine("\torg $3F00");
            sb.AppendLine();
            sb.AppendLine("start\tequ *");
            sb.AppendLine();
        }

        public void MC6x09_Epilogue(StringBuilder sb) 
        {
			//sb.AppendLine("System_Console_WriteLine_String equ $");
			//sb.AppendLine("\tret");
			//sb.AppendLine();
			sb.AppendLine("\tend start");
        }

		// ----- Z80

		public void Z80_AssemblyLanguage(string path = null) 
		{
			if (path != null)
				this.Z80Path = path;

			StringBuilder sb = new StringBuilder();
			this.Z80_Preamble(sb);

			foreach (var str in this.StringConstantDictionary.Keys)
				sb.AppendLine($"{this.StringConstantDictionary[str]}\txxxx \"{str}\"");

			foreach (var typeDefinition in this.TypeDefinitions)
				typeDefinition.Z80_TypeDefinition(sb);

			this.Z80_Epilogue(sb);

			File.WriteAllText(this.Z80Path, sb.ToString());
		}

		public void Z80_Preamble(StringBuilder sb) 
		{
			sb.AppendLine("*----------------------------------------------------------------------");
			sb.AppendLine("*");
			sb.AppendLine("* Z80 Code Generated by Retro.NET");
			sb.AppendLine("*");
			sb.AppendLine("*----------------------------------------------------------------------");
			sb.AppendLine("\torg $3F00");
			sb.AppendLine();
			sb.AppendLine("start\tequ *");
			sb.AppendLine();
		}

		public void Z80_Epilogue(StringBuilder sb) 
		{
			sb.AppendLine("System_Console_WriteLine_String equ $");
			sb.AppendLine("\tret");
			sb.AppendLine();
			sb.AppendLine("\tend start");
		}

		// ----- MOS6502

		public void MOS6502_AssemblyLanguage(string path = null) 
		{
			if (path != null)
				this.MOS6502Path = path;

			StringBuilder sb = new StringBuilder();
			this.MOS6502_Preamble(sb);

			foreach (var str in this.StringConstantDictionary.Keys)
				sb.AppendLine($"{this.StringConstantDictionary[str]}\txxxx \"{str}\"");

			foreach (var typeDefinition in this.TypeDefinitions)
				typeDefinition.Z80_TypeDefinition(sb);

			this.MOS6502_Epilogue(sb);

			File.WriteAllText(this.MOS6502Path, sb.ToString());
		}

		public void MOS6502_Preamble(StringBuilder sb) 
		{
			sb.AppendLine("*----------------------------------------------------------------------");
			sb.AppendLine("*");
			sb.AppendLine("* 6502 Code Generated by Retro.NET");
			sb.AppendLine("*");
			sb.AppendLine("*----------------------------------------------------------------------");
			sb.AppendLine("\torg $3F00");
			sb.AppendLine();
			sb.AppendLine("start\tequ *");
			sb.AppendLine();
		}

		public void MOS6502_Epilogue(StringBuilder sb) 
		{
			sb.AppendLine("System_Console_WriteLine_String equ $");
			sb.AppendLine("\tret");
			sb.AppendLine();
			sb.AppendLine("\tend start");
		}

		// ----- MC68000

		public void MC68000_AssemblyLanguage(string path = null) 
		{
			if (path != null)
				this.MC68000Path = path;

			StringBuilder sb = new StringBuilder();
			this.MC68000_Preamble(sb);

			foreach (var str in this.StringConstantDictionary.Keys)
				sb.AppendLine($"{this.StringConstantDictionary[str]}\txxxx \"{str}\"");

			foreach (var typeDefinition in this.TypeDefinitions)
				typeDefinition.MC68000_TypeDefinition(sb);

			this.MC68000_Epilogue(sb);

			File.WriteAllText(this.MC68000Path, sb.ToString());
		}

		public void MC68000_Preamble(StringBuilder sb) 
		{
			sb.AppendLine("*----------------------------------------------------------------------");
			sb.AppendLine("*");
			sb.AppendLine("* 68000 Code Generated by Retro.NET");
			sb.AppendLine("*");
			sb.AppendLine("*----------------------------------------------------------------------");
			sb.AppendLine("\torg $3F00");
			sb.AppendLine();
			sb.AppendLine("start\tequ *");
			sb.AppendLine();
		}

		public void MC68000_Epilogue(StringBuilder sb) 
		{
			sb.AppendLine("System_Console_WriteLine_String equ $");
			sb.AppendLine("\tret");
			sb.AppendLine();
			sb.AppendLine("\tend start");
		}
	}
}
