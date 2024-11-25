// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.IO;
using System.Xml;
using System.Xml.Linq;
using Azure.Core;

namespace xml_service.Models
{
    public partial class SignedIdentifier : IXmlSerializable, IPersistableModel<SignedIdentifier>
    {
        private void WriteInternal(XmlWriter writer, string nameHint, ModelReaderWriterOptions options)
        {
            writer.WriteStartElement(nameHint ?? "SignedIdentifier");
            writer.WriteStartElement("Id");
            writer.WriteValue(Id);
            writer.WriteEndElement();
            writer.WriteObjectValue(AccessPolicy, "AccessPolicy");
            writer.WriteEndElement();
        }

        void IXmlSerializable.Write(XmlWriter writer, string nameHint) => WriteInternal(writer, nameHint, ModelSerializationExtensions.WireOptions);

        internal static SignedIdentifier DeserializeSignedIdentifier(XElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            string id = default;
            AccessPolicy accessPolicy = default;
            if (element.Element("Id") is XElement idElement)
            {
                id = (string)idElement;
            }
            if (element.Element("AccessPolicy") is XElement accessPolicyElement)
            {
                accessPolicy = AccessPolicy.DeserializeAccessPolicy(accessPolicyElement);
            }
            return new SignedIdentifier(id, accessPolicy, serializedAdditionalRawData: null);
        }

        BinaryData IPersistableModel<SignedIdentifier>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SignedIdentifier>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "X":
                    {
                        using MemoryStream stream = new MemoryStream();
                        using XmlWriter writer = XmlWriter.Create(stream);
                        WriteInternal(writer, null, options);
                        writer.Flush();
                        return new BinaryData(stream.GetBuffer().AsMemory(0, (int)stream.Position));
                    }
                default:
                    throw new FormatException($"The model {nameof(SignedIdentifier)} does not support writing '{options.Format}' format.");
            }
        }

        SignedIdentifier IPersistableModel<SignedIdentifier>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SignedIdentifier>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "X":
                    return DeserializeSignedIdentifier(XElement.Load(data.ToStream()), options);
                default:
                    throw new FormatException($"The model {nameof(SignedIdentifier)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<SignedIdentifier>.GetFormatFromOptions(ModelReaderWriterOptions options) => "X";
    }
}