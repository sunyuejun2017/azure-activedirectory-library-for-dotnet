﻿//----------------------------------------------------------------------
// Copyright (c) Microsoft Open Technologies, Inc.
// All Rights Reserved
// Apache License 2.0
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
// http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
//----------------------------------------------------------------------

namespace Microsoft.IdentityModel.Clients.ActiveDirectory
{
    /// <summary>
    /// This class holds properties to enable/disable logging and set tracing levels. To enable tracing, the properties must be set first.
    /// </summary>
    public static class AdalTrace
    {
        /// <summary>
        /// Flag to enable/disable tracing.
        /// </summary>
        public static bool TraceEnabled { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public static AdalTraceLevel Level { get; set; }
    }

    /// <summary>
    /// Trace level for logging.
    /// </summary>
    public enum AdalTraceLevel
    {
        Informational,
        Verbose,
        Warning,
        Error,
        Critical,
        LogAlways
    }
}
