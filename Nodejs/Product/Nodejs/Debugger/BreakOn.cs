/* ****************************************************************************
 *
 * Copyright (c) Microsoft Corporation. 
 *
 * This source code is subject to terms and conditions of the Apache License, Version 2.0. A 
 * copy of the license can be found in the License.html file at the root of this distribution. If 
 * you cannot locate the Apache License, Version 2.0, please send an email to 
 * vspython@microsoft.com. By using this source code in any fashion, you are agreeing to be bound 
 * by the terms of the Apache License, Version 2.0.
 *
 * You must not remove this notice, or any other, from this software.
 *
 * ***************************************************************************/

using System;

namespace Microsoft.NodejsTools.Debugger {
    struct BreakOn {
        public readonly uint Count;
        public readonly BreakOnKind Kind;

        public BreakOn(BreakOnKind kind, uint count) {
            if (kind != BreakOnKind.Always && count < 1) {
                throw new ArgumentException("Invalid BreakOn count");
            }

            Kind = kind;
            Count = count;
        }
    }
}