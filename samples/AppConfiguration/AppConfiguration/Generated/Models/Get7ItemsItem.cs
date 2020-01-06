// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.ComponentModel;

namespace AppConfiguration.Models.V10
{
    /// <summary> MISSING·SCHEMA-DESCRIPTION-CHOICE. </summary>
    public readonly partial struct Get7ItemsItem : IEquatable<Get7ItemsItem>
    {
        private readonly string? _value;

        /// <summary> Determines if two <see cref="Get7ItemsItem"/> values are the same. </summary>
        public Get7ItemsItem(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string KeyValue = "key";
        private const string LabelValue = "label";
        private const string ContentTypeValue = "content_type";
        private const string ValueValue = "value";
        private const string LastModifiedValue = "last_modified";
        private const string TagsValue = "tags";
        private const string LockedValue = "locked";
        private const string EtagValue = "etag";

        /// <summary> key. </summary>
        public static Get7ItemsItem Key { get; } = new Get7ItemsItem(KeyValue);
        /// <summary> label. </summary>
        public static Get7ItemsItem Label { get; } = new Get7ItemsItem(LabelValue);
        /// <summary> content_type. </summary>
        public static Get7ItemsItem ContentType { get; } = new Get7ItemsItem(ContentTypeValue);
        /// <summary> value. </summary>
        public static Get7ItemsItem Value { get; } = new Get7ItemsItem(ValueValue);
        /// <summary> last_modified. </summary>
        public static Get7ItemsItem LastModified { get; } = new Get7ItemsItem(LastModifiedValue);
        /// <summary> tags. </summary>
        public static Get7ItemsItem Tags { get; } = new Get7ItemsItem(TagsValue);
        /// <summary> locked. </summary>
        public static Get7ItemsItem Locked { get; } = new Get7ItemsItem(LockedValue);
        /// <summary> etag. </summary>
        public static Get7ItemsItem Etag { get; } = new Get7ItemsItem(EtagValue);
        /// <summary> Determines if two <see cref="Get7ItemsItem"/> values are the same. </summary>
        public static bool operator ==(Get7ItemsItem left, Get7ItemsItem right) => left.Equals(right);
        /// <summary> Determines if two <see cref="Get7ItemsItem"/> values are not the same. </summary>
        public static bool operator !=(Get7ItemsItem left, Get7ItemsItem right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="Get7ItemsItem"/>. </summary>
        public static implicit operator Get7ItemsItem(string value) => new Get7ItemsItem(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object? obj) => obj is Get7ItemsItem other && Equals(other);
        /// <inheritdoc />
        public bool Equals(Get7ItemsItem other) => string.Equals(_value, other._value, StringComparison.Ordinal);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string? ToString() => _value;
    }
}