﻿/*
 * Copyright 2017 Mikhail Shiryaev
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
 * Module   : ScadaSchemeCommon
 * Summary  : Specifies items whose changes are observed
 * 
 * Author   : Mikhail Shiryaev
 * Created  : 2017
 * Modified : 2017
 */

using System;

namespace Scada.Scheme.Model
{
    /// <summary>
    /// Specifies items whose changes are observed
    /// <para>Определяет элементы, изменения которых отслеживаются</para>
    /// </summary>
    public interface IObservableItem
    {
        /// <summary>
        /// Вызвать событие ItemChanged
        /// </summary>
        void OnItemChanged();

        /// <summary>
        /// Событие возникающее при изменении элемента
        /// </summary>
        event EventHandler ItemChanged;
    }
}
