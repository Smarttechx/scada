﻿/*
 * Copyright 2018 Mikhail Shiryaev
 * 
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 * 
 *     http://www.apache.org/licenses/LICENSE-2.0
 * 
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 * 
 * 
 * Product  : Rapid SCADA
 * Module   : ScadaAdminCommon
 * Summary  : The configuration database and the basis of a configuration
 * 
 * Author   : Mikhail Shiryaev
 * Created  : 2018
 * Modified : 2018
 */

using Scada.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Scada.Admin.Project
{
    /// <summary>
    /// The configuration database and the basis of a configuration
    /// <para>База данных конфигурации и основа конфигурации</para>
    /// </summary>
    public class ConfigBase
    {
        /// <summary>
        /// Gets devices
        /// </summary>
        public List<Device> Devices { get; protected set; }

        /// <summary>
        /// Gets objects (locations)
        /// </summary>
        public List<Obj> Objects { get; protected set; }
    }
}
