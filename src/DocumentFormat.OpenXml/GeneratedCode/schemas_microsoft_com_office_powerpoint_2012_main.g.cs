﻿// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Drawing;
using DocumentFormat.OpenXml.Framework;
using DocumentFormat.OpenXml.Framework.Metadata;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Presentation;
using DocumentFormat.OpenXml.Validation.Schema;
using DocumentFormat.OpenXml.Validation.Semantic;
using System;
using System.Collections.Generic;
using System.IO.Packaging;

namespace DocumentFormat.OpenXml.Office2013.PowerPoint
{
    /// <summary>
    /// <para>Defines the PresetTransition Class.</para>
    /// <para>This class is available in Office 2013 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p15:prstTrans.</para>
    /// </summary>
    [SchemaAttr("p15:prstTrans")]
    public partial class PresetTransition : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the PresetTransition class.
        /// </summary>
        public PresetTransition() : base()
        {
        }

        /// <summary>
        /// <para>prst, this property is only available in Office 2013 and later.</para>
        /// <para>Represents the following attribute in the schema: prst</para>
        /// </summary>
        [SchemaAttr("prst")]
        public StringValue? Preset
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>invX, this property is only available in Office 2013 and later.</para>
        /// <para>Represents the following attribute in the schema: invX</para>
        /// </summary>
        [SchemaAttr("invX")]
        public BooleanValue? InvX
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>invY, this property is only available in Office 2013 and later.</para>
        /// <para>Represents the following attribute in the schema: invY</para>
        /// </summary>
        [SchemaAttr("invY")]
        public BooleanValue? InvY
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("p15:prstTrans");
            builder.Availability = FileFormatVersions.Office2013;
            builder.AddElement<PresetTransition>()
                .AddAttribute("prst", a => a.Preset)
                .AddAttribute("invX", a => a.InvX)
                .AddAttribute("invY", a => a.InvY);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<PresetTransition>(deep);
    }

    /// <summary>
    /// <para>Defines the PresenceInfo Class.</para>
    /// <para>This class is available in Office 2013 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p15:presenceInfo.</para>
    /// </summary>
    [SchemaAttr("p15:presenceInfo")]
    public partial class PresenceInfo : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the PresenceInfo class.
        /// </summary>
        public PresenceInfo() : base()
        {
        }

        /// <summary>
        /// <para>userId, this property is only available in Office 2013 and later.</para>
        /// <para>Represents the following attribute in the schema: userId</para>
        /// </summary>
        [SchemaAttr("userId")]
        public StringValue? UserId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>providerId, this property is only available in Office 2013 and later.</para>
        /// <para>Represents the following attribute in the schema: providerId</para>
        /// </summary>
        [SchemaAttr("providerId")]
        public StringValue? ProviderId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("p15:presenceInfo");
            builder.Availability = FileFormatVersions.Office2013;
            builder.AddElement<PresenceInfo>()
                .AddAttribute("userId", a => a.UserId, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                })
                .AddAttribute("providerId", a => a.ProviderId, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                });
            builder.AddConstraint(new AttributeValueLengthConstraint("p15:providerId", 1, 100) { Application = ApplicationType.PowerPoint, Version = FileFormatVersions.Office2013 });
            builder.AddConstraint(new AttributeValueLengthConstraint("p15:userId", 1, 300) { Application = ApplicationType.PowerPoint, Version = FileFormatVersions.Office2013 });
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<PresenceInfo>(deep);
    }

    /// <summary>
    /// <para>Defines the ThreadingInfo Class.</para>
    /// <para>This class is available in Office 2013 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p15:threadingInfo.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.PowerPoint.ParentCommentIdentifier" /> <c>&lt;p15:parentCm></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("p15:threadingInfo")]
    public partial class ThreadingInfo : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the ThreadingInfo class.
        /// </summary>
        public ThreadingInfo() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the ThreadingInfo class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ThreadingInfo(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ThreadingInfo class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ThreadingInfo(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ThreadingInfo class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public ThreadingInfo(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>timeZoneBias, this property is only available in Office 2013 and later.</para>
        /// <para>Represents the following attribute in the schema: timeZoneBias</para>
        /// </summary>
        [SchemaAttr("timeZoneBias")]
        public Int32Value? TimeZoneBias
        {
            get => GetAttribute<Int32Value>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("p15:threadingInfo");
            builder.Availability = FileFormatVersions.Office2013;
            builder.AddChild<DocumentFormat.OpenXml.Office2013.PowerPoint.ParentCommentIdentifier>();
            builder.AddElement<ThreadingInfo>()
                .AddAttribute("timeZoneBias", a => a.TimeZoneBias);
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.PowerPoint.ParentCommentIdentifier), 0, 1, version: FileFormatVersions.Office2013)
            };
        }

        /// <summary>
        /// <para>ParentCommentIdentifier.</para>
        /// <para>Represents the following element tag in the schema: p15:parentCm.</para>
        /// </summary>
        /// <remark>
        /// xmlns:p15 = http://schemas.microsoft.com/office/powerpoint/2012/main
        /// </remark>
        public DocumentFormat.OpenXml.Office2013.PowerPoint.ParentCommentIdentifier? ParentCommentIdentifier
        {
            get => GetElement<DocumentFormat.OpenXml.Office2013.PowerPoint.ParentCommentIdentifier>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ThreadingInfo>(deep);
    }

    /// <summary>
    /// <para>Defines the SlideGuideList Class.</para>
    /// <para>This class is available in Office 2013 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p15:sldGuideLst.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.PowerPoint.ExtensionList" /> <c>&lt;p15:extLst></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.PowerPoint.ExtendedGuide" /> <c>&lt;p15:guide></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("p15:sldGuideLst")]
    public partial class SlideGuideList : ExtendedGuideList
    {
        /// <summary>
        /// Initializes a new instance of the SlideGuideList class.
        /// </summary>
        public SlideGuideList() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the SlideGuideList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public SlideGuideList(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the SlideGuideList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public SlideGuideList(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the SlideGuideList class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public SlideGuideList(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("p15:sldGuideLst");
            builder.Availability = FileFormatVersions.Office2013;
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.PowerPoint.ExtendedGuide), 0, 0, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.PowerPoint.ExtensionList), 0, 1, version: FileFormatVersions.Office2013)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<SlideGuideList>(deep);
    }

    /// <summary>
    /// <para>Defines the NotesGuideList Class.</para>
    /// <para>This class is available in Office 2013 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p15:notesGuideLst.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.PowerPoint.ExtensionList" /> <c>&lt;p15:extLst></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.PowerPoint.ExtendedGuide" /> <c>&lt;p15:guide></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("p15:notesGuideLst")]
    public partial class NotesGuideList : ExtendedGuideList
    {
        /// <summary>
        /// Initializes a new instance of the NotesGuideList class.
        /// </summary>
        public NotesGuideList() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the NotesGuideList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public NotesGuideList(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the NotesGuideList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public NotesGuideList(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the NotesGuideList class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public NotesGuideList(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("p15:notesGuideLst");
            builder.Availability = FileFormatVersions.Office2013;
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.PowerPoint.ExtendedGuide), 0, 0, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.PowerPoint.ExtensionList), 0, 1, version: FileFormatVersions.Office2013)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<NotesGuideList>(deep);
    }

    /// <summary>
    /// <para>Defines the ExtendedGuideList Class.</para>
    /// <para>This class is available in Office 2013 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is :.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.PowerPoint.ExtensionList" /> <c>&lt;p15:extLst></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.PowerPoint.ExtendedGuide" /> <c>&lt;p15:guide></c></description></item>
    /// </list>
    /// </remark>
    public abstract partial class ExtendedGuideList : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the ExtendedGuideList class.
        /// </summary>
        protected ExtendedGuideList() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the ExtendedGuideList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        protected ExtendedGuideList(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ExtendedGuideList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        protected ExtendedGuideList(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ExtendedGuideList class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        protected ExtendedGuideList(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.AddChild<DocumentFormat.OpenXml.Office2013.PowerPoint.ExtensionList>();
            builder.AddChild<DocumentFormat.OpenXml.Office2013.PowerPoint.ExtendedGuide>();
        }
    }

    /// <summary>
    /// <para>Defines the ChartTrackingReferenceBased Class.</para>
    /// <para>This class is available in Office 2013 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p15:chartTrackingRefBased.</para>
    /// </summary>
    [SchemaAttr("p15:chartTrackingRefBased")]
    public partial class ChartTrackingReferenceBased : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the ChartTrackingReferenceBased class.
        /// </summary>
        public ChartTrackingReferenceBased() : base()
        {
        }

        /// <summary>
        /// <para>val, this property is only available in Office 2013 and later.</para>
        /// <para>Represents the following attribute in the schema: val</para>
        /// </summary>
        [SchemaAttr("val")]
        public BooleanValue? Val
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("p15:chartTrackingRefBased");
            builder.Availability = FileFormatVersions.Office2013;
            builder.AddElement<ChartTrackingReferenceBased>()
                .AddAttribute("val", a => a.Val, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                });
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ChartTrackingReferenceBased>(deep);
    }

    /// <summary>
    /// <para>Defines the ParentCommentIdentifier Class.</para>
    /// <para>This class is available in Office 2013 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p15:parentCm.</para>
    /// </summary>
    [SchemaAttr("p15:parentCm")]
    public partial class ParentCommentIdentifier : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the ParentCommentIdentifier class.
        /// </summary>
        public ParentCommentIdentifier() : base()
        {
        }

        /// <summary>
        /// <para>authorId, this property is only available in Office 2013 and later.</para>
        /// <para>Represents the following attribute in the schema: authorId</para>
        /// </summary>
        [SchemaAttr("authorId")]
        public UInt32Value? AuthorId
        {
            get => GetAttribute<UInt32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>idx, this property is only available in Office 2013 and later.</para>
        /// <para>Represents the following attribute in the schema: idx</para>
        /// </summary>
        [SchemaAttr("idx")]
        public UInt32Value? Index
        {
            get => GetAttribute<UInt32Value>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("p15:parentCm");
            builder.Availability = FileFormatVersions.Office2013;
            builder.AddElement<ParentCommentIdentifier>()
                .AddAttribute("authorId", a => a.AuthorId)
                .AddAttribute("idx", a => a.Index);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ParentCommentIdentifier>(deep);
    }

    /// <summary>
    /// <para>Defines the ColorType Class.</para>
    /// <para>This class is available in Office 2013 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p15:clr.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.HslColor" /> <c>&lt;a:hslClr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.PresetColor" /> <c>&lt;a:prstClr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.SchemeColor" /> <c>&lt;a:schemeClr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.RgbColorModelPercentage" /> <c>&lt;a:scrgbClr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.RgbColorModelHex" /> <c>&lt;a:srgbClr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.SystemColor" /> <c>&lt;a:sysClr></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("p15:clr")]
    public partial class ColorType : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the ColorType class.
        /// </summary>
        public ColorType() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the ColorType class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ColorType(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ColorType class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ColorType(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ColorType class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public ColorType(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("p15:clr");
            builder.Availability = FileFormatVersions.Office2013;
            builder.AddChild<DocumentFormat.OpenXml.Drawing.HslColor>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.PresetColor>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.SchemeColor>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.RgbColorModelPercentage>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.RgbColorModelHex>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.SystemColor>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new CompositeParticle.Builder(ParticleType.Group, 1, 1)
                {
                    new CompositeParticle.Builder(ParticleType.Choice, 1, 1)
                    {
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.RgbColorModelPercentage), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.RgbColorModelHex), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.HslColor), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.SystemColor), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.SchemeColor), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.PresetColor), 1, 1)
                    }
                }
            };
        }

        /// <summary>
        /// <para>RGB Color Model - Percentage Variant.</para>
        /// <para>Represents the following element tag in the schema: a:scrgbClr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.RgbColorModelPercentage? RgbColorModelPercentage
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.RgbColorModelPercentage>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>RGB Color Model - Hex Variant.</para>
        /// <para>Represents the following element tag in the schema: a:srgbClr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.RgbColorModelHex? RgbColorModelHex
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.RgbColorModelHex>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Hue, Saturation, Luminance Color Model.</para>
        /// <para>Represents the following element tag in the schema: a:hslClr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.HslColor? HslColor
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.HslColor>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>System Color.</para>
        /// <para>Represents the following element tag in the schema: a:sysClr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.SystemColor? SystemColor
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.SystemColor>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Scheme Color.</para>
        /// <para>Represents the following element tag in the schema: a:schemeClr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.SchemeColor? SchemeColor
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.SchemeColor>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Preset Color.</para>
        /// <para>Represents the following element tag in the schema: a:prstClr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.PresetColor? PresetColor
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.PresetColor>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ColorType>(deep);
    }

    /// <summary>
    /// <para>Defines the ExtensionList Class.</para>
    /// <para>This class is available in Office 2013 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p15:extLst.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Presentation.Extension" /> <c>&lt;p:ext></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("p15:extLst")]
    public partial class ExtensionList : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the ExtensionList class.
        /// </summary>
        public ExtensionList() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the ExtensionList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ExtensionList(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ExtensionList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ExtensionList(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ExtensionList class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public ExtensionList(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("p15:extLst");
            builder.Availability = FileFormatVersions.Office2013;
            builder.AddChild<DocumentFormat.OpenXml.Presentation.Extension>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new CompositeParticle.Builder(ParticleType.Group, 0, 1)
                {
                    new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
                    {
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.Extension), 0, 0)
                    }
                }
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ExtensionList>(deep);
    }

    /// <summary>
    /// <para>Defines the ExtendedGuide Class.</para>
    /// <para>This class is available in Office 2013 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p15:guide.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.PowerPoint.ColorType" /> <c>&lt;p15:clr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.PowerPoint.ExtensionList" /> <c>&lt;p15:extLst></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("p15:guide")]
    public partial class ExtendedGuide : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the ExtendedGuide class.
        /// </summary>
        public ExtendedGuide() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the ExtendedGuide class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ExtendedGuide(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ExtendedGuide class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ExtendedGuide(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ExtendedGuide class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public ExtendedGuide(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>id, this property is only available in Office 2013 and later.</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>
        [SchemaAttr("id")]
        public UInt32Value? Id
        {
            get => GetAttribute<UInt32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>name, this property is only available in Office 2013 and later.</para>
        /// <para>Represents the following attribute in the schema: name</para>
        /// </summary>
        [SchemaAttr("name")]
        public StringValue? Name
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>orient, this property is only available in Office 2013 and later.</para>
        /// <para>Represents the following attribute in the schema: orient</para>
        /// </summary>
        [SchemaAttr("orient")]
        public EnumValue<DocumentFormat.OpenXml.Presentation.DirectionValues>? Orientation
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Presentation.DirectionValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>pos, this property is only available in Office 2013 and later.</para>
        /// <para>Represents the following attribute in the schema: pos</para>
        /// </summary>
        [SchemaAttr("pos")]
        public Int32Value? Position
        {
            get => GetAttribute<Int32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>userDrawn, this property is only available in Office 2013 and later.</para>
        /// <para>Represents the following attribute in the schema: userDrawn</para>
        /// </summary>
        [SchemaAttr("userDrawn")]
        public BooleanValue? IsUserDrawn
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("p15:guide");
            builder.Availability = FileFormatVersions.Office2013;
            builder.AddChild<DocumentFormat.OpenXml.Office2013.PowerPoint.ColorType>();
            builder.AddChild<DocumentFormat.OpenXml.Office2013.PowerPoint.ExtensionList>();
            builder.AddElement<ExtendedGuide>()
                .AddAttribute("id", a => a.Id, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                })
                .AddAttribute("name", a => a.Name)
                .AddAttribute("orient", a => a.Orientation, aBuilder =>
                {
                    aBuilder.AddValidator(new StringValidator() { IsToken = (true) });
                })
                .AddAttribute("pos", a => a.Position)
                .AddAttribute("userDrawn", a => a.IsUserDrawn);
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.PowerPoint.ColorType), 1, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.PowerPoint.ExtensionList), 0, 1, version: FileFormatVersions.Office2013)
            };
        }

        /// <summary>
        /// <para>ColorType.</para>
        /// <para>Represents the following element tag in the schema: p15:clr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:p15 = http://schemas.microsoft.com/office/powerpoint/2012/main
        /// </remark>
        public DocumentFormat.OpenXml.Office2013.PowerPoint.ColorType? ColorType
        {
            get => GetElement<DocumentFormat.OpenXml.Office2013.PowerPoint.ColorType>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>ExtensionList.</para>
        /// <para>Represents the following element tag in the schema: p15:extLst.</para>
        /// </summary>
        /// <remark>
        /// xmlns:p15 = http://schemas.microsoft.com/office/powerpoint/2012/main
        /// </remark>
        public DocumentFormat.OpenXml.Office2013.PowerPoint.ExtensionList? ExtensionList
        {
            get => GetElement<DocumentFormat.OpenXml.Office2013.PowerPoint.ExtensionList>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ExtendedGuide>(deep);
    }
}