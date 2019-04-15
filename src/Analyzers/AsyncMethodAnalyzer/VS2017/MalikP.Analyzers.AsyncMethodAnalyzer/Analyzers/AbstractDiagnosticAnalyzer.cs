﻿// MIT License
//
// Copyright (c) 2019 Peter Malik.
// 
// File: AbstractDiagnosticAnalyzer.cs 
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

using System.Collections.Immutable;

using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.Diagnostics;

namespace MalikP.Analyzers.AsyncMethodAnalyzer.Analyzers
{
    public abstract class AbstractDiagnosticAnalyzer : DiagnosticAnalyzer
    {
        protected const string _expectedParameterName = "cancellationToken";
        protected const string _cancellationTokenType = "System.Threading.CancellationToken";
        protected const string _taskType = "System.Threading.Tasks.Task";
        protected const string _asyncSuffix = "Async";

        protected AbstractDiagnosticAnalyzer()
        {
        }

        protected abstract SymbolKind[] SymbolKinds { get; }

        protected abstract DiagnosticDescriptor DiagnosticDescriptor { get; }

        protected abstract void AnalyzeSymbol(SymbolAnalysisContext context);

        public override ImmutableArray<DiagnosticDescriptor> SupportedDiagnostics => ImmutableArray.Create(DiagnosticDescriptor);

        public override void Initialize(AnalysisContext context) => context.RegisterSymbolAction(AnalyzeSymbol, SymbolKinds);

        protected void ReportDiagnosticResult(SymbolAnalysisContext context, ISymbol symbol)
        {
            Diagnostic diagnostic = Diagnostic.Create(DiagnosticDescriptor, symbol.Locations[0], symbol.Name);
            context.ReportDiagnostic(diagnostic);
        }
    }
}
