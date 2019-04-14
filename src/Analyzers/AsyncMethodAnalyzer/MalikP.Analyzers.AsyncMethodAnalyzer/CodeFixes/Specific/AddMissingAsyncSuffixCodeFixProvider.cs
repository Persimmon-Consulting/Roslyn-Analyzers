﻿// MIT License
//
// Copyright (c) 2019 Peter Malik.
// 
// File: AddMissingAsyncSuffixCodeFixProvider.cs 
// Company: MalikP.
//
// Repository: https://github.com/peterM/Roslyn-Analyzers
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
// SOFTWARE.

using System.Composition;
using System.Threading;
using System.Threading.Tasks;

using MalikP.Analyzers.AsyncMethodAnalyzer.Rules;

using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CodeFixes;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Options;
using Microsoft.CodeAnalysis.Rename;

namespace MalikP.Analyzers.AsyncMethodAnalyzer.CodeFixes.Specific
{
    [ExportCodeFixProvider(LanguageNames.CSharp, Name = nameof(AddMissingAsyncSuffixCodeFixProvider)), Shared]
    public sealed class AddMissingAsyncSuffixCodeFixProvider : AbstractSolutionCodefixProvider<MethodDeclarationSyntax>
    {
        protected override string EquivalenceKey => Title;

        protected override string Title => "Add missing 'Async' suffix";

        protected override string DiagnosticId => RenameMethodMissingAsyncSuffixRule.RenameMethodMissingAsyncSuffixDiagnosticId;

        protected override async Task<Solution> ChangedSolutionHandlerAsync(Document document, MethodDeclarationSyntax syntaxDeclaration, CancellationToken cancellationToken)
        {
            SyntaxToken identifierToken = syntaxDeclaration.Identifier;
            string newName = string.Concat(identifierToken.Text, "Async");

            SemanticModel semanticModel = await document.GetSemanticModelAsync(cancellationToken);
            IMethodSymbol typeSymbol = semanticModel.GetDeclaredSymbol(syntaxDeclaration, cancellationToken);

            Solution originalSolution = document.Project.Solution;
            OptionSet optionSet = originalSolution.Workspace.Options;

            return await Renamer.RenameSymbolAsync(document.Project.Solution, typeSymbol, newName, optionSet, cancellationToken).ConfigureAwait(false);
        }
    }
}