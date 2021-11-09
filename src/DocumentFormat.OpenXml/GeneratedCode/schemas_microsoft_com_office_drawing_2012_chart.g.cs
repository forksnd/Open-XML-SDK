﻿// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

#nullable enable

using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Drawing;
using DocumentFormat.OpenXml.Drawing.Charts;
using DocumentFormat.OpenXml.Framework;
using DocumentFormat.OpenXml.Framework.Metadata;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Validation.Schema;
using System;
using System.Collections.Generic;
using System.IO.Packaging;

namespace DocumentFormat.OpenXml.Office2013.Drawing.Chart
{
    /// <summary>
    /// <para>Defines the PivotSource Class.</para>
    /// <para>This class is available in Office 2013 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c15:pivotSource.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Charts.ExtensionList" /> <c>&lt;c:extLst></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Charts.FormatId" /> <c>&lt;c:fmtId></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Charts.PivotTableName" /> <c>&lt;c:name></c></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(64, "pivotSource")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class PivotSource : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the PivotSource class.
        /// </summary>
        public PivotSource() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the PivotSource class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public PivotSource(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the PivotSource class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public PivotSource(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the PivotSource class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public PivotSource(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(64, "pivotSource");
            builder.Availability = FileFormatVersions.Office2013;
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Charts.ExtensionList>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Charts.FormatId>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Charts.PivotTableName>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.PivotTableName), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.FormatId), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.ExtensionList), 0, 1)
            };
        }

        /// <summary>
        /// <para>Pivot Name.</para>
        /// <para>Represents the following element tag in the schema: c:name.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.Charts.PivotTableName? PivotTableName
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.Charts.PivotTableName>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Format ID.</para>
        /// <para>Represents the following element tag in the schema: c:fmtId.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.Charts.FormatId? FormatId
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.Charts.FormatId>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Chart Extensibility.</para>
        /// <para>Represents the following element tag in the schema: c:extLst.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.Charts.ExtensionList? ExtensionList
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.Charts.ExtensionList>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<PivotSource>(deep);
    }

    /// <summary>
    /// <para>Defines the NumberingFormat Class.</para>
    /// <para>This class is available in Office 2013 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c15:numFmt.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(64, "numFmt")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class NumberingFormat : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the NumberingFormat class.
        /// </summary>
        public NumberingFormat() : base()
        {
        }

        /// <summary>
        /// <para>Number Format Code</para>
        /// <para>Represents the following attribute in the schema: formatCode</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "formatCode")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? FormatCode
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Linked to Source</para>
        /// <para>Represents the following attribute in the schema: sourceLinked</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "sourceLinked")]
#pragma warning restore CS0618 // Type or member is obsolete

        public BooleanValue? SourceLinked
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(64, "numFmt");
            builder.Availability = FileFormatVersions.Office2013;
            builder.AddElement<NumberingFormat>()
