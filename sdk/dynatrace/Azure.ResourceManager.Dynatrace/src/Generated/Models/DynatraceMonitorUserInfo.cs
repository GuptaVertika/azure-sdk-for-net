// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Dynatrace.Models
{
    /// <summary> User info. </summary>
    public partial class DynatraceMonitorUserInfo
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="DynatraceMonitorUserInfo"/>. </summary>
        public DynatraceMonitorUserInfo()
        {
        }

        /// <summary> Initializes a new instance of <see cref="DynatraceMonitorUserInfo"/>. </summary>
        /// <param name="firstName"> First Name of the user. </param>
        /// <param name="lastName"> Last Name of the user. </param>
        /// <param name="emailAddress"> Email of the user used by Dynatrace for contacting them if needed. </param>
        /// <param name="phoneNumber"> Phone number of the user used by Dynatrace for contacting them if needed. </param>
        /// <param name="country"> Country of the user. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal DynatraceMonitorUserInfo(string firstName, string lastName, string emailAddress, string phoneNumber, string country, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            FirstName = firstName;
            LastName = lastName;
            EmailAddress = emailAddress;
            PhoneNumber = phoneNumber;
            Country = country;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> First Name of the user. </summary>
        public string FirstName { get; set; }
        /// <summary> Last Name of the user. </summary>
        public string LastName { get; set; }
        /// <summary> Email of the user used by Dynatrace for contacting them if needed. </summary>
        public string EmailAddress { get; set; }
        /// <summary> Phone number of the user used by Dynatrace for contacting them if needed. </summary>
        public string PhoneNumber { get; set; }
        /// <summary> Country of the user. </summary>
        public string Country { get; set; }
    }
}
