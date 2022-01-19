﻿// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Drawing;
using DocumentFormat.OpenXml.Drawing.ChartDrawing;
using DocumentFormat.OpenXml.Drawing.Charts;
using DocumentFormat.OpenXml.Framework;
using DocumentFormat.OpenXml.Framework.Metadata;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Validation.Schema;
using System;
using System.Collections.Generic;
using System.IO.Packaging;

namespace DocumentFormat.OpenXml.Office2010.Drawing.Charts
{
    /// <summary>
    /// <para>Defines the PivotOptions Class.</para>
    /// <para>This class is available in Office 2010 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c14:pivotOptions.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.Drawing.Charts.DropZoneFilter" /> <c>&lt;c14:dropZoneFilter></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.Drawing.Charts.DropZoneCategories" /> <c>&lt;c14:dropZoneCategories></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.Drawing.Charts.DropZoneData" /> <c>&lt;c14:dropZoneData></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.Drawing.Charts.DropZoneSeries" /> <c>&lt;c14:dropZoneSeries></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.Drawing.Charts.DropZonesVisible" /> <c>&lt;c14:dropZonesVisible></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("c14:pivotOptions")]
    public partial class PivotOptions : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the PivotOptions class.
        /// </summary>
        public PivotOptions() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the PivotOptions class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public PivotOptions(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the PivotOptions class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public PivotOptions(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the PivotOptions class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public PivotOptions(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("c14:pivotOptions");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddChild<DocumentFormat.OpenXml.Office2010.Drawing.Charts.DropZoneFilter>();
            builder.AddChild<DocumentFormat.OpenXml.Office2010.Drawing.Charts.DropZoneCategories>();
            builder.AddChild<DocumentFormat.OpenXml.Office2010.Drawing.Charts.DropZoneData>();
            builder.AddChild<DocumentFormat.OpenXml.Office2010.Drawing.Charts.DropZoneSeries>();
            builder.AddChild<DocumentFormat.OpenXml.Office2010.Drawing.Charts.DropZonesVisible>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Drawing.Charts.DropZoneFilter), 0, 1, version: FileFormatVersions.Office2010),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Drawing.Charts.DropZoneCategories), 0, 1, version: FileFormatVersions.Office2010),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Drawing.Charts.DropZoneData), 0, 1, version: FileFormatVersions.Office2010),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Drawing.Charts.DropZoneSeries), 0, 1, version: FileFormatVersions.Office2010),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Drawing.Charts.DropZonesVisible), 0, 1, version: FileFormatVersions.Office2010)
            };
        }

        /// <summary>
        /// <para>DropZoneFilter.</para>
        /// <para>Represents the following element tag in the schema: c14:dropZoneFilter.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c14 = http://schemas.microsoft.com/office/drawing/2007/8/2/chart
        /// </remark>
        public DocumentFormat.OpenXml.Office2010.Drawing.Charts.DropZoneFilter? DropZoneFilter
        {
            get => GetElement<DocumentFormat.OpenXml.Office2010.Drawing.Charts.DropZoneFilter>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>DropZoneCategories.</para>
        /// <para>Represents the following element tag in the schema: c14:dropZoneCategories.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c14 = http://schemas.microsoft.com/office/drawing/2007/8/2/chart
        /// </remark>
        public DocumentFormat.OpenXml.Office2010.Drawing.Charts.DropZoneCategories? DropZoneCategories
        {
            get => GetElement<DocumentFormat.OpenXml.Office2010.Drawing.Charts.DropZoneCategories>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>DropZoneData.</para>
        /// <para>Represents the following element tag in the schema: c14:dropZoneData.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c14 = http://schemas.microsoft.com/office/drawing/2007/8/2/chart
        /// </remark>
        public DocumentFormat.OpenXml.Office2010.Drawing.Charts.DropZoneData? DropZoneData
        {
            get => GetElement<DocumentFormat.OpenXml.Office2010.Drawing.Charts.DropZoneData>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>DropZoneSeries.</para>
        /// <para>Represents the following element tag in the schema: c14:dropZoneSeries.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c14 = http://schemas.microsoft.com/office/drawing/2007/8/2/chart
        /// </remark>
        public DocumentFormat.OpenXml.Office2010.Drawing.Charts.DropZoneSeries? DropZoneSeries
        {
            get => GetElement<DocumentFormat.OpenXml.Office2010.Drawing.Charts.DropZoneSeries>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>DropZonesVisible.</para>
        /// <para>Represents the following element tag in the schema: c14:dropZonesVisible.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c14 = http://schemas.microsoft.com/office/drawing/2007/8/2/chart
        /// </remark>
        public DocumentFormat.OpenXml.Office2010.Drawing.Charts.DropZonesVisible? DropZonesVisible
        {
            get => GetElement<DocumentFormat.OpenXml.Office2010.Drawing.Charts.DropZonesVisible>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<PivotOptions>(deep);
    }

    /// <summary>
    /// <para>Defines the SketchOptions Class.</para>
    /// <para>This class is available in Office 2010 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c14:sketchOptions.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.Drawing.Charts.InSketchMode" /> <c>&lt;c14:inSketchMode></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.Drawing.Charts.ShowSketchButton" /> <c>&lt;c14:showSketchBtn></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("c14:sketchOptions")]
    public partial class SketchOptions : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the SketchOptions class.
        /// </summary>
        public SketchOptions() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the SketchOptions class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public SketchOptions(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the SketchOptions class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public SketchOptions(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the SketchOptions class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public SketchOptions(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("c14:sketchOptions");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddChild<DocumentFormat.OpenXml.Office2010.Drawing.Charts.InSketchMode>();
            builder.AddChild<DocumentFormat.OpenXml.Office2010.Drawing.Charts.ShowSketchButton>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Drawing.Charts.InSketchMode), 0, 1, version: FileFormatVersions.Office2010),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Drawing.Charts.ShowSketchButton), 0, 1, version: FileFormatVersions.Office2010)
            };
        }

        /// <summary>
        /// <para>InSketchMode.</para>
        /// <para>Represents the following element tag in the schema: c14:inSketchMode.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c14 = http://schemas.microsoft.com/office/drawing/2007/8/2/chart
        /// </remark>
        public DocumentFormat.OpenXml.Office2010.Drawing.Charts.InSketchMode? InSketchMode
        {
            get => GetElement<DocumentFormat.OpenXml.Office2010.Drawing.Charts.InSketchMode>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>ShowSketchButton.</para>
        /// <para>Represents the following element tag in the schema: c14:showSketchBtn.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c14 = http://schemas.microsoft.com/office/drawing/2007/8/2/chart
        /// </remark>
        public DocumentFormat.OpenXml.Office2010.Drawing.Charts.ShowSketchButton? ShowSketchButton
        {
            get => GetElement<DocumentFormat.OpenXml.Office2010.Drawing.Charts.ShowSketchButton>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<SketchOptions>(deep);
    }

    /// <summary>
    /// <para>Defines the InvertSolidFillFormat Class.</para>
    /// <para>This class is available in Office 2010 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c14:invertSolidFillFmt.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.Drawing.Charts.ShapeProperties" /> <c>&lt;c14:spPr></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("c14:invertSolidFillFmt")]
    public partial class InvertSolidFillFormat : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the InvertSolidFillFormat class.
        /// </summary>
        public InvertSolidFillFormat() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the InvertSolidFillFormat class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public InvertSolidFillFormat(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the InvertSolidFillFormat class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public InvertSolidFillFormat(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the InvertSolidFillFormat class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public InvertSolidFillFormat(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("c14:invertSolidFillFmt");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddChild<DocumentFormat.OpenXml.Office2010.Drawing.Charts.ShapeProperties>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Drawing.Charts.ShapeProperties), 1, 1, version: FileFormatVersions.Office2010)
            };
        }

        /// <summary>
        /// <para>ShapeProperties.</para>
        /// <para>Represents the following element tag in the schema: c14:spPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c14 = http://schemas.microsoft.com/office/drawing/2007/8/2/chart
        /// </remark>
        public DocumentFormat.OpenXml.Office2010.Drawing.Charts.ShapeProperties? ShapeProperties
        {
            get => GetElement<DocumentFormat.OpenXml.Office2010.Drawing.Charts.ShapeProperties>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<InvertSolidFillFormat>(deep);
    }

    /// <summary>
    /// <para>Defines the Style Class.</para>
    /// <para>This class is available in Office 2010 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c14:style.</para>
    /// </summary>
    [SchemaAttr("c14:style")]
    public partial class Style : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the Style class.
        /// </summary>
        public Style() : base()
        {
        }

        /// <summary>
        /// <para>val, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: val</para>
        /// </summary>
        [SchemaAttr("val")]
        public ByteValue? Val
        {
            get => GetAttribute<ByteValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("c14:style");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddElement<Style>()
                .AddAttribute("val", a => a.Val, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                    aBuilder.AddValidator(new NumberValidator() { MinInclusive = (101L), MaxInclusive = (148L) });
                });
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Style>(deep);
    }

    /// <summary>
    /// <para>Defines the ShapeProperties Class.</para>
    /// <para>This class is available in Office 2010 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c14:spPr.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.BlipFill" /> <c>&lt;a:blipFill></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.CustomGeometry" /> <c>&lt;a:custGeom></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.EffectDag" /> <c>&lt;a:effectDag></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.EffectList" /> <c>&lt;a:effectLst></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.GradientFill" /> <c>&lt;a:gradFill></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.GroupFill" /> <c>&lt;a:grpFill></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Outline" /> <c>&lt;a:ln></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.NoFill" /> <c>&lt;a:noFill></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.PatternFill" /> <c>&lt;a:pattFill></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.PresetGeometry" /> <c>&lt;a:prstGeom></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Scene3DType" /> <c>&lt;a:scene3d></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Shape3DType" /> <c>&lt;a:sp3d></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.ShapePropertiesExtensionList" /> <c>&lt;a:extLst></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.SolidFill" /> <c>&lt;a:solidFill></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Transform2D" /> <c>&lt;a:xfrm></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("c14:spPr")]
    public partial class ShapeProperties : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the ShapeProperties class.
        /// </summary>
        public ShapeProperties() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the ShapeProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ShapeProperties(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ShapeProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ShapeProperties(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ShapeProperties class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public ShapeProperties(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>Black and White Mode</para>
        /// <para>Represents the following attribute in the schema: bwMode</para>
        /// </summary>
        [SchemaAttr("bwMode")]
        public EnumValue<DocumentFormat.OpenXml.Drawing.BlackWhiteModeValues>? BlackWhiteMode
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Drawing.BlackWhiteModeValues>>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("c14:spPr");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddChild<DocumentFormat.OpenXml.Drawing.BlipFill>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.CustomGeometry>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.EffectDag>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.EffectList>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.GradientFill>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.GroupFill>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Outline>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.NoFill>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.PatternFill>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.PresetGeometry>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Scene3DType>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Shape3DType>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.ShapePropertiesExtensionList>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.SolidFill>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Transform2D>();
            builder.AddElement<ShapeProperties>()
                .AddAttribute("bwMode", a => a.BlackWhiteMode, aBuilder =>
                {
                    aBuilder.AddValidator(new StringValidator() { IsToken = (true) });
                });
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Transform2D), 0, 1),
                new CompositeParticle.Builder(ParticleType.Group, 0, 1)
                {
                    new CompositeParticle.Builder(ParticleType.Choice, 1, 1)
                    {
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.CustomGeometry), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.PresetGeometry), 1, 1)
                    }
                },
                new CompositeParticle.Builder(ParticleType.Group, 0, 1)
                {
                    new CompositeParticle.Builder(ParticleType.Choice, 1, 1)
                    {
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.NoFill), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.SolidFill), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.GradientFill), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.BlipFill), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.PatternFill), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.GroupFill), 1, 1)
                    }
                },
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Outline), 0, 1),
                new CompositeParticle.Builder(ParticleType.Group, 0, 1)
                {
                    new CompositeParticle.Builder(ParticleType.Choice, 1, 1)
                    {
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.EffectList), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.EffectDag), 1, 1)
                    }
                },
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Scene3DType), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Shape3DType), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.ShapePropertiesExtensionList), 0, 1)
            };
        }

        /// <summary>
        /// <para>2D Transform for Individual Objects.</para>
        /// <para>Represents the following element tag in the schema: a:xfrm.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.Transform2D? Transform2D
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.Transform2D>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ShapeProperties>(deep);
    }

    /// <summary>
    /// <para>Defines the DropZoneFilter Class.</para>
    /// <para>This class is available in Office 2010 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c14:dropZoneFilter.</para>
    /// </summary>
    [SchemaAttr("c14:dropZoneFilter")]
    public partial class DropZoneFilter : BooleanFalseType
    {
        /// <summary>
        /// Initializes a new instance of the DropZoneFilter class.
        /// </summary>
        public DropZoneFilter() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("c14:dropZoneFilter");
            builder.Availability = FileFormatVersions.Office2010;
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<DropZoneFilter>(deep);
    }

    /// <summary>
    /// <para>Defines the DropZoneCategories Class.</para>
    /// <para>This class is available in Office 2010 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c14:dropZoneCategories.</para>
    /// </summary>
    [SchemaAttr("c14:dropZoneCategories")]
    public partial class DropZoneCategories : BooleanFalseType
    {
        /// <summary>
        /// Initializes a new instance of the DropZoneCategories class.
        /// </summary>
        public DropZoneCategories() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("c14:dropZoneCategories");
            builder.Availability = FileFormatVersions.Office2010;
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<DropZoneCategories>(deep);
    }

    /// <summary>
    /// <para>Defines the DropZoneData Class.</para>
    /// <para>This class is available in Office 2010 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c14:dropZoneData.</para>
    /// </summary>
    [SchemaAttr("c14:dropZoneData")]
    public partial class DropZoneData : BooleanFalseType
    {
        /// <summary>
        /// Initializes a new instance of the DropZoneData class.
        /// </summary>
        public DropZoneData() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("c14:dropZoneData");
            builder.Availability = FileFormatVersions.Office2010;
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<DropZoneData>(deep);
    }

    /// <summary>
    /// <para>Defines the DropZoneSeries Class.</para>
    /// <para>This class is available in Office 2010 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c14:dropZoneSeries.</para>
    /// </summary>
    [SchemaAttr("c14:dropZoneSeries")]
    public partial class DropZoneSeries : BooleanFalseType
    {
        /// <summary>
        /// Initializes a new instance of the DropZoneSeries class.
        /// </summary>
        public DropZoneSeries() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("c14:dropZoneSeries");
            builder.Availability = FileFormatVersions.Office2010;
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<DropZoneSeries>(deep);
    }

    /// <summary>
    /// <para>Defines the DropZonesVisible Class.</para>
    /// <para>This class is available in Office 2010 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c14:dropZonesVisible.</para>
    /// </summary>
    [SchemaAttr("c14:dropZonesVisible")]
    public partial class DropZonesVisible : BooleanFalseType
    {
        /// <summary>
        /// Initializes a new instance of the DropZonesVisible class.
        /// </summary>
        public DropZonesVisible() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("c14:dropZonesVisible");
            builder.Availability = FileFormatVersions.Office2010;
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<DropZonesVisible>(deep);
    }

    /// <summary>
    /// <para>Defines the InSketchMode Class.</para>
    /// <para>This class is available in Office 2010 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c14:inSketchMode.</para>
    /// </summary>
    [SchemaAttr("c14:inSketchMode")]
    public partial class InSketchMode : BooleanFalseType
    {
        /// <summary>
        /// Initializes a new instance of the InSketchMode class.
        /// </summary>
        public InSketchMode() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("c14:inSketchMode");
            builder.Availability = FileFormatVersions.Office2010;
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<InSketchMode>(deep);
    }

    /// <summary>
    /// <para>Defines the BooleanFalseType Class.</para>
    /// <para>This class is available in Office 2010 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is :.</para>
    /// </summary>
    public abstract partial class BooleanFalseType : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the BooleanFalseType class.
        /// </summary>
        protected BooleanFalseType() : base()
        {
        }

        /// <summary>
        /// <para>val, this property is only available in Office 2010 and later.</para>
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
            builder.AddElement<BooleanFalseType>()
                .AddAttribute("val", a => a.Val);
        }
    }

    /// <summary>
    /// <para>Defines the ShowSketchButton Class.</para>
    /// <para>This class is available in Office 2010 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c14:showSketchBtn.</para>
    /// </summary>
    [SchemaAttr("c14:showSketchBtn")]
    public partial class ShowSketchButton : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the ShowSketchButton class.
        /// </summary>
        public ShowSketchButton() : base()
        {
        }

        /// <summary>
        /// <para>val, this property is only available in Office 2010 and later.</para>
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
            builder.SetSchema("c14:showSketchBtn");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddElement<ShowSketchButton>()
                .AddAttribute("val", a => a.Val);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ShowSketchButton>(deep);
    }
}