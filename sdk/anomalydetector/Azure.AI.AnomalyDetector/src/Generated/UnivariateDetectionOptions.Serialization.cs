// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.AI.AnomalyDetector
{
    public partial class UnivariateDetectionOptions : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("series");
            writer.WriteStartArray();
            foreach (var item in Series)
            {
                writer.WriteObjectValue(item);
            }
            writer.WriteEndArray();
            if (Optional.IsDefined(Granularity))
            {
                if (Granularity != null)
                {
                    writer.WritePropertyName("granularity");
                    writer.WriteStringValue(Granularity.Value.ToSerialString());
                }
                else
                {
                    writer.WriteNull("granularity");
                }
            }
            if (Optional.IsDefined(CustomInterval))
            {
                if (CustomInterval != null)
                {
                    writer.WritePropertyName("customInterval");
                    writer.WriteNumberValue(CustomInterval.Value);
                }
                else
                {
                    writer.WriteNull("customInterval");
                }
            }
            if (Optional.IsDefined(Period))
            {
                if (Period != null)
                {
                    writer.WritePropertyName("period");
                    writer.WriteNumberValue(Period.Value);
                }
                else
                {
                    writer.WriteNull("period");
                }
            }
            if (Optional.IsDefined(MaxAnomalyRatio))
            {
                if (MaxAnomalyRatio != null)
                {
                    writer.WritePropertyName("maxAnomalyRatio");
                    writer.WriteNumberValue(MaxAnomalyRatio.Value);
                }
                else
                {
                    writer.WriteNull("maxAnomalyRatio");
                }
            }
            if (Optional.IsDefined(Sensitivity))
            {
                if (Sensitivity != null)
                {
                    writer.WritePropertyName("sensitivity");
                    writer.WriteNumberValue(Sensitivity.Value);
                }
                else
                {
                    writer.WriteNull("sensitivity");
                }
            }
            if (Optional.IsDefined(ImputeMode))
            {
                if (ImputeMode != null)
                {
                    writer.WritePropertyName("imputeMode");
                    writer.WriteStringValue(ImputeMode.Value.ToString());
                }
                else
                {
                    writer.WriteNull("imputeMode");
                }
            }
            if (Optional.IsDefined(ImputeFixedValue))
            {
                if (ImputeFixedValue != null)
                {
                    writer.WritePropertyName("imputeFixedValue");
                    writer.WriteNumberValue(ImputeFixedValue.Value);
                }
                else
                {
                    writer.WriteNull("imputeFixedValue");
                }
            }
            writer.WriteEndObject();
        }

        /// <summary> Convert into a Utf8JsonRequestContent. </summary>
        internal virtual RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this);
            return content;
        }
    }
}
