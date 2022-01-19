﻿// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Framework;
using DocumentFormat.OpenXml.Framework.Metadata;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Validation.Schema;
using System;
using System.Collections.Generic;
using System.IO.Packaging;

namespace DocumentFormat.OpenXml.Office2021.MipLabelMetaData
{
    /// <summary>
    /// <para>Defines the ClassificationLabelList Class.</para>
    /// <para>This class is available in Office 2021 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is clbl:labelList.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2021.MipLabelMetaData.ClassificationExtensionList" /> <c>&lt;clbl:extLst></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2021.MipLabelMetaData.ClassificationLabel" /> <c>&lt;clbl:label></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("clbl:labelList")]
    public partial class ClassificationLabelList : OpenXmlPartRootElement
    {
        /// <summary>
        /// Initializes a new instance of the ClassificationLabelList class.
        /// </summary>
        public ClassificationLabelList() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the ClassificationLabelList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ClassificationLabelList(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ClassificationLabelList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ClassificationLabelList(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ClassificationLabelList class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public ClassificationLabelList(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("clbl:labelList");
            builder.Availability = FileFormatVersions.Office2021;
            builder.AddChild<DocumentFormat.OpenXml.Office2021.MipLabelMetaData.ClassificationExtensionList>();
            builder.AddChild<DocumentFormat.OpenXml.Office2021.MipLabelMetaData.ClassificationLabel>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2021.MipLabelMetaData.ClassificationLabel), 0, 0, version: FileFormatVersions.Office2021),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2021.MipLabelMetaData.ClassificationExtensionList), 0, 1, version: FileFormatVersions.Office2021)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ClassificationLabelList>(deep);

        internal ClassificationLabelList(LabelInfoPart ownerPart) : base(ownerPart)
        {
        }

        /// <summary>
        /// Loads the DOM from the LabelInfoPart
        /// </summary>
        /// <param name="openXmlPart">Specifies the part to be loaded.</param>
        public void Load(LabelInfoPart openXmlPart)
        {
            LoadFromPart(openXmlPart);
        }

        /// <summary>
        /// Saves the DOM into the LabelInfoPart.
        /// </summary>
        /// <param name="openXmlPart">Specifies the part to save to.</param>
        public void Save(LabelInfoPart openXmlPart)
        {
            base.SaveToPart(openXmlPart);
        }

