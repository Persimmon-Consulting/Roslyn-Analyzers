﻿// MIT License
//
// Copyright (c) 2019 Peter Malik.
// 
// File: MissingCancellationTokenParameter_VoidMethod_Rule.cs 
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

using Microsoft.CodeAnalysis;

namespace MalikP.Analyzers.AsyncMethodAnalyzer.Rules.Design
{
    internal sealed class MissingCancellationTokenParameter_VoidMethod_Rule : AbstractDiagnosticRuleDescriptor
    {
        protected override string InternalDiagnosticId => DiagnosticId;

        protected override string Category => AbstractDiagnosticRuleDescriptor.Design;

        protected override LocalizableString Title => new LocalizableResourceString(nameof(Resources.MissingCancellationTokenParameter_VoidMethod_Rule_Title), Resources.ResourceManager, typeof(Resources));
        protected override LocalizableString MessageFormat => new LocalizableResourceString(nameof(Resources.MissingCancellationTokenParameter_VoidMethod_Rule_MessageFormat), Resources.ResourceManager, typeof(Resources));
        protected override LocalizableString Description => new LocalizableResourceString(nameof(Resources.MissingCancellationTokenParameter_VoidMethod_Rule_Description), Resources.ResourceManager, typeof(Resources));

        protected override DiagnosticSeverity Severity => DiagnosticSeverity.Info;

        static MissingCancellationTokenParameter_VoidMethod_Rule()
        {
            MissingCancellationTokenParameter_VoidMethod_Rule descriptot = new MissingCancellationTokenParameter_VoidMethod_Rule();
            Rule = AbstractDiagnosticRuleDescriptor.Create(descriptot);
        }

        private MissingCancellationTokenParameter_VoidMethod_Rule()
        {
        }

        internal static DiagnosticDescriptor Rule { get; }

        internal static string DiagnosticId => "AADE003";
    }
}
