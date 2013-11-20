﻿/* ****************************************************************************
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

namespace Microsoft.NodejsTools.Npm.SPI
{
    internal class Dependency : IDependency{
        private string _versionRangeUrlText;

        public Dependency(string name, string retreivalInfo){
            Name = name;
            _versionRangeUrlText = retreivalInfo;
        }

        public string Name { get; private set; }

        private bool IsVersionRange{
            get { return _versionRangeUrlText.IndexOf('/') < 0; }
        }

        public IDependencyUrl Url{
            get { return IsVersionRange ? null : new DependencyUrl(_versionRangeUrlText); }
        }

        public string VersionRangeText{
            get { return IsVersionRange ? _versionRangeUrlText : null; }
        }
    }
}