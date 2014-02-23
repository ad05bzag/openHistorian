﻿//******************************************************************************************************
//  SortedTreeTypeBase`1.cs - Gbtc
//
//  Copyright © 2013, Grid Protection Alliance.  All Rights Reserved.
//
//  Licensed to the Grid Protection Alliance (GPA) under one or more contributor license agreements. See
//  the NOTICE file distributed with this work for additional information regarding copyright ownership.
//  The GPA licenses this file to you under the Eclipse Public License -v 1.0 (the "License"); you may
//  not use this file except in compliance with the License. You may obtain a copy of the License at:
//
//      http://www.opensource.org/licenses/eclipse-1.0.php
//
//  Unless agreed to in writing, the subject software distributed under the License is distributed on an
//  "AS-IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied. Refer to the
//  License for the specific language governing permissions and limitations.
//
//  Code Modification History:
//  ----------------------------------------------------------------------------------------------------
//  11/1/2013 - Steven E. Chisholm
//       Generated original version of source code. 
//     
//******************************************************************************************************

using System;
using System.Collections;
using GSF.IO;

namespace GSF.SortedTreeStore.Tree
{
    /// <summary>
    /// The interface that is required to use as a value in <see cref="SortedTree"/> 
    /// </summary>
    /// <typeparam name="T">A class that has a default constructor</typeparam>
    public abstract class SortedTreeTypeBase<T>
        : IComparable<T>, IEquatable<T>
        where T : SortedTreeTypeBase<T>, new()
    {
        /// <summary>
        /// Creates a class that contains the necessary methods for the SortedTree.
        /// </summary>
        /// <returns></returns>
        public virtual SortedTreeTypeMethods<T> CreateValueMethods()
        {
            return new SortedTreeTypeMethods<T>();
        }

        /// <summary>
        /// Gets all available encoding methods for a specific type. May return null if none exists.
        /// </summary>
        /// <returns>null or an IEnumerable of all encoding methods.</returns>
        public virtual IEnumerable GetEncodingMethods()
        {
            return null;
        }


        /// <summary>
        /// Compares the current instance to <see cref="other"/>.
        /// </summary>
        /// <param name="other">the key to compare to</param>
        /// <returns></returns>
        public abstract int CompareTo(T other);

        /// <summary>
        /// Is the current instance equal to <see cref="other"/>
        /// </summary>
        /// <param name="other">the key to compare to</param>
        /// <returns></returns>
        public bool IsEqualTo(T other)
        {
            return CompareTo(other) == 0;
        }

        /// <summary>
        /// Indicates whether the current object is equal to another object of the same type.
        /// </summary>
        /// <returns>
        /// true if the current object is equal to the <paramref name="other"/> parameter; otherwise, false.
        /// </returns>
        /// <param name="other">An object to compare with this object.</param>
        public bool Equals(T other)
        {
            return IsEqualTo(other);
        }

        /// <summary>
        /// Sets the provided key to it's minimum value
        /// </summary>
        public abstract void SetMin();

        /// <summary>
        /// Sets the privided key to it's maximum value
        /// </summary>
        public abstract void SetMax();

        /// <summary>
        /// The Guid uniquely defining this type. 
        /// It is important to uniquely tie 1 type to 1 guid.
        /// </summary>
        public abstract Guid GenericTypeGuid { get; }

        /// <summary>
        /// Gets the size of this class when serialized
        /// </summary>
        /// <returns></returns>
        public abstract int GetSize { get; }

        /// <summary>
        /// Clears the key
        /// </summary>
        public abstract void Clear();

        /// <summary>
        /// Reads the provided key from the stream.
        /// </summary>
        /// <param name="stream"></param>
        public abstract void Read(BinaryStreamBase stream);

        /// <summary>
        /// Writes the provided data to the BinaryWriter
        /// </summary>
        /// <param name="stream"></param>
        public abstract void Write(BinaryStreamBase stream);


    }
}
