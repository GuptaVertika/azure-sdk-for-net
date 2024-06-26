// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Maps.Search.Models
{
    /// <summary> The type of entry point. Value can be either _main_ or _minor_. </summary>
    public readonly partial struct EntryPointType : IEquatable<EntryPointType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="EntryPointType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public EntryPointType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string MainValue = "main";
        private const string MinorValue = "minor";

        /// <summary> main. </summary>
        public static EntryPointType Main { get; } = new EntryPointType(MainValue);
        /// <summary> minor. </summary>
        public static EntryPointType Minor { get; } = new EntryPointType(MinorValue);
        /// <summary> Determines if two <see cref="EntryPointType"/> values are the same. </summary>
        public static bool operator ==(EntryPointType left, EntryPointType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="EntryPointType"/> values are not the same. </summary>
        public static bool operator !=(EntryPointType left, EntryPointType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="EntryPointType"/>. </summary>
        public static implicit operator EntryPointType(string value) => new EntryPointType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is EntryPointType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(EntryPointType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