.AddAttribute(0, "formatCode", a => a.FormatCode, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
})
.AddAttribute(0, "sourceLinked", a => a.SourceLinked);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<NumberingFormat>(deep);
    }

    /// <summary>
    /// <para>Defines the ShapeProperties Class.</para>
    /// <para>This class is available in Office 2013 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c15:spPr.</para>
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
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(64, "spPr")]
#pragma warning restore CS0618 // Type or member is obsolete
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

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "bwMode")]
#pragma warning restore CS0618 // Type or member is obsolete

        public EnumValue<DocumentFormat.OpenXml.Drawing.BlackWhiteModeValues>? BlackWhiteMode
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Drawing.BlackWhiteModeValues>>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(64, "spPr");
            builder.Availability = FileFormatVersions.Office2013;
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
.AddAttribute(0, "bwMode", a => a.BlackWhiteMode, aBuilder =>
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
    /// <para>Defines the Layout Class.</para>
    /// <para>This class is available in Office 2013 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c15:layout.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Charts.ExtensionList" /> <c>&lt;c:extLst></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Charts.ManualLayout" /> <c>&lt;c:manualLayout></c></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(64, "layout")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class Layout : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the Layout class.
        /// </summary>
        public Layout() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Layout class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Layout(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Layout class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Layout(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Layout class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public Layout(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(64, "layout");
            builder.Availability = FileFormatVersions.Office2013;
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Charts.ExtensionList>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Charts.ManualLayout>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.ManualLayout), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.ExtensionList), 0, 1)
            };
        }

        /// <summary>
        /// <para>Manual Layout.</para>
        /// <para>Represents the following element tag in the schema: c:manualLayout.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.Charts.ManualLayout? ManualLayout
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.Charts.ManualLayout>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Chart Extensibility.</para>
        /// <para>Represents the following element tag in the schema: c:extLst.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.Charts.ExtensionList? ExtensionList
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.Charts.ExtensionList>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Layout>(deep);
    }

    /// <summary>
    /// <para>Defines the FullReference Class.</para>
    /// <para>This class is available in Office 2013 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c15:fullRef.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.Chart.SequenceOfReferences" /> <c>&lt;c15:sqref></c></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(64, "fullRef")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class FullReference : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the FullReference class.
        /// </summary>
        public FullReference() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the FullReference class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public FullReference(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the FullReference class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public FullReference(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the FullReference class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public FullReference(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(64, "fullRef");
            builder.Availability = FileFormatVersions.Office2013;
            builder.AddChild<DocumentFormat.OpenXml.Office2013.Drawing.Chart.SequenceOfReferences>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.Chart.SequenceOfReferences), 1, 1, version: FileFormatVersions.Office2013)
            };
        }

        /// <summary>
        /// <para>SequenceOfReferences.</para>
        /// <para>Represents the following element tag in the schema: c15:sqref.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c15 = http://schemas.microsoft.com/office/drawing/2012/chart
        /// </remark>
        public DocumentFormat.OpenXml.Office2013.Drawing.Chart.SequenceOfReferences? SequenceOfReferences
        {
            get => GetElement<DocumentFormat.OpenXml.Office2013.Drawing.Chart.SequenceOfReferences>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<FullReference>(deep);
    }

    /// <summary>
    /// <para>Defines the LevelReference Class.</para>
    /// <para>This class is available in Office 2013 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c15:levelRef.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.Chart.SequenceOfReferences" /> <c>&lt;c15:sqref></c></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(64, "levelRef")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class LevelReference : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the LevelReference class.
        /// </summary>
        public LevelReference() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the LevelReference class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public LevelReference(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the LevelReference class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public LevelReference(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the LevelReference class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public LevelReference(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(64, "levelRef");
            builder.Availability = FileFormatVersions.Office2013;
            builder.AddChild<DocumentFormat.OpenXml.Office2013.Drawing.Chart.SequenceOfReferences>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.Chart.SequenceOfReferences), 1, 1, version: FileFormatVersions.Office2013)
            };
        }

        /// <summary>
        /// <para>SequenceOfReferences.</para>
        /// <para>Represents the following element tag in the schema: c15:sqref.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c15 = http://schemas.microsoft.com/office/drawing/2012/chart
        /// </remark>
        public DocumentFormat.OpenXml.Office2013.Drawing.Chart.SequenceOfReferences? SequenceOfReferences
        {
            get => GetElement<DocumentFormat.OpenXml.Office2013.Drawing.Chart.SequenceOfReferences>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<LevelReference>(deep);
    }

    /// <summary>
    /// <para>Defines the FormulaReference Class.</para>
    /// <para>This class is available in Office 2013 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c15:formulaRef.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.Chart.SequenceOfReferences" /> <c>&lt;c15:sqref></c></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(64, "formulaRef")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class FormulaReference : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the FormulaReference class.
        /// </summary>
        public FormulaReference() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the FormulaReference class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public FormulaReference(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the FormulaReference class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public FormulaReference(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the FormulaReference class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public FormulaReference(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(64, "formulaRef");
            builder.Availability = FileFormatVersions.Office2013;
            builder.AddChild<DocumentFormat.OpenXml.Office2013.Drawing.Chart.SequenceOfReferences>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.Chart.SequenceOfReferences), 1, 1, version: FileFormatVersions.Office2013)
            };
        }

        /// <summary>
        /// <para>SequenceOfReferences.</para>
        /// <para>Represents the following element tag in the schema: c15:sqref.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c15 = http://schemas.microsoft.com/office/drawing/2012/chart
        /// </remark>
        public DocumentFormat.OpenXml.Office2013.Drawing.Chart.SequenceOfReferences? SequenceOfReferences
        {
            get => GetElement<DocumentFormat.OpenXml.Office2013.Drawing.Chart.SequenceOfReferences>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<FormulaReference>(deep);
    }

    /// <summary>
    /// <para>Defines the FilteredSeriesTitle Class.</para>
    /// <para>This class is available in Office 2013 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c15:filteredSeriesTitle.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.Chart.ChartText" /> <c>&lt;c15:tx></c></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(64, "filteredSeriesTitle")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class FilteredSeriesTitle : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the FilteredSeriesTitle class.
        /// </summary>
        public FilteredSeriesTitle() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the FilteredSeriesTitle class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public FilteredSeriesTitle(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the FilteredSeriesTitle class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public FilteredSeriesTitle(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the FilteredSeriesTitle class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public FilteredSeriesTitle(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(64, "filteredSeriesTitle");
            builder.Availability = FileFormatVersions.Office2013;
            builder.AddChild<DocumentFormat.OpenXml.Office2013.Drawing.Chart.ChartText>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.Chart.ChartText), 1, 1, version: FileFormatVersions.Office2013)
            };
        }

        /// <summary>
        /// <para>ChartText.</para>
        /// <para>Represents the following element tag in the schema: c15:tx.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c15 = http://schemas.microsoft.com/office/drawing/2012/chart
        /// </remark>
        public DocumentFormat.OpenXml.Office2013.Drawing.Chart.ChartText? ChartText
        {
            get => GetElement<DocumentFormat.OpenXml.Office2013.Drawing.Chart.ChartText>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<FilteredSeriesTitle>(deep);
    }

    /// <summary>
    /// <para>Defines the FilteredCategoryTitle Class.</para>
    /// <para>This class is available in Office 2013 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c15:filteredCategoryTitle.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.Chart.AxisDataSourceType" /> <c>&lt;c15:cat></c></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(64, "filteredCategoryTitle")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class FilteredCategoryTitle : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the FilteredCategoryTitle class.
        /// </summary>
        public FilteredCategoryTitle() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the FilteredCategoryTitle class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public FilteredCategoryTitle(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the FilteredCategoryTitle class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public FilteredCategoryTitle(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the FilteredCategoryTitle class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public FilteredCategoryTitle(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(64, "filteredCategoryTitle");
            builder.Availability = FileFormatVersions.Office2013;
            builder.AddChild<DocumentFormat.OpenXml.Office2013.Drawing.Chart.AxisDataSourceType>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.Chart.AxisDataSourceType), 1, 1, version: FileFormatVersions.Office2013)
            };
        }

        /// <summary>
        /// <para>AxisDataSourceType.</para>
        /// <para>Represents the following element tag in the schema: c15:cat.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c15 = http://schemas.microsoft.com/office/drawing/2012/chart
        /// </remark>
        public DocumentFormat.OpenXml.Office2013.Drawing.Chart.AxisDataSourceType? AxisDataSourceType
        {
            get => GetElement<DocumentFormat.OpenXml.Office2013.Drawing.Chart.AxisDataSourceType>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<FilteredCategoryTitle>(deep);
    }

    /// <summary>
    /// <para>Defines the FilteredAreaSeries Class.</para>
    /// <para>This class is available in Office 2013 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c15:filteredAreaSeries.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.Chart.AreaChartSeries" /> <c>&lt;c15:ser></c></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(64, "filteredAreaSeries")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class FilteredAreaSeries : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the FilteredAreaSeries class.
        /// </summary>
        public FilteredAreaSeries() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the FilteredAreaSeries class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public FilteredAreaSeries(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the FilteredAreaSeries class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public FilteredAreaSeries(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the FilteredAreaSeries class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public FilteredAreaSeries(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(64, "filteredAreaSeries");
            builder.Availability = FileFormatVersions.Office2013;
            builder.AddChild<DocumentFormat.OpenXml.Office2013.Drawing.Chart.AreaChartSeries>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.Chart.AreaChartSeries), 1, 1, version: FileFormatVersions.Office2013)
            };
        }

        /// <summary>
        /// <para>AreaChartSeries.</para>
        /// <para>Represents the following element tag in the schema: c15:ser.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c15 = http://schemas.microsoft.com/office/drawing/2012/chart
        /// </remark>
        public DocumentFormat.OpenXml.Office2013.Drawing.Chart.AreaChartSeries? AreaChartSeries
        {
            get => GetElement<DocumentFormat.OpenXml.Office2013.Drawing.Chart.AreaChartSeries>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<FilteredAreaSeries>(deep);
    }

    /// <summary>
    /// <para>Defines the FilteredBarSeries Class.</para>
    /// <para>This class is available in Office 2013 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c15:filteredBarSeries.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.Chart.BarChartSeries" /> <c>&lt;c15:ser></c></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(64, "filteredBarSeries")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class FilteredBarSeries : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the FilteredBarSeries class.
        /// </summary>
        public FilteredBarSeries() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the FilteredBarSeries class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public FilteredBarSeries(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the FilteredBarSeries class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public FilteredBarSeries(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the FilteredBarSeries class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public FilteredBarSeries(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(64, "filteredBarSeries");
            builder.Availability = FileFormatVersions.Office2013;
            builder.AddChild<DocumentFormat.OpenXml.Office2013.Drawing.Chart.BarChartSeries>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.Chart.BarChartSeries), 1, 1, version: FileFormatVersions.Office2013)
            };
        }

        /// <summary>
        /// <para>BarChartSeries.</para>
        /// <para>Represents the following element tag in the schema: c15:ser.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c15 = http://schemas.microsoft.com/office/drawing/2012/chart
        /// </remark>
        public DocumentFormat.OpenXml.Office2013.Drawing.Chart.BarChartSeries? BarChartSeries
        {
            get => GetElement<DocumentFormat.OpenXml.Office2013.Drawing.Chart.BarChartSeries>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<FilteredBarSeries>(deep);
    }

    /// <summary>
    /// <para>Defines the FilteredBubbleSeries Class.</para>
    /// <para>This class is available in Office 2013 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c15:filteredBubbleSeries.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.Chart.BubbleChartSeries" /> <c>&lt;c15:ser></c></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(64, "filteredBubbleSeries")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class FilteredBubbleSeries : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the FilteredBubbleSeries class.
        /// </summary>
        public FilteredBubbleSeries() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the FilteredBubbleSeries class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public FilteredBubbleSeries(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the FilteredBubbleSeries class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public FilteredBubbleSeries(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the FilteredBubbleSeries class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public FilteredBubbleSeries(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(64, "filteredBubbleSeries");
            builder.Availability = FileFormatVersions.Office2013;
            builder.AddChild<DocumentFormat.OpenXml.Office2013.Drawing.Chart.BubbleChartSeries>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.Chart.BubbleChartSeries), 1, 1, version: FileFormatVersions.Office2013)
            };
        }

        /// <summary>
        /// <para>BubbleChartSeries.</para>
        /// <para>Represents the following element tag in the schema: c15:ser.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c15 = http://schemas.microsoft.com/office/drawing/2012/chart
        /// </remark>
        public DocumentFormat.OpenXml.Office2013.Drawing.Chart.BubbleChartSeries? BubbleChartSeries
        {
            get => GetElement<DocumentFormat.OpenXml.Office2013.Drawing.Chart.BubbleChartSeries>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<FilteredBubbleSeries>(deep);
    }

    /// <summary>
    /// <para>Defines the FilteredLineSeriesExtension Class.</para>
    /// <para>This class is available in Office 2013 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c15:filteredLineSeries.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.Chart.LineChartSeries" /> <c>&lt;c15:ser></c></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(64, "filteredLineSeries")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class FilteredLineSeriesExtension : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the FilteredLineSeriesExtension class.
        /// </summary>
        public FilteredLineSeriesExtension() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the FilteredLineSeriesExtension class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public FilteredLineSeriesExtension(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the FilteredLineSeriesExtension class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public FilteredLineSeriesExtension(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the FilteredLineSeriesExtension class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public FilteredLineSeriesExtension(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(64, "filteredLineSeries");
            builder.Availability = FileFormatVersions.Office2013;
            builder.AddChild<DocumentFormat.OpenXml.Office2013.Drawing.Chart.LineChartSeries>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.Chart.LineChartSeries), 1, 1, version: FileFormatVersions.Office2013)
            };
        }

        /// <summary>
        /// <para>LineChartSeries.</para>
        /// <para>Represents the following element tag in the schema: c15:ser.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c15 = http://schemas.microsoft.com/office/drawing/2012/chart
        /// </remark>
        public DocumentFormat.OpenXml.Office2013.Drawing.Chart.LineChartSeries? LineChartSeries
        {
            get => GetElement<DocumentFormat.OpenXml.Office2013.Drawing.Chart.LineChartSeries>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<FilteredLineSeriesExtension>(deep);
    }

    /// <summary>
    /// <para>Defines the FilteredPieSeries Class.</para>
    /// <para>This class is available in Office 2013 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c15:filteredPieSeries.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.Chart.PieChartSeries" /> <c>&lt;c15:ser></c></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(64, "filteredPieSeries")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class FilteredPieSeries : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the FilteredPieSeries class.
        /// </summary>
        public FilteredPieSeries() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the FilteredPieSeries class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public FilteredPieSeries(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the FilteredPieSeries class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public FilteredPieSeries(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the FilteredPieSeries class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public FilteredPieSeries(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(64, "filteredPieSeries");
            builder.Availability = FileFormatVersions.Office2013;
            builder.AddChild<DocumentFormat.OpenXml.Office2013.Drawing.Chart.PieChartSeries>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.Chart.PieChartSeries), 1, 1, version: FileFormatVersions.Office2013)
            };
        }

        /// <summary>
        /// <para>PieChartSeries.</para>
        /// <para>Represents the following element tag in the schema: c15:ser.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c15 = http://schemas.microsoft.com/office/drawing/2012/chart
        /// </remark>
        public DocumentFormat.OpenXml.Office2013.Drawing.Chart.PieChartSeries? PieChartSeries
        {
            get => GetElement<DocumentFormat.OpenXml.Office2013.Drawing.Chart.PieChartSeries>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<FilteredPieSeries>(deep);
    }

    /// <summary>
    /// <para>Defines the FilteredRadarSeries Class.</para>
    /// <para>This class is available in Office 2013 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c15:filteredRadarSeries.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.Chart.RadarChartSeries" /> <c>&lt;c15:ser></c></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(64, "filteredRadarSeries")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class FilteredRadarSeries : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the FilteredRadarSeries class.
        /// </summary>
        public FilteredRadarSeries() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the FilteredRadarSeries class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public FilteredRadarSeries(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the FilteredRadarSeries class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public FilteredRadarSeries(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the FilteredRadarSeries class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public FilteredRadarSeries(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(64, "filteredRadarSeries");
            builder.Availability = FileFormatVersions.Office2013;
            builder.AddChild<DocumentFormat.OpenXml.Office2013.Drawing.Chart.RadarChartSeries>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.Chart.RadarChartSeries), 1, 1, version: FileFormatVersions.Office2013)
            };
        }

        /// <summary>
        /// <para>RadarChartSeries.</para>
        /// <para>Represents the following element tag in the schema: c15:ser.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c15 = http://schemas.microsoft.com/office/drawing/2012/chart
        /// </remark>
        public DocumentFormat.OpenXml.Office2013.Drawing.Chart.RadarChartSeries? RadarChartSeries
        {
            get => GetElement<DocumentFormat.OpenXml.Office2013.Drawing.Chart.RadarChartSeries>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<FilteredRadarSeries>(deep);
    }

    /// <summary>
    /// <para>Defines the FilteredScatterSeries Class.</para>
    /// <para>This class is available in Office 2013 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c15:filteredScatterSeries.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.Chart.ScatterChartSeries" /> <c>&lt;c15:ser></c></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(64, "filteredScatterSeries")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class FilteredScatterSeries : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the FilteredScatterSeries class.
        /// </summary>
        public FilteredScatterSeries() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the FilteredScatterSeries class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public FilteredScatterSeries(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the FilteredScatterSeries class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public FilteredScatterSeries(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the FilteredScatterSeries class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public FilteredScatterSeries(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(64, "filteredScatterSeries");
            builder.Availability = FileFormatVersions.Office2013;
            builder.AddChild<DocumentFormat.OpenXml.Office2013.Drawing.Chart.ScatterChartSeries>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.Chart.ScatterChartSeries), 1, 1, version: FileFormatVersions.Office2013)
            };
        }

        /// <summary>
        /// <para>ScatterChartSeries.</para>
        /// <para>Represents the following element tag in the schema: c15:ser.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c15 = http://schemas.microsoft.com/office/drawing/2012/chart
        /// </remark>
        public DocumentFormat.OpenXml.Office2013.Drawing.Chart.ScatterChartSeries? ScatterChartSeries
        {
            get => GetElement<DocumentFormat.OpenXml.Office2013.Drawing.Chart.ScatterChartSeries>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<FilteredScatterSeries>(deep);
    }

    /// <summary>
    /// <para>Defines the FilteredSurfaceSeries Class.</para>
    /// <para>This class is available in Office 2013 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c15:filteredSurfaceSeries.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.Chart.SurfaceChartSeries" /> <c>&lt;c15:ser></c></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(64, "filteredSurfaceSeries")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class FilteredSurfaceSeries : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the FilteredSurfaceSeries class.
        /// </summary>
        public FilteredSurfaceSeries() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the FilteredSurfaceSeries class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public FilteredSurfaceSeries(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the FilteredSurfaceSeries class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public FilteredSurfaceSeries(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the FilteredSurfaceSeries class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public FilteredSurfaceSeries(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(64, "filteredSurfaceSeries");
            builder.Availability = FileFormatVersions.Office2013;
            builder.AddChild<DocumentFormat.OpenXml.Office2013.Drawing.Chart.SurfaceChartSeries>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.Chart.SurfaceChartSeries), 1, 1, version: FileFormatVersions.Office2013)
            };
        }

        /// <summary>
        /// <para>SurfaceChartSeries.</para>
        /// <para>Represents the following element tag in the schema: c15:ser.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c15 = http://schemas.microsoft.com/office/drawing/2012/chart
        /// </remark>
        public DocumentFormat.OpenXml.Office2013.Drawing.Chart.SurfaceChartSeries? SurfaceChartSeries
        {
            get => GetElement<DocumentFormat.OpenXml.Office2013.Drawing.Chart.SurfaceChartSeries>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<FilteredSurfaceSeries>(deep);
    }

    /// <summary>
    /// <para>Defines the DataLabelsRange Class.</para>
    /// <para>This class is available in Office 2013 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c15:datalabelsRange.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.Chart.DataLabelsRangeChache" /> <c>&lt;c15:dlblRangeCache></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.Chart.Formula" /> <c>&lt;c15:f></c></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(64, "datalabelsRange")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class DataLabelsRange : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the DataLabelsRange class.
        /// </summary>
        public DataLabelsRange() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the DataLabelsRange class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public DataLabelsRange(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the DataLabelsRange class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public DataLabelsRange(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the DataLabelsRange class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public DataLabelsRange(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(64, "datalabelsRange");
            builder.Availability = FileFormatVersions.Office2013;
            builder.AddChild<DocumentFormat.OpenXml.Office2013.Drawing.Chart.DataLabelsRangeChache>();
            builder.AddChild<DocumentFormat.OpenXml.Office2013.Drawing.Chart.Formula>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.Chart.Formula), 1, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.Chart.DataLabelsRangeChache), 0, 1, version: FileFormatVersions.Office2013)
            };
        }

        /// <summary>
        /// <para>Formula.</para>
        /// <para>Represents the following element tag in the schema: c15:f.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c15 = http://schemas.microsoft.com/office/drawing/2012/chart
        /// </remark>
        public DocumentFormat.OpenXml.Office2013.Drawing.Chart.Formula? Formula
        {
            get => GetElement<DocumentFormat.OpenXml.Office2013.Drawing.Chart.Formula>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>DataLabelsRangeChache.</para>
        /// <para>Represents the following element tag in the schema: c15:dlblRangeCache.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c15 = http://schemas.microsoft.com/office/drawing/2012/chart
        /// </remark>
        public DocumentFormat.OpenXml.Office2013.Drawing.Chart.DataLabelsRangeChache? DataLabelsRangeChache
        {
            get => GetElement<DocumentFormat.OpenXml.Office2013.Drawing.Chart.DataLabelsRangeChache>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<DataLabelsRange>(deep);
    }

    /// <summary>
    /// <para>Defines the CategoryFilterExceptions Class.</para>
    /// <para>This class is available in Office 2013 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c15:categoryFilterExceptions.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.Chart.CategoryFilterException" /> <c>&lt;c15:categoryFilterException></c></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(64, "categoryFilterExceptions")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class CategoryFilterExceptions : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the CategoryFilterExceptions class.
        /// </summary>
        public CategoryFilterExceptions() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the CategoryFilterExceptions class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public CategoryFilterExceptions(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the CategoryFilterExceptions class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public CategoryFilterExceptions(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the CategoryFilterExceptions class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public CategoryFilterExceptions(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(64, "categoryFilterExceptions");
            builder.Availability = FileFormatVersions.Office2013;
            builder.AddChild<DocumentFormat.OpenXml.Office2013.Drawing.Chart.CategoryFilterException>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.Chart.CategoryFilterException), 1, 0, version: FileFormatVersions.Office2013)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<CategoryFilterExceptions>(deep);
    }

    /// <summary>
    /// <para>Defines the DataLabelFieldTable Class.</para>
    /// <para>This class is available in Office 2013 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c15:dlblFieldTable.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.Chart.DataLabelFieldTableEntry" /> <c>&lt;c15:dlblFTEntry></c></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(64, "dlblFieldTable")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class DataLabelFieldTable : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the DataLabelFieldTable class.
        /// </summary>
        public DataLabelFieldTable() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the DataLabelFieldTable class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public DataLabelFieldTable(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the DataLabelFieldTable class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public DataLabelFieldTable(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the DataLabelFieldTable class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public DataLabelFieldTable(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(64, "dlblFieldTable");
            builder.Availability = FileFormatVersions.Office2013;
            builder.AddChild<DocumentFormat.OpenXml.Office2013.Drawing.Chart.DataLabelFieldTableEntry>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.Chart.DataLabelFieldTableEntry), 0, 0, version: FileFormatVersions.Office2013)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<DataLabelFieldTable>(deep);
    }

    /// <summary>
    /// <para>Defines the ExceptionForSave Class.</para>
    /// <para>This class is available in Office 2013 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c15:xForSave.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(64, "xForSave")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class ExceptionForSave : BooleanType
    {
        /// <summary>
        /// Initializes a new instance of the ExceptionForSave class.
        /// </summary>
        public ExceptionForSave() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(64, "xForSave");
            builder.Availability = FileFormatVersions.Office2013;
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ExceptionForSave>(deep);
    }

    /// <summary>
    /// <para>Defines the ShowDataLabelsRange Class.</para>
    /// <para>This class is available in Office 2013 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c15:showDataLabelsRange.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(64, "showDataLabelsRange")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class ShowDataLabelsRange : BooleanType
    {
        /// <summary>
        /// Initializes a new instance of the ShowDataLabelsRange class.
        /// </summary>
        public ShowDataLabelsRange() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(64, "showDataLabelsRange");
            builder.Availability = FileFormatVersions.Office2013;
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ShowDataLabelsRange>(deep);
    }

    /// <summary>
    /// <para>Defines the ShowLeaderLines Class.</para>
    /// <para>This class is available in Office 2013 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c15:showLeaderLines.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(64, "showLeaderLines")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class ShowLeaderLines : BooleanType
    {
        /// <summary>
        /// Initializes a new instance of the ShowLeaderLines class.
        /// </summary>
        public ShowLeaderLines() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(64, "showLeaderLines");
            builder.Availability = FileFormatVersions.Office2013;
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ShowLeaderLines>(deep);
    }

    /// <summary>
    /// <para>Defines the AutoGeneneratedCategories Class.</para>
    /// <para>This class is available in Office 2013 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c15:autoCat.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(64, "autoCat")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class AutoGeneneratedCategories : BooleanType
    {
        /// <summary>
        /// Initializes a new instance of the AutoGeneneratedCategories class.
        /// </summary>
        public AutoGeneneratedCategories() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(64, "autoCat");
            builder.Availability = FileFormatVersions.Office2013;
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<AutoGeneneratedCategories>(deep);
    }

    /// <summary>
    /// <para>Defines the InvertIfNegativeBoolean Class.</para>
    /// <para>This class is available in Office 2013 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c15:invertIfNegative.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(64, "invertIfNegative")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class InvertIfNegativeBoolean : BooleanType
    {
        /// <summary>
        /// Initializes a new instance of the InvertIfNegativeBoolean class.
        /// </summary>
        public InvertIfNegativeBoolean() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(64, "invertIfNegative");
            builder.Availability = FileFormatVersions.Office2013;
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<InvertIfNegativeBoolean>(deep);
    }

    /// <summary>
    /// <para>Defines the Bubble3D Class.</para>
    /// <para>This class is available in Office 2013 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c15:bubble3D.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(64, "bubble3D")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class Bubble3D : BooleanType
    {
        /// <summary>
        /// Initializes a new instance of the Bubble3D class.
        /// </summary>
        public Bubble3D() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(64, "bubble3D");
            builder.Availability = FileFormatVersions.Office2013;
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Bubble3D>(deep);
    }

    /// <summary>
    /// <para>Defines the BooleanType Class.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is :.</para>
    /// </summary>
    public abstract partial class BooleanType : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the BooleanType class.
        /// </summary>
        protected BooleanType() : base()
        {
        }

        /// <summary>
        /// <para>Boolean Value</para>
        /// <para>Represents the following attribute in the schema: val</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "val")]
#pragma warning restore CS0618 // Type or member is obsolete

        public BooleanValue? Val
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.AddElement<BooleanType>()
                           .AddAttribute(0, "val", a => a.Val);
        }
    }

    /// <summary>
    /// <para>Defines the ChartText Class.</para>
    /// <para>This class is available in Office 2013 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c15:tx.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Charts.RichText" /> <c>&lt;c:rich></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Charts.StringLiteral" /> <c>&lt;c:strLit></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Charts.StringReference" /> <c>&lt;c:strRef></c></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(64, "tx")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class ChartText : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the ChartText class.
        /// </summary>
        public ChartText() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the ChartText class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ChartText(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ChartText class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ChartText(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ChartText class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public ChartText(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(64, "tx");
            builder.Availability = FileFormatVersions.Office2013;
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Charts.RichText>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Charts.StringLiteral>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Charts.StringReference>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new CompositeParticle.Builder(ParticleType.Choice, 1, 1)
                {
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.StringReference), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.RichText), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.StringLiteral), 1, 1)
                }
            };
        }

        /// <summary>
        /// <para>String Reference.</para>
        /// <para>Represents the following element tag in the schema: c:strRef.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.Charts.StringReference? StringReference
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.Charts.StringReference>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Rich Text.</para>
        /// <para>Represents the following element tag in the schema: c:rich.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.Charts.RichText? RichText
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.Charts.RichText>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>String Literal.</para>
        /// <para>Represents the following element tag in the schema: c:strLit.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.Charts.StringLiteral? StringLiteral
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.Charts.StringLiteral>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ChartText>(deep);
    }

    /// <summary>
    /// <para>Defines the LeaderLines Class.</para>
    /// <para>This class is available in Office 2013 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c15:leaderLines.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties" /> <c>&lt;c:spPr></c></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(64, "leaderLines")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class LeaderLines : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the LeaderLines class.
        /// </summary>
        public LeaderLines() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the LeaderLines class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public LeaderLines(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the LeaderLines class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public LeaderLines(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the LeaderLines class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public LeaderLines(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(64, "leaderLines");
            builder.Availability = FileFormatVersions.Office2013;
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties), 0, 1)
            };
        }

        /// <summary>
        /// <para>ChartShapeProperties.</para>
        /// <para>Represents the following element tag in the schema: c:spPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties? ChartShapeProperties
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<LeaderLines>(deep);
    }

    /// <summary>
    /// <para>Defines the SequenceOfReferences Class.</para>
    /// <para>This class is available in Office 2013 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c15:sqref.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(64, "sqref")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class SequenceOfReferences : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the SequenceOfReferences class.
        /// </summary>
        public SequenceOfReferences() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the SequenceOfReferences class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public SequenceOfReferences(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new StringValue { InnerText = text };
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(64, "sqref");
            builder.Availability = FileFormatVersions.Office2013;
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<SequenceOfReferences>(deep);
    }

    /// <summary>
    /// <para>Defines the Formula Class.</para>
    /// <para>This class is available in Office 2013 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c15:f.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(64, "f")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class Formula : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the Formula class.
        /// </summary>
        public Formula() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Formula class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public Formula(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new StringValue { InnerText = text };
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(64, "f");
            builder.Availability = FileFormatVersions.Office2013;
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Formula>(deep);
    }

    /// <summary>
    /// <para>Defines the TextFieldGuid Class.</para>
    /// <para>This class is available in Office 2013 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c15:txfldGUID.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(64, "txfldGUID")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class TextFieldGuid : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the TextFieldGuid class.
        /// </summary>
        public TextFieldGuid() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the TextFieldGuid class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public TextFieldGuid(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new StringValue { InnerText = text };
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(64, "txfldGUID");
            builder.Availability = FileFormatVersions.Office2013;
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<TextFieldGuid>(deep);
    }

    /// <summary>
    /// <para>Defines the AxisDataSourceType Class.</para>
    /// <para>This class is available in Office 2013 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c15:cat.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Charts.MultiLevelStringReference" /> <c>&lt;c:multiLvlStrRef></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Charts.NumberLiteral" /> <c>&lt;c:numLit></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Charts.NumberReference" /> <c>&lt;c:numRef></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Charts.StringLiteral" /> <c>&lt;c:strLit></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Charts.StringReference" /> <c>&lt;c:strRef></c></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(64, "cat")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class AxisDataSourceType : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the AxisDataSourceType class.
        /// </summary>
        public AxisDataSourceType() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the AxisDataSourceType class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public AxisDataSourceType(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the AxisDataSourceType class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public AxisDataSourceType(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the AxisDataSourceType class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public AxisDataSourceType(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(64, "cat");
            builder.Availability = FileFormatVersions.Office2013;
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Charts.MultiLevelStringReference>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Charts.NumberLiteral>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Charts.NumberReference>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Charts.StringLiteral>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Charts.StringReference>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new CompositeParticle.Builder(ParticleType.Choice, 1, 1)
                {
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.MultiLevelStringReference), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.NumberReference), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.NumberLiteral), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.StringReference), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.StringLiteral), 1, 1)
                }
            };
        }

        /// <summary>
        /// <para>Multi Level String Reference.</para>
        /// <para>Represents the following element tag in the schema: c:multiLvlStrRef.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.Charts.MultiLevelStringReference? MultiLevelStringReference
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.Charts.MultiLevelStringReference>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Number Reference.</para>
        /// <para>Represents the following element tag in the schema: c:numRef.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.Charts.NumberReference? NumberReference
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.Charts.NumberReference>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Number Literal.</para>
        /// <para>Represents the following element tag in the schema: c:numLit.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.Charts.NumberLiteral? NumberLiteral
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.Charts.NumberLiteral>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>StringReference.</para>
        /// <para>Represents the following element tag in the schema: c:strRef.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.Charts.StringReference? StringReference
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.Charts.StringReference>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>String Literal.</para>
        /// <para>Represents the following element tag in the schema: c:strLit.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.Charts.StringLiteral? StringLiteral
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.Charts.StringLiteral>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<AxisDataSourceType>(deep);
    }

    /// <summary>
    /// <para>Defines the BarChartSeries Class.</para>
    /// <para>This class is available in Office 2013 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c15:ser.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties" /> <c>&lt;c:spPr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Charts.CategoryAxisData" /> <c>&lt;c:cat></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Charts.BarSerExtensionList" /> <c>&lt;c:extLst></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Charts.InvertIfNegative" /> <c>&lt;c:invertIfNegative></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Charts.DataLabels" /> <c>&lt;c:dLbls></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Charts.DataPoint" /> <c>&lt;c:dPt></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Charts.ErrorBars" /> <c>&lt;c:errBars></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Charts.Values" /> <c>&lt;c:val></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Charts.PictureOptions" /> <c>&lt;c:pictureOptions></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Charts.SeriesText" /> <c>&lt;c:tx></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Charts.Shape" /> <c>&lt;c:shape></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Charts.Trendline" /> <c>&lt;c:trendline></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Charts.Index" /> <c>&lt;c:idx></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Charts.Order" /> <c>&lt;c:order></c></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(64, "ser")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class BarChartSeries : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the BarChartSeries class.
        /// </summary>
        public BarChartSeries() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the BarChartSeries class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public BarChartSeries(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the BarChartSeries class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public BarChartSeries(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the BarChartSeries class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public BarChartSeries(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(64, "ser");
            builder.Availability = FileFormatVersions.Office2013;
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Charts.CategoryAxisData>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Charts.BarSerExtensionList>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Charts.InvertIfNegative>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Charts.DataLabels>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Charts.DataPoint>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Charts.ErrorBars>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Charts.Values>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Charts.PictureOptions>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Charts.SeriesText>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Charts.Shape>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Charts.Trendline>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Charts.Index>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Charts.Order>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new CompositeParticle.Builder(ParticleType.Group, 1, 1)
                {
                    new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
                    {
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.Index), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.Order), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.SeriesText), 0, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties), 0, 1)
                    }
                },
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.InvertIfNegative), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.PictureOptions), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.DataPoint), 0, 0),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.DataLabels), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.Trendline), 0, 0),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.ErrorBars), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.CategoryAxisData), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.Values), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.Shape), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.BarSerExtensionList), 0, 1)
            };
        }

        /// <summary>
        /// <para>Index.</para>
        /// <para>Represents the following element tag in the schema: c:idx.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.Charts.Index? Index
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.Charts.Index>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Order.</para>
        /// <para>Represents the following element tag in the schema: c:order.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.Charts.Order? Order
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.Charts.Order>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Series Text.</para>
        /// <para>Represents the following element tag in the schema: c:tx.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.Charts.SeriesText? SeriesText
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.Charts.SeriesText>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>ChartShapeProperties.</para>
        /// <para>Represents the following element tag in the schema: c:spPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties? ChartShapeProperties
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>InvertIfNegative.</para>
        /// <para>Represents the following element tag in the schema: c:invertIfNegative.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.Charts.InvertIfNegative? InvertIfNegative
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.Charts.InvertIfNegative>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>PictureOptions.</para>
        /// <para>Represents the following element tag in the schema: c:pictureOptions.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.Charts.PictureOptions? PictureOptions
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.Charts.PictureOptions>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<BarChartSeries>(deep);
    }

    /// <summary>
    /// <para>Defines the LineChartSeries Class.</para>
    /// <para>This class is available in Office 2013 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c15:ser.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties" /> <c>&lt;c:spPr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Charts.CategoryAxisData" /> <c>&lt;c:cat></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Charts.Smooth" /> <c>&lt;c:smooth></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Charts.DataLabels" /> <c>&lt;c:dLbls></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Charts.DataPoint" /> <c>&lt;c:dPt></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Charts.ErrorBars" /> <c>&lt;c:errBars></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Charts.LineSerExtensionList" /> <c>&lt;c:extLst></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Charts.Marker" /> <c>&lt;c:marker></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Charts.Values" /> <c>&lt;c:val></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Charts.PictureOptions" /> <c>&lt;c:pictureOptions></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Charts.SeriesText" /> <c>&lt;c:tx></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Charts.Trendline" /> <c>&lt;c:trendline></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Charts.Index" /> <c>&lt;c:idx></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Charts.Order" /> <c>&lt;c:order></c></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(64, "ser")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class LineChartSeries : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the LineChartSeries class.
        /// </summary>
        public LineChartSeries() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the LineChartSeries class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public LineChartSeries(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the LineChartSeries class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public LineChartSeries(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the LineChartSeries class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public LineChartSeries(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(64, "ser");
            builder.Availability = FileFormatVersions.Office2013;
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Charts.CategoryAxisData>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Charts.Smooth>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Charts.DataLabels>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Charts.DataPoint>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Charts.ErrorBars>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Charts.LineSerExtensionList>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Charts.Marker>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Charts.Values>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Charts.PictureOptions>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Charts.SeriesText>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Charts.Trendline>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Charts.Index>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Charts.Order>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new CompositeParticle.Builder(ParticleType.Group, 1, 1)
                {
                    new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
                    {
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.Index), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.Order), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.SeriesText), 0, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties), 0, 1)
                    }
                },
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.Marker), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.PictureOptions), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.DataPoint), 0, 0),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.DataLabels), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.Trendline), 0, 0),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.ErrorBars), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.CategoryAxisData), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.Values), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.Smooth), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.LineSerExtensionList), 0, 1)
            };
        }

        /// <summary>
        /// <para>Index.</para>
        /// <para>Represents the following element tag in the schema: c:idx.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.Charts.Index? Index
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.Charts.Index>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Order.</para>
        /// <para>Represents the following element tag in the schema: c:order.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.Charts.Order? Order
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.Charts.Order>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Series Text.</para>
        /// <para>Represents the following element tag in the schema: c:tx.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.Charts.SeriesText? SeriesText
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.Charts.SeriesText>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>ChartShapeProperties.</para>
        /// <para>Represents the following element tag in the schema: c:spPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties? ChartShapeProperties
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Marker.</para>
        /// <para>Represents the following element tag in the schema: c:marker.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.Charts.Marker? Marker
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.Charts.Marker>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>PictureOptions.</para>
        /// <para>Represents the following element tag in the schema: c:pictureOptions.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.Charts.PictureOptions? PictureOptions
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.Charts.PictureOptions>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<LineChartSeries>(deep);
    }

    /// <summary>
    /// <para>Defines the ScatterChartSeries Class.</para>
    /// <para>This class is available in Office 2013 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c15:ser.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties" /> <c>&lt;c:spPr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Charts.XValues" /> <c>&lt;c:xVal></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Charts.Smooth" /> <c>&lt;c:smooth></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Charts.DataLabels" /> <c>&lt;c:dLbls></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Charts.DataPoint" /> <c>&lt;c:dPt></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Charts.ErrorBars" /> <c>&lt;c:errBars></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Charts.Marker" /> <c>&lt;c:marker></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Charts.YValues" /> <c>&lt;c:yVal></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Charts.ScatterSerExtensionList" /> <c>&lt;c:extLst></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Charts.SeriesText" /> <c>&lt;c:tx></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Charts.Trendline" /> <c>&lt;c:trendline></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Charts.Index" /> <c>&lt;c:idx></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Charts.Order" /> <c>&lt;c:order></c></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(64, "ser")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class ScatterChartSeries : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the ScatterChartSeries class.
        /// </summary>
        public ScatterChartSeries() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the ScatterChartSeries class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ScatterChartSeries(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ScatterChartSeries class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ScatterChartSeries(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ScatterChartSeries class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public ScatterChartSeries(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(64, "ser");
            builder.Availability = FileFormatVersions.Office2013;
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Charts.XValues>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Charts.Smooth>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Charts.DataLabels>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Charts.DataPoint>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Charts.ErrorBars>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Charts.Marker>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Charts.YValues>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Charts.ScatterSerExtensionList>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Charts.SeriesText>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Charts.Trendline>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Charts.Index>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Charts.Order>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new CompositeParticle.Builder(ParticleType.Group, 1, 1)
                {
                    new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
                    {
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.Index), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.Order), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.SeriesText), 0, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties), 0, 1)
                    }
                },
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.Marker), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.DataPoint), 0, 0),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.DataLabels), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.Trendline), 0, 0),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.ErrorBars), 0, 2),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.XValues), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.YValues), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.Smooth), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.ScatterSerExtensionList), 0, 1)
            };
        }

        /// <summary>
        /// <para>Index.</para>
        /// <para>Represents the following element tag in the schema: c:idx.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.Charts.Index? Index
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.Charts.Index>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Order.</para>
        /// <para>Represents the following element tag in the schema: c:order.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.Charts.Order? Order
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.Charts.Order>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Series Text.</para>
        /// <para>Represents the following element tag in the schema: c:tx.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.Charts.SeriesText? SeriesText
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.Charts.SeriesText>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>ChartShapeProperties.</para>
        /// <para>Represents the following element tag in the schema: c:spPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties? ChartShapeProperties
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Marker.</para>
        /// <para>Represents the following element tag in the schema: c:marker.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.Charts.Marker? Marker
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.Charts.Marker>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ScatterChartSeries>(deep);
    }

    /// <summary>
    /// <para>Defines the AreaChartSeries Class.</para>
    /// <para>This class is available in Office 2013 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c15:ser.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties" /> <c>&lt;c:spPr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Charts.AreaSerExtensionList" /> <c>&lt;c:extLst></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Charts.CategoryAxisData" /> <c>&lt;c:cat></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Charts.DataLabels" /> <c>&lt;c:dLbls></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Charts.DataPoint" /> <c>&lt;c:dPt></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Charts.ErrorBars" /> <c>&lt;c:errBars></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Charts.Values" /> <c>&lt;c:val></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Charts.PictureOptions" /> <c>&lt;c:pictureOptions></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Charts.SeriesText" /> <c>&lt;c:tx></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Charts.Trendline" /> <c>&lt;c:trendline></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Charts.Index" /> <c>&lt;c:idx></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Charts.Order" /> <c>&lt;c:order></c></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(64, "ser")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class AreaChartSeries : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the AreaChartSeries class.
        /// </summary>
        public AreaChartSeries() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the AreaChartSeries class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public AreaChartSeries(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the AreaChartSeries class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public AreaChartSeries(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the AreaChartSeries class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public AreaChartSeries(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(64, "ser");
            builder.Availability = FileFormatVersions.Office2013;
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Charts.AreaSerExtensionList>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Charts.CategoryAxisData>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Charts.DataLabels>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Charts.DataPoint>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Charts.ErrorBars>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Charts.Values>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Charts.PictureOptions>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Charts.SeriesText>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Charts.Trendline>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Charts.Index>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Charts.Order>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new CompositeParticle.Builder(ParticleType.Group, 1, 1)
                {
                    new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
                    {
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.Index), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.Order), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.SeriesText), 0, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties), 0, 1)
                    }
                },
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.PictureOptions), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.DataPoint), 0, 0),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.DataLabels), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.Trendline), 0, 0),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.ErrorBars), 0, 2),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.CategoryAxisData), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.Values), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.AreaSerExtensionList), 0, 1)
            };
        }

        /// <summary>
        /// <para>Index.</para>
        /// <para>Represents the following element tag in the schema: c:idx.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.Charts.Index? Index
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.Charts.Index>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Order.</para>
        /// <para>Represents the following element tag in the schema: c:order.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.Charts.Order? Order
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.Charts.Order>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Series Text.</para>
        /// <para>Represents the following element tag in the schema: c:tx.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.Charts.SeriesText? SeriesText
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.Charts.SeriesText>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>ChartShapeProperties.</para>
        /// <para>Represents the following element tag in the schema: c:spPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties? ChartShapeProperties
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>PictureOptions.</para>
        /// <para>Represents the following element tag in the schema: c:pictureOptions.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.Charts.PictureOptions? PictureOptions
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.Charts.PictureOptions>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<AreaChartSeries>(deep);
    }

    /// <summary>
    /// <para>Defines the PieChartSeries Class.</para>
    /// <para>This class is available in Office 2013 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c15:ser.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties" /> <c>&lt;c:spPr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Charts.CategoryAxisData" /> <c>&lt;c:cat></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Charts.DataLabels" /> <c>&lt;c:dLbls></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Charts.DataPoint" /> <c>&lt;c:dPt></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Charts.Values" /> <c>&lt;c:val></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Charts.PictureOptions" /> <c>&lt;c:pictureOptions></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Charts.PieSerExtensionList" /> <c>&lt;c:extLst></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Charts.SeriesText" /> <c>&lt;c:tx></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Charts.Index" /> <c>&lt;c:idx></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Charts.Order" /> <c>&lt;c:order></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Charts.Explosion" /> <c>&lt;c:explosion></c></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(64, "ser")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class PieChartSeries : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the PieChartSeries class.
        /// </summary>
        public PieChartSeries() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the PieChartSeries class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public PieChartSeries(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the PieChartSeries class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public PieChartSeries(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the PieChartSeries class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public PieChartSeries(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(64, "ser");
            builder.Availability = FileFormatVersions.Office2013;
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Charts.CategoryAxisData>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Charts.DataLabels>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Charts.DataPoint>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Charts.Values>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Charts.PictureOptions>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Charts.PieSerExtensionList>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Charts.SeriesText>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Charts.Index>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Charts.Order>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Charts.Explosion>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new CompositeParticle.Builder(ParticleType.Group, 1, 1)
                {
                    new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
                    {
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.Index), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.Order), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.SeriesText), 0, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties), 0, 1)
                    }
                },
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.PictureOptions), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.Explosion), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.DataPoint), 0, 0),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.DataLabels), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.CategoryAxisData), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.Values), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.PieSerExtensionList), 0, 1)
            };
        }

        /// <summary>
        /// <para>Index.</para>
        /// <para>Represents the following element tag in the schema: c:idx.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.Charts.Index? Index
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.Charts.Index>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Order.</para>
        /// <para>Represents the following element tag in the schema: c:order.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.Charts.Order? Order
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.Charts.Order>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Series Text.</para>
        /// <para>Represents the following element tag in the schema: c:tx.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.Charts.SeriesText? SeriesText
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.Charts.SeriesText>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>ChartShapeProperties.</para>
        /// <para>Represents the following element tag in the schema: c:spPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties? ChartShapeProperties
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>PictureOptions.</para>
        /// <para>Represents the following element tag in the schema: c:pictureOptions.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.Charts.PictureOptions? PictureOptions
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.Charts.PictureOptions>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Explosion.</para>
        /// <para>Represents the following element tag in the schema: c:explosion.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.Charts.Explosion? Explosion
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.Charts.Explosion>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<PieChartSeries>(deep);
    }

    /// <summary>
    /// <para>Defines the BubbleChartSeries Class.</para>
    /// <para>This class is available in Office 2013 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c15:ser.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties" /> <c>&lt;c:spPr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Charts.XValues" /> <c>&lt;c:xVal></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Charts.InvertIfNegative" /> <c>&lt;c:invertIfNegative></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Charts.Bubble3D" /> <c>&lt;c:bubble3D></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Charts.BubbleSerExtensionList" /> <c>&lt;c:extLst></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Charts.DataLabels" /> <c>&lt;c:dLbls></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Charts.DataPoint" /> <c>&lt;c:dPt></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Charts.ErrorBars" /> <c>&lt;c:errBars></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Charts.YValues" /> <c>&lt;c:yVal></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Charts.BubbleSize" /> <c>&lt;c:bubbleSize></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Charts.PictureOptions" /> <c>&lt;c:pictureOptions></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Charts.SeriesText" /> <c>&lt;c:tx></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Charts.Trendline" /> <c>&lt;c:trendline></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Charts.Index" /> <c>&lt;c:idx></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Charts.Order" /> <c>&lt;c:order></c></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(64, "ser")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class BubbleChartSeries : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the BubbleChartSeries class.
        /// </summary>
        public BubbleChartSeries() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the BubbleChartSeries class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public BubbleChartSeries(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the BubbleChartSeries class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public BubbleChartSeries(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the BubbleChartSeries class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public BubbleChartSeries(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(64, "ser");
            builder.Availability = FileFormatVersions.Office2013;
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Charts.XValues>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Charts.InvertIfNegative>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Charts.Bubble3D>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Charts.BubbleSerExtensionList>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Charts.DataLabels>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Charts.DataPoint>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Charts.ErrorBars>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Charts.YValues>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Charts.BubbleSize>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Charts.PictureOptions>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Charts.SeriesText>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Charts.Trendline>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Charts.Index>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Charts.Order>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new CompositeParticle.Builder(ParticleType.Group, 1, 1)
                {
                    new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
                    {
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.Index), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.Order), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.SeriesText), 0, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties), 0, 1)
                    }
                },
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.PictureOptions), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.InvertIfNegative), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.DataPoint), 0, 0),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.DataLabels), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.Trendline), 0, 0),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.ErrorBars), 0, 2),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.XValues), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.YValues), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.BubbleSize), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.Bubble3D), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.BubbleSerExtensionList), 0, 1)
            };
        }

        /// <summary>
        /// <para>Index.</para>
        /// <para>Represents the following element tag in the schema: c:idx.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.Charts.Index? Index
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.Charts.Index>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Order.</para>
        /// <para>Represents the following element tag in the schema: c:order.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.Charts.Order? Order
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.Charts.Order>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Series Text.</para>
        /// <para>Represents the following element tag in the schema: c:tx.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.Charts.SeriesText? SeriesText
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.Charts.SeriesText>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>ChartShapeProperties.</para>
        /// <para>Represents the following element tag in the schema: c:spPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties? ChartShapeProperties
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>PictureOptions.</para>
        /// <para>Represents the following element tag in the schema: c:pictureOptions.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.Charts.PictureOptions? PictureOptions
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.Charts.PictureOptions>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>InvertIfNegative.</para>
        /// <para>Represents the following element tag in the schema: c:invertIfNegative.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.Charts.InvertIfNegative? InvertIfNegative
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.Charts.InvertIfNegative>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<BubbleChartSeries>(deep);
    }

    /// <summary>
    /// <para>Defines the RadarChartSeries Class.</para>
    /// <para>This class is available in Office 2013 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c15:ser.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties" /> <c>&lt;c:spPr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Charts.CategoryAxisData" /> <c>&lt;c:cat></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Charts.DataLabels" /> <c>&lt;c:dLbls></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Charts.DataPoint" /> <c>&lt;c:dPt></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Charts.Marker" /> <c>&lt;c:marker></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Charts.Values" /> <c>&lt;c:val></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Charts.PictureOptions" /> <c>&lt;c:pictureOptions></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Charts.RadarSerExtensionList" /> <c>&lt;c:extLst></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Charts.SeriesText" /> <c>&lt;c:tx></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Charts.Index" /> <c>&lt;c:idx></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Charts.Order" /> <c>&lt;c:order></c></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(64, "ser")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class RadarChartSeries : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the RadarChartSeries class.
        /// </summary>
        public RadarChartSeries() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the RadarChartSeries class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public RadarChartSeries(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the RadarChartSeries class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public RadarChartSeries(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the RadarChartSeries class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public RadarChartSeries(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(64, "ser");
            builder.Availability = FileFormatVersions.Office2013;
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Charts.CategoryAxisData>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Charts.DataLabels>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Charts.DataPoint>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Charts.Marker>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Charts.Values>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Charts.PictureOptions>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Charts.RadarSerExtensionList>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Charts.SeriesText>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Charts.Index>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Charts.Order>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new CompositeParticle.Builder(ParticleType.Group, 1, 1)
                {
                    new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
                    {
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.Index), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.Order), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.SeriesText), 0, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties), 0, 1)
                    }
                },
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.PictureOptions), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.Marker), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.DataPoint), 0, 0),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.DataLabels), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.CategoryAxisData), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.Values), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.RadarSerExtensionList), 0, 1)
            };
        }

        /// <summary>
        /// <para>Index.</para>
        /// <para>Represents the following element tag in the schema: c:idx.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.Charts.Index? Index
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.Charts.Index>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Order.</para>
        /// <para>Represents the following element tag in the schema: c:order.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.Charts.Order? Order
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.Charts.Order>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Series Text.</para>
        /// <para>Represents the following element tag in the schema: c:tx.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.Charts.SeriesText? SeriesText
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.Charts.SeriesText>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>ChartShapeProperties.</para>
        /// <para>Represents the following element tag in the schema: c:spPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties? ChartShapeProperties
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>PictureOptions.</para>
        /// <para>Represents the following element tag in the schema: c:pictureOptions.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.Charts.PictureOptions? PictureOptions
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.Charts.PictureOptions>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Marker.</para>
        /// <para>Represents the following element tag in the schema: c:marker.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.Charts.Marker? Marker
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.Charts.Marker>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<RadarChartSeries>(deep);
    }

    /// <summary>
    /// <para>Defines the SurfaceChartSeries Class.</para>
    /// <para>This class is available in Office 2013 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c15:ser.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties" /> <c>&lt;c:spPr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Charts.CategoryAxisData" /> <c>&lt;c:cat></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Charts.Bubble3D" /> <c>&lt;c:bubble3D></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Charts.Values" /> <c>&lt;c:val></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Charts.PictureOptions" /> <c>&lt;c:pictureOptions></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Charts.SeriesText" /> <c>&lt;c:tx></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Charts.SurfaceSerExtensionList" /> <c>&lt;c:extLst></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Charts.Index" /> <c>&lt;c:idx></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Charts.Order" /> <c>&lt;c:order></c></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(64, "ser")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class SurfaceChartSeries : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the SurfaceChartSeries class.
        /// </summary>
        public SurfaceChartSeries() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the SurfaceChartSeries class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public SurfaceChartSeries(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the SurfaceChartSeries class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public SurfaceChartSeries(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the SurfaceChartSeries class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public SurfaceChartSeries(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(64, "ser");
            builder.Availability = FileFormatVersions.Office2013;
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Charts.CategoryAxisData>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Charts.Bubble3D>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Charts.Values>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Charts.PictureOptions>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Charts.SeriesText>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Charts.SurfaceSerExtensionList>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Charts.Index>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Charts.Order>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new CompositeParticle.Builder(ParticleType.Group, 1, 1)
                {
                    new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
                    {
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.Index), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.Order), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.SeriesText), 0, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties), 0, 1)
                    }
                },
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.PictureOptions), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.CategoryAxisData), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.Values), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.Bubble3D), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.SurfaceSerExtensionList), 0, 1)
            };
        }

        /// <summary>
        /// <para>Index.</para>
        /// <para>Represents the following element tag in the schema: c:idx.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.Charts.Index? Index
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.Charts.Index>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Order.</para>
        /// <para>Represents the following element tag in the schema: c:order.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.Charts.Order? Order
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.Charts.Order>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Series Text.</para>
        /// <para>Represents the following element tag in the schema: c:tx.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.Charts.SeriesText? SeriesText
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.Charts.SeriesText>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>ChartShapeProperties.</para>
        /// <para>Represents the following element tag in the schema: c:spPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties? ChartShapeProperties
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>PictureOptions.</para>
        /// <para>Represents the following element tag in the schema: c:pictureOptions.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.Charts.PictureOptions? PictureOptions
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.Charts.PictureOptions>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>CategoryAxisData.</para>
        /// <para>Represents the following element tag in the schema: c:cat.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.Charts.CategoryAxisData? CategoryAxisData
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.Charts.CategoryAxisData>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Values.</para>
        /// <para>Represents the following element tag in the schema: c:val.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.Charts.Values? Values
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.Charts.Values>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Bubble3D.</para>
        /// <para>Represents the following element tag in the schema: c:bubble3D.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.Charts.Bubble3D? Bubble3D
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.Charts.Bubble3D>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>SurfaceSerExtensionList.</para>
        /// <para>Represents the following element tag in the schema: c:extLst.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.Charts.SurfaceSerExtensionList? SurfaceSerExtensionList
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.Charts.SurfaceSerExtensionList>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<SurfaceChartSeries>(deep);
    }

    /// <summary>
    /// <para>Defines the DataLabelsRangeChache Class.</para>
    /// <para>This class is available in Office 2013 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c15:dlblRangeCache.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Charts.StrDataExtensionList" /> <c>&lt;c:extLst></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Charts.StringPoint" /> <c>&lt;c:pt></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Charts.PointCount" /> <c>&lt;c:ptCount></c></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(64, "dlblRangeCache")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class DataLabelsRangeChache : StringDataType
    {
        /// <summary>
        /// Initializes a new instance of the DataLabelsRangeChache class.
        /// </summary>
        public DataLabelsRangeChache() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the DataLabelsRangeChache class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public DataLabelsRangeChache(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the DataLabelsRangeChache class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public DataLabelsRangeChache(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the DataLabelsRangeChache class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public DataLabelsRangeChache(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(64, "dlblRangeCache");
            builder.Availability = FileFormatVersions.Office2013;
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.PointCount), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.StringPoint), 0, 0),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.StrDataExtensionList), 0, 1)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<DataLabelsRangeChache>(deep);
    }

    /// <summary>
    /// <para>Defines the DataLabelFieldTableCache Class.</para>
    /// <para>This class is available in Office 2013 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c15:dlblFieldTableCache.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Charts.StrDataExtensionList" /> <c>&lt;c:extLst></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Charts.StringPoint" /> <c>&lt;c:pt></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Charts.PointCount" /> <c>&lt;c:ptCount></c></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(64, "dlblFieldTableCache")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class DataLabelFieldTableCache : StringDataType
    {
        /// <summary>
        /// Initializes a new instance of the DataLabelFieldTableCache class.
        /// </summary>
        public DataLabelFieldTableCache() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the DataLabelFieldTableCache class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public DataLabelFieldTableCache(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the DataLabelFieldTableCache class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public DataLabelFieldTableCache(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the DataLabelFieldTableCache class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public DataLabelFieldTableCache(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(64, "dlblFieldTableCache");
            builder.Availability = FileFormatVersions.Office2013;
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.PointCount), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.StringPoint), 0, 0),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.StrDataExtensionList), 0, 1)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<DataLabelFieldTableCache>(deep);
    }

    /// <summary>
    /// <para>Defines the StringDataType Class.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is :.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Charts.StrDataExtensionList" /> <c>&lt;c:extLst></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Charts.StringPoint" /> <c>&lt;c:pt></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Charts.PointCount" /> <c>&lt;c:ptCount></c></description></item>
    /// </list>
    /// </remark>
    public abstract partial class StringDataType : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the StringDataType class.
        /// </summary>
        protected StringDataType() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the StringDataType class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        protected StringDataType(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the StringDataType class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        protected StringDataType(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the StringDataType class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        protected StringDataType(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Charts.StrDataExtensionList>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Charts.StringPoint>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Charts.PointCount>();
        }

        /// <summary>
        /// <para>PointCount.</para>
        /// <para>Represents the following element tag in the schema: c:ptCount.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.Charts.PointCount? PointCount
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.Charts.PointCount>();
            set => SetElement(value);
        }
    }

    /// <summary>
    /// <para>Defines the Explosion Class.</para>
    /// <para>This class is available in Office 2013 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c15:explosion.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(64, "explosion")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class Explosion : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the Explosion class.
        /// </summary>
        public Explosion() : base()
        {
        }

        /// <summary>
        /// <para>Integer Value</para>
        /// <para>Represents the following attribute in the schema: val</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "val")]