        /// <summary>
        /// Gets the LabelInfoPart associated with this element.
        /// </summary>
        public LabelInfoPart? LabelInfoPart
        {
            get => OpenXmlPart as LabelInfoPart;
            internal set => OpenXmlPart = value;
        }
    }

    /// <summary>
    /// <para>Defines the ClassificationExtension Class.</para>
    /// <para>This class is available in Office 2021 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is clbl:ext.</para>
    /// </summary>
    [SchemaAttr("clbl:ext")]
    public partial class ClassificationExtension : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the ClassificationExtension class.
        /// </summary>
        public ClassificationExtension() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the ClassificationExtension class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ClassificationExtension(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ClassificationExtension class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ClassificationExtension(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ClassificationExtension class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public ClassificationExtension(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>uri, this property is only available in Office 2021 and later.</para>
        /// <para>Represents the following attribute in the schema: uri</para>
        /// </summary>
        [SchemaAttr("uri")]
        public StringValue? Uri
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("clbl:ext");
            builder.Availability = FileFormatVersions.Office2021;
            builder.AddElement<ClassificationExtension>()
                .AddAttribute("uri", a => a.Uri, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                    aBuilder.AddValidator(new StringValidator() { IsToken = (true) });
                });
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new AnyParticle(1, 1)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ClassificationExtension>(deep);
    }

    /// <summary>
    /// <para>Defines the ClassificationLabel Class.</para>
    /// <para>This class is available in Office 2021 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is clbl:label.</para>
    /// </summary>
    [SchemaAttr("clbl:label")]
    public partial class ClassificationLabel : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the ClassificationLabel class.
        /// </summary>
        public ClassificationLabel() : base()
        {
        }

        /// <summary>
        /// <para>id, this property is only available in Office 2021 and later.</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>
        [SchemaAttr("id")]
        public StringValue? Id
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>enabled, this property is only available in Office 2021 and later.</para>
        /// <para>Represents the following attribute in the schema: enabled</para>
        /// </summary>
        [SchemaAttr("enabled")]
        public BooleanValue? Enabled
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>setDate, this property is only available in Office 2021 and later.</para>
        /// <para>Represents the following attribute in the schema: setDate</para>
        /// </summary>
        [SchemaAttr("setDate")]
        public StringValue? SetDate
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>method, this property is only available in Office 2021 and later.</para>
        /// <para>Represents the following attribute in the schema: method</para>
        /// </summary>
        [SchemaAttr("method")]
        public StringValue? Method
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>name, this property is only available in Office 2021 and later.</para>
        /// <para>Represents the following attribute in the schema: name</para>
        /// </summary>
        [SchemaAttr("name")]
        public StringValue? Name
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>siteId, this property is only available in Office 2021 and later.</para>
        /// <para>Represents the following attribute in the schema: siteId</para>
        /// </summary>
        [SchemaAttr("siteId")]
        public StringValue? SiteId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>actionId, this property is only available in Office 2021 and later.</para>
        /// <para>Represents the following attribute in the schema: actionId</para>
        /// </summary>
        [SchemaAttr("actionId")]
        public StringValue? ActionId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>contentBits, this property is only available in Office 2021 and later.</para>
        /// <para>Represents the following attribute in the schema: contentBits</para>
        /// </summary>
        [SchemaAttr("contentBits")]
        public UInt32Value? ContentBits
        {
            get => GetAttribute<UInt32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>removed, this property is only available in Office 2021 and later.</para>
        /// <para>Represents the following attribute in the schema: removed</para>
        /// </summary>
        [SchemaAttr("removed")]
        public BooleanValue? Removed
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("clbl:label");
            builder.Availability = FileFormatVersions.Office2021;
            builder.AddElement<ClassificationLabel>()
                .AddAttribute("id", a => a.Id, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                })
                .AddAttribute("enabled", a => a.Enabled, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                })
                .AddAttribute("setDate", a => a.SetDate)
                .AddAttribute("method", a => a.Method, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                })
                .AddAttribute("name", a => a.Name)
                .AddAttribute("siteId", a => a.SiteId, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                    aBuilder.AddValidator(new StringValidator() { IsToken = (true), Pattern = ("\\{[0-9A-Fa-f]{8}-[0-9A-Fa-f]{4}-[0-9A-Fa-f]{4}-[0-9A-Fa-f]{4}-[0-9A-Fa-f]{12}\\}") });
                })
                .AddAttribute("actionId", a => a.ActionId)
                .AddAttribute("contentBits", a => a.ContentBits)
                .AddAttribute("removed", a => a.Removed, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                });
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ClassificationLabel>(deep);
    }

    /// <summary>
    /// <para>Defines the ClassificationExtensionList Class.</para>
    /// <para>This class is available in Office 2021 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is clbl:extLst.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2021.MipLabelMetaData.ClassificationExtension" /> <c>&lt;clbl:ext></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("clbl:extLst")]
    public partial class ClassificationExtensionList : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the ClassificationExtensionList class.
        /// </summary>
        public ClassificationExtensionList() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the ClassificationExtensionList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ClassificationExtensionList(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ClassificationExtensionList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ClassificationExtensionList(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ClassificationExtensionList class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public ClassificationExtensionList(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("clbl:extLst");
            builder.Availability = FileFormatVersions.Office2021;
            builder.AddChild<DocumentFormat.OpenXml.Office2021.MipLabelMetaData.ClassificationExtension>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2021.MipLabelMetaData.ClassificationExtension), 0, 0, version: FileFormatVersions.Office2021)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ClassificationExtensionList>(deep);
    }
}