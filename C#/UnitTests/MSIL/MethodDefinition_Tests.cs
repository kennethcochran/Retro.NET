﻿//
// Copyright (c) 2023 James Ross
//
// Released under the GNU AFFERO GENERAL PUBLIC LICENSE Version 3
// Please see README.md, LICENSE, agpl-3.0.txt in root folder
//

using NUnit.Framework;

namespace UnitTests.MSIL
{
	[TestFixture]
	public class MethodDefinition_Tests
	{
		[Test]
		public void Constructor_Defaults()
		{
			var module = new global::MSIL.ModuleDefinition();
			var type = new global::MSIL.TypeDefinition(module);
			var method = new global::MSIL.MethodDefinition(type);

			Assert.IsNull(method.CecilMethodDefinition);
			Assert.IsNotNull(method.ParentType);
			Assert.That(type, Is.EqualTo(method.ParentType));

			Assert.That(method.Instructions.Count, Is.EqualTo(0));
			Assert.That(method.InstructionDict.Count, Is.EqualTo(0));

			Assert.That(method.CurrentInstructionIndex, Is.EqualTo(0));
			Assert.IsNull(method.CurrentInstruction);

			Assert.That(method.LocalVariables.Count, Is.EqualTo(0));
		}
	}
}
