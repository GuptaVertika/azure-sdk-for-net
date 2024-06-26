// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Monitor.Models
{
    /// <summary>
    /// The condition that results in the alert rule being activated.
    /// Please note <see cref="AlertRuleCondition"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="LocationThresholdRuleCondition"/>, <see cref="ManagementEventRuleCondition"/> and <see cref="ThresholdRuleCondition"/>.
    /// </summary>
    public abstract partial class AlertRuleCondition
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
        private protected IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="AlertRuleCondition"/>. </summary>
        protected AlertRuleCondition()
        {
        }

        /// <summary> Initializes a new instance of <see cref="AlertRuleCondition"/>. </summary>
        /// <param name="odataType"> specifies the type of condition. This can be one of three types: ManagementEventRuleCondition (occurrences of management events), LocationThresholdRuleCondition (based on the number of failures of a web test), and ThresholdRuleCondition (based on the threshold of a metric). </param>
        /// <param name="dataSource">
        /// the resource from which the rule collects its data. For this type dataSource will always be of type RuleMetricDataSource.
        /// Please note <see cref="RuleDataSource"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="RuleManagementEventDataSource"/> and <see cref="RuleMetricDataSource"/>.
        /// </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal AlertRuleCondition(string odataType, RuleDataSource dataSource, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            OdataType = odataType;
            DataSource = dataSource;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> specifies the type of condition. This can be one of three types: ManagementEventRuleCondition (occurrences of management events), LocationThresholdRuleCondition (based on the number of failures of a web test), and ThresholdRuleCondition (based on the threshold of a metric). </summary>
        internal string OdataType { get; set; }
        /// <summary>
        /// the resource from which the rule collects its data. For this type dataSource will always be of type RuleMetricDataSource.
        /// Please note <see cref="RuleDataSource"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="RuleManagementEventDataSource"/> and <see cref="RuleMetricDataSource"/>.
        /// </summary>
        public RuleDataSource DataSource { get; set; }
    }
}