#pragma warning restore CS0618 // Type or member is obsolete

        public UInt32Value? Val
        {
            get => GetAttribute<UInt32Value>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(64, "explosion");
            builder.Availability = FileFormatVersions.Office2013;
            builder.AddElement<Explosion>()
.AddAttribute(0, "val", a => a.Val, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
});
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Explosion>(deep);
    }

    /// <summary>
    /// <para>Defines the Marker Class.</para>
    /// <para>This class is available in Office 2013 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c15:marker.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties" /> <c>&lt;c:spPr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Charts.ExtensionList" /> <c>&lt;c:extLst></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Charts.Size" /> <c>&lt;c:size></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Charts.Symbol" /> <c>&lt;c:symbol></c></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(64, "marker")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class Marker : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the Marker class.
        /// </summary>
        public Marker() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Marker class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Marker(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Marker class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Marker(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Marker class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public Marker(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(64, "marker");
            builder.Availability = FileFormatVersions.Office2013;
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Charts.ExtensionList>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Charts.Size>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Charts.Symbol>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.Symbol), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.Size), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.ExtensionList), 0, 1)
            };
        }

        /// <summary>
        /// <para>Symbol.</para>
        /// <para>Represents the following element tag in the schema: c:symbol.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.Charts.Symbol? Symbol
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.Charts.Symbol>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Size.</para>
        /// <para>Represents the following element tag in the schema: c:size.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.Charts.Size? Size
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.Charts.Size>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>ChartShapeProperties.</para>
        /// <para>Represents the following element tag in the schema: c:spPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties? ChartShapeProperties
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Chart Extensibility.</para>
        /// <para>Represents the following element tag in the schema: c:extLst.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.Charts.ExtensionList? ExtensionList
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.Charts.ExtensionList>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Marker>(deep);
    }

    /// <summary>
    /// <para>Defines the DataLabel Class.</para>
    /// <para>This class is available in Office 2013 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c15:dLbl.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties" /> <c>&lt;c:spPr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Charts.TextProperties" /> <c>&lt;c:txPr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Charts.Delete" /> <c>&lt;c:delete></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Charts.ShowLegendKey" /> <c>&lt;c:showLegendKey></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Charts.ShowValue" /> <c>&lt;c:showVal></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Charts.ShowCategoryName" /> <c>&lt;c:showCatName></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Charts.ShowSeriesName" /> <c>&lt;c:showSerName></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Charts.ShowPercent" /> <c>&lt;c:showPercent></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Charts.ShowBubbleSize" /> <c>&lt;c:showBubbleSize></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Charts.DLblExtensionList" /> <c>&lt;c:extLst></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Charts.DataLabelPosition" /> <c>&lt;c:dLblPos></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Charts.Layout" /> <c>&lt;c:layout></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Charts.NumberingFormat" /> <c>&lt;c:numFmt></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Charts.ChartText" /> <c>&lt;c:tx></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Charts.Index" /> <c>&lt;c:idx></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Charts.Separator" /> <c>&lt;c:separator></c></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(64, "dLbl")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class DataLabel : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the DataLabel class.
        /// </summary>
        public DataLabel() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the DataLabel class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public DataLabel(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the DataLabel class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public DataLabel(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the DataLabel class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public DataLabel(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(64, "dLbl");
            builder.Availability = FileFormatVersions.Office2013;
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Charts.TextProperties>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Charts.Delete>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Charts.ShowLegendKey>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Charts.ShowValue>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Charts.ShowCategoryName>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Charts.ShowSeriesName>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Charts.ShowPercent>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Charts.ShowBubbleSize>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Charts.DLblExtensionList>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Charts.DataLabelPosition>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Charts.Layout>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Charts.NumberingFormat>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Charts.ChartText>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Charts.Index>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Charts.Separator>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.Index), 1, 1),
                new CompositeParticle.Builder(ParticleType.Choice, 1, 1)
                {
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.Delete), 1, 1),
                    new CompositeParticle.Builder(ParticleType.Group, 1, 1)
                    {
                        new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
                        {
                            new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.Layout), 0, 1),
                            new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.ChartText), 0, 1),
                            new CompositeParticle.Builder(ParticleType.Group, 1, 1)
                            {
                                new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
                                {
                                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.NumberingFormat), 0, 1),
                                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties), 0, 1),
                                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.TextProperties), 0, 1),
                                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.DataLabelPosition), 0, 1),
                                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.ShowLegendKey), 0, 1),
                                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.ShowValue), 0, 1),
                                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.ShowCategoryName), 0, 1),
                                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.ShowSeriesName), 0, 1),
                                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.ShowPercent), 0, 1),
                                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.ShowBubbleSize), 0, 1),
                                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.Separator), 0, 1)
                                }
                            }
                        }
                    }
                },
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.DLblExtensionList), 0, 1)
            };
        }

        /// <summary>
        /// <para>Index.</para>
        /// <para>Represents the following element tag in the schema: c:idx.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.Charts.Index? Index
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.Charts.Index>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<DataLabel>(deep);
    }

    /// <summary>
    /// <para>Defines the CategoryFilterException Class.</para>
    /// <para>This class is available in Office 2013 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c15:categoryFilterException.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.Chart.ShapeProperties" /> <c>&lt;c15:spPr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.Chart.InvertIfNegativeBoolean" /> <c>&lt;c15:invertIfNegative></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.Chart.Bubble3D" /> <c>&lt;c15:bubble3D></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.Chart.DataLabel" /> <c>&lt;c15:dLbl></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.Chart.Marker" /> <c>&lt;c15:marker></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.Chart.Explosion" /> <c>&lt;c15:explosion></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.Chart.SequenceOfReferences" /> <c>&lt;c15:sqref></c></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(64, "categoryFilterException")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class CategoryFilterException : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the CategoryFilterException class.
        /// </summary>
        public CategoryFilterException() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the CategoryFilterException class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public CategoryFilterException(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the CategoryFilterException class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public CategoryFilterException(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the CategoryFilterException class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public CategoryFilterException(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(64, "categoryFilterException");
            builder.Availability = FileFormatVersions.Office2013;
            builder.AddChild<DocumentFormat.OpenXml.Office2013.Drawing.Chart.ShapeProperties>();
            builder.AddChild<DocumentFormat.OpenXml.Office2013.Drawing.Chart.InvertIfNegativeBoolean>();
            builder.AddChild<DocumentFormat.OpenXml.Office2013.Drawing.Chart.Bubble3D>();
            builder.AddChild<DocumentFormat.OpenXml.Office2013.Drawing.Chart.DataLabel>();
            builder.AddChild<DocumentFormat.OpenXml.Office2013.Drawing.Chart.Marker>();
            builder.AddChild<DocumentFormat.OpenXml.Office2013.Drawing.Chart.Explosion>();
            builder.AddChild<DocumentFormat.OpenXml.Office2013.Drawing.Chart.SequenceOfReferences>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.Chart.SequenceOfReferences), 1, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.Chart.ShapeProperties), 0, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.Chart.Explosion), 0, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.Chart.InvertIfNegativeBoolean), 0, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.Chart.Bubble3D), 0, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.Chart.Marker), 0, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.Chart.DataLabel), 0, 1, version: FileFormatVersions.Office2013)
            };
        }

        /// <summary>
        /// <para>SequenceOfReferences.</para>
        /// <para>Represents the following element tag in the schema: c15:sqref.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c15 = http://schemas.microsoft.com/office/drawing/2012/chart
        /// </remark>
        public DocumentFormat.OpenXml.Office2013.Drawing.Chart.SequenceOfReferences? SequenceOfReferences
        {
            get => GetElement<DocumentFormat.OpenXml.Office2013.Drawing.Chart.SequenceOfReferences>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>ShapeProperties.</para>
        /// <para>Represents the following element tag in the schema: c15:spPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c15 = http://schemas.microsoft.com/office/drawing/2012/chart
        /// </remark>
        public DocumentFormat.OpenXml.Office2013.Drawing.Chart.ShapeProperties? ShapeProperties
        {
            get => GetElement<DocumentFormat.OpenXml.Office2013.Drawing.Chart.ShapeProperties>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Explosion.</para>
        /// <para>Represents the following element tag in the schema: c15:explosion.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c15 = http://schemas.microsoft.com/office/drawing/2012/chart
        /// </remark>
        public DocumentFormat.OpenXml.Office2013.Drawing.Chart.Explosion? Explosion
        {
            get => GetElement<DocumentFormat.OpenXml.Office2013.Drawing.Chart.Explosion>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>InvertIfNegativeBoolean.</para>
        /// <para>Represents the following element tag in the schema: c15:invertIfNegative.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c15 = http://schemas.microsoft.com/office/drawing/2012/chart
        /// </remark>
        public DocumentFormat.OpenXml.Office2013.Drawing.Chart.InvertIfNegativeBoolean? InvertIfNegativeBoolean
        {
            get => GetElement<DocumentFormat.OpenXml.Office2013.Drawing.Chart.InvertIfNegativeBoolean>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Bubble3D.</para>
        /// <para>Represents the following element tag in the schema: c15:bubble3D.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c15 = http://schemas.microsoft.com/office/drawing/2012/chart
        /// </remark>
        public DocumentFormat.OpenXml.Office2013.Drawing.Chart.Bubble3D? Bubble3D
        {
            get => GetElement<DocumentFormat.OpenXml.Office2013.Drawing.Chart.Bubble3D>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Marker.</para>
        /// <para>Represents the following element tag in the schema: c15:marker.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c15 = http://schemas.microsoft.com/office/drawing/2012/chart
        /// </remark>
        public DocumentFormat.OpenXml.Office2013.Drawing.Chart.Marker? Marker
        {
            get => GetElement<DocumentFormat.OpenXml.Office2013.Drawing.Chart.Marker>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>DataLabel.</para>
        /// <para>Represents the following element tag in the schema: c15:dLbl.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c15 = http://schemas.microsoft.com/office/drawing/2012/chart
        /// </remark>
        public DocumentFormat.OpenXml.Office2013.Drawing.Chart.DataLabel? DataLabel
        {
            get => GetElement<DocumentFormat.OpenXml.Office2013.Drawing.Chart.DataLabel>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<CategoryFilterException>(deep);
    }

    /// <summary>
    /// <para>Defines the DataLabelFieldTableEntry Class.</para>
    /// <para>This class is available in Office 2013 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c15:dlblFTEntry.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.Chart.DataLabelFieldTableCache" /> <c>&lt;c15:dlblFieldTableCache></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.Chart.TextFieldGuid" /> <c>&lt;c15:txfldGUID></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.Chart.Formula" /> <c>&lt;c15:f></c></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(64, "dlblFTEntry")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class DataLabelFieldTableEntry : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the DataLabelFieldTableEntry class.
        /// </summary>
        public DataLabelFieldTableEntry() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the DataLabelFieldTableEntry class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public DataLabelFieldTableEntry(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the DataLabelFieldTableEntry class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public DataLabelFieldTableEntry(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the DataLabelFieldTableEntry class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public DataLabelFieldTableEntry(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(64, "dlblFTEntry");
            builder.Availability = FileFormatVersions.Office2013;
            builder.AddChild<DocumentFormat.OpenXml.Office2013.Drawing.Chart.DataLabelFieldTableCache>();
            builder.AddChild<DocumentFormat.OpenXml.Office2013.Drawing.Chart.TextFieldGuid>();
            builder.AddChild<DocumentFormat.OpenXml.Office2013.Drawing.Chart.Formula>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.Chart.TextFieldGuid), 1, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.Chart.Formula), 1, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.Chart.DataLabelFieldTableCache), 0, 1, version: FileFormatVersions.Office2013)
            };
        }

        /// <summary>
        /// <para>TextFieldGuid.</para>
        /// <para>Represents the following element tag in the schema: c15:txfldGUID.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c15 = http://schemas.microsoft.com/office/drawing/2012/chart
        /// </remark>
        public DocumentFormat.OpenXml.Office2013.Drawing.Chart.TextFieldGuid? TextFieldGuid
        {
            get => GetElement<DocumentFormat.OpenXml.Office2013.Drawing.Chart.TextFieldGuid>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Formula.</para>
        /// <para>Represents the following element tag in the schema: c15:f.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c15 = http://schemas.microsoft.com/office/drawing/2012/chart
        /// </remark>
        public DocumentFormat.OpenXml.Office2013.Drawing.Chart.Formula? Formula
        {
            get => GetElement<DocumentFormat.OpenXml.Office2013.Drawing.Chart.Formula>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>DataLabelFieldTableCache.</para>
        /// <para>Represents the following element tag in the schema: c15:dlblFieldTableCache.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c15 = http://schemas.microsoft.com/office/drawing/2012/chart
        /// </remark>
        public DocumentFormat.OpenXml.Office2013.Drawing.Chart.DataLabelFieldTableCache? DataLabelFieldTableCache
        {
            get => GetElement<DocumentFormat.OpenXml.Office2013.Drawing.Chart.DataLabelFieldTableCache>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<DataLabelFieldTableEntry>(deep);
    }
}