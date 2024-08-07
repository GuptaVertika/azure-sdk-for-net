// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Search.Documents.Indexes.Models
{
    /// <summary> Defines the sequence of characters to use between the lines of text recognized by the OCR skill. The default value is "space". </summary>
    public readonly partial struct LineEnding : IEquatable<LineEnding>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="LineEnding"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public LineEnding(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string SpaceValue = "space";
        private const string CarriageReturnValue = "carriageReturn";
        private const string LineFeedValue = "lineFeed";
        private const string CarriageReturnLineFeedValue = "carriageReturnLineFeed";

        /// <summary> Lines are separated by a single space character. </summary>
        public static LineEnding Space { get; } = new LineEnding(SpaceValue);
        /// <summary> Lines are separated by a carriage return ('\r') character. </summary>
        public static LineEnding CarriageReturn { get; } = new LineEnding(CarriageReturnValue);
        /// <summary> Lines are separated by a single line feed ('\n') character. </summary>
        public static LineEnding LineFeed { get; } = new LineEnding(LineFeedValue);
        /// <summary> Lines are separated by a carriage return and a line feed ('\r\n') character. </summary>
        public static LineEnding CarriageReturnLineFeed { get; } = new LineEnding(CarriageReturnLineFeedValue);
        /// <summary> Determines if two <see cref="LineEnding"/> values are the same. </summary>
        public static bool operator ==(LineEnding left, LineEnding right) => left.Equals(right);
        /// <summary> Determines if two <see cref="LineEnding"/> values are not the same. </summary>
        public static bool operator !=(LineEnding left, LineEnding right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="LineEnding"/>. </summary>
        public static implicit operator LineEnding(string value) => new LineEnding(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is LineEnding other && Equals(other);
        /// <inheritdoc />
        public bool Equals(LineEnding other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
