﻿using System.Linq;
using CppSharp.AST;

namespace CSharpFromC.Generator.CppSharpUnsafeGenerator.Processing;

public class MacroProcessor
{
    private readonly ProcessingContext _context;

    public MacroProcessor(ProcessingContext context) => _context = context;

    public void Process(TranslationUnit translationUnit)
    {
        foreach (var macro in translationUnit.PreprocessedEntities.OfType<MacroDefinition>()
                     .Where(x => !string.IsNullOrWhiteSpace(x.Expression)))
        {
            var macroDefinition = new Definitions.MacroDefinition
            {
                Name = macro.Name,
                Expression = macro.Expression
            };
            _context.AddDefinition(macroDefinition);
        }
    }
}
