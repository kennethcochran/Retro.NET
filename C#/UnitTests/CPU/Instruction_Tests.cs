﻿//
// Copyright (c) 2023 James Ross
//
// Released under the GNU AFFERO GENERAL PUBLIC LICENSE Version 3
// Please see README.md, LICENSE, agpl-3.0.txt in root folder
//

using NUnit.Framework;

namespace UnitTests.CPU
{
	[TestFixture]
	public class Instruction_Tests
	{
		[Test]
		public void Constructor_Defaults()
		{
			var module = new global::CPU.Module();
			var instruction = new global::CPU.Instruction(module);

			Assert.That(instruction.PreByte, Is.EqualTo(null));
			Assert.Throws<NotImplementedException>(() => { byte x = instruction.OpCode; });
			// Assert.Throws<NotImplementedException>(delegate { byte x = instruction.OpCode; });
			Assert.That(instruction.Desc, Is.EqualTo(null));
			Assert.That(instruction.Category, Is.EqualTo(null));
		}
	}
}
