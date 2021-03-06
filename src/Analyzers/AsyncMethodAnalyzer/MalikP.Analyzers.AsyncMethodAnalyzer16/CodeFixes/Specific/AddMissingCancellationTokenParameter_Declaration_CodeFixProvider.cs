﻿// MIT License
//
// Copyright (c) 2019 Peter Malik.
// 
// File: AddMissingCancellationTokenParameter_Declaration_CodeFixProvider.cs 
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

using MalikP.Analyzers.AsyncMethodAnalyzer.Rules.Design;

using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CodeFixes;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Options;
using Microsoft.CodeAnalysis.Simplification;

namespace MalikP.Analyzers.AsyncMethodAnalyzer.CodeFixes.Specific
{
    [ExportCodeFixProvider(LanguageNames.CSharp, Name = nameof(AddMissingCancellationTokenParameter_Declaration_CodeFixProvider)), Shared]
    public sealed class AddMissingCancellationTokenParameter_Declaration_CodeFixProvider : AbstractDocumentCodefixProvider<MethodDeclarationSyntax>
    {
        private const string _identifierName = "cancellationToken";

        protected override string Title => "Add missing 'CancellationToken'";

        protected override string[] DiagnosticId =>
            new[]
            {
                MissingCancellationTokenParameter_Task_Declaration_Rule.DiagnosticId,
                MissingCancellationTokenParameter_Void_Declaration_Rule.DiagnosticId
            };

        protected override async Task<Document> ChangedDocumentHandlerAsync(Document document, MethodDeclarationSyntax syntaxDeclaration, CancellationToken cancellationToken)
        {
            SyntaxToken identifier = SyntaxFactory.Identifier(_identifierName);
            TypeSyntax typeName = SyntaxFactory.ParseTypeName(typeof(CancellationToken).FullName);

            ParameterSyntax parameter = SyntaxFactory
                .Parameter(identifier)
                .WithType(typeName)
                .WithAdditionalAnnotations(Simplifier.Annotation);

            MethodDeclarationSyntax updatedMethod = syntaxDeclaration.AddParameterListParameters(parameter);

            SyntaxTree syntaxTree = await document.GetSyntaxTreeAsync(cancellationToken)
                .ConfigureAwait(false);

            SyntaxNode updatedSyntaxTree = syntaxTree
                .GetRoot()
                .ReplaceNode(syntaxDeclaration, updatedMethod);

            Document newDocument = document.WithSyntaxRoot(updatedSyntaxTree);

            DocumentOptionSet options = await newDocument.GetOptionsAsync(cancellationToken)
                .ConfigureAwait(false);

            return await Simplifier.ReduceAsync(newDocument, options, cancellationToken)
                .ConfigureAwait(false);
        }
    }
}