﻿using System;
using System.Collections.Generic;
using System.Linq;
using Mono.Cecil;
using Telerik.JustDecompiler.Decompiler.WriterContextServices;

namespace Telerik.JustDecompiler.Languages
{
	public interface IAssemblyAttributeWriter
	{
		void WriteAssemblyAttributes(AssemblyDefinition assembly, IWriterContextService writerContextService, bool writeUsings = false, ICollection<string> attributesToIgnore = null);
		void WriteModuleAttributes(ModuleDefinition module, IWriterContextService writerContextService, bool writeUsings = false, ICollection<string> attributesToIgnore = null);
		void WriteAssemblyInfo(AssemblyDefinition assembly, IWriterContextService writerContextService, bool writeUsings = false, 
			ICollection<string> assemblyAttributesToIgnore = null, ICollection<string> moduleAttributesToIgnore = null);
	}
}
