﻿// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Drawing;
using DocumentFormat.OpenXml.Drawing.Diagrams;
using DocumentFormat.OpenXml.Framework;
using DocumentFormat.OpenXml.Framework.Metadata;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Validation.Schema;
using System;
using System.Collections.Generic;
using System.IO.Packaging;

namespace DocumentFormat.OpenXml.Office.Drawing
{
    /// <summary>
    /// <para>Defines the Drawing Class.</para>
    /// <para>This class is available in Office 2010 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is dsp:drawing.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office.Drawing.ShapeTree" /> <c>&lt;dsp:spTree></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("dsp:drawing")]
    public partial class Drawing : OpenXmlPartRootElement
    {
        /// <summary>
        /// Initializes a new instance of the Drawing class.
        /// </summary>
        public Drawing() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Drawing class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Drawing(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Drawing class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Drawing(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Drawing class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public Drawing(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("dsp:drawing");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddChild<DocumentFormat.OpenXml.Office.Drawing.ShapeTree>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office.Drawing.ShapeTree), 1, 1, version: FileFormatVersions.Office2010)
            };
        }

        /// <summary>
        /// <para>ShapeTree.</para>
        /// <para>Represents the following element tag in the schema: dsp:spTree.</para>
        /// </summary>
        /// <remark>
        /// xmlns:dsp = http://schemas.microsoft.com/office/drawing/2008/diagram
        /// </remark>
        public DocumentFormat.OpenXml.Office.Drawing.ShapeTree? ShapeTree
        {
            get => GetElement<DocumentFormat.OpenXml.Office.Drawing.ShapeTree>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Drawing>(deep);

        internal Drawing(DiagramPersistLayoutPart ownerPart) : base(ownerPart)
        {
        }

        /// <summary>
        /// Loads the DOM from the DiagramPersistLayoutPart
        /// </summary>
        /// <param name="openXmlPart">Specifies the part to be loaded.</param>
        public void Load(DiagramPersistLayoutPart openXmlPart)
        {
            LoadFromPart(openXmlPart);
        }

        /// <summary>
        /// Saves the DOM into the DiagramPersistLayoutPart.
        /// </summary>
        /// <param name="openXmlPart">Specifies the part to save to.</param>
        public void Save(DiagramPersistLayoutPart openXmlPart)
        {
            base.SaveToPart(openXmlPart);
        }

        /// <summary>
        /// Gets the DiagramPersistLayoutPart associated with this element.
        /// </summary>
        public DiagramPersistLayoutPart? DiagramPersistLayoutPart
        {
            get => OpenXmlPart as DiagramPersistLayoutPart;
            internal set => OpenXmlPart = value;
        }
    }

    /// <summary>
    /// <para>Defines the DataModelExtensionBlock Class.</para>
    /// <para>This class is available in Office 2010 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is dsp:dataModelExt.</para>
    /// </summary>
    [SchemaAttr("dsp:dataModelExt")]
    public partial class DataModelExtensionBlock : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the DataModelExtensionBlock class.
        /// </summary>
        public DataModelExtensionBlock() : base()
        {
        }

        /// <summary>
        /// <para>relId, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: relId</para>
        /// </summary>
        [SchemaAttr("relId")]
        public StringValue? RelId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>minVer, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: minVer</para>
        /// </summary>
        [SchemaAttr("minVer")]
        public StringValue? MinVer
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("dsp:dataModelExt");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddElement<DataModelExtensionBlock>()
                .AddAttribute("relId", a => a.RelId)
                .AddAttribute("minVer", a => a.MinVer, aBuilder =>
                {
                    aBuilder.AddValidator(new StringValidator() { IsUri = (true) });
                });
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<DataModelExtensionBlock>(deep);
    }

    /// <summary>
    /// <para>Defines the NonVisualDrawingProperties Class.</para>
    /// <para>This class is available in Office 2010 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is dsp:cNvPr.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.HyperlinkOnClick" /> <c>&lt;a:hlinkClick></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.HyperlinkOnHover" /> <c>&lt;a:hlinkHover></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.NonVisualDrawingPropertiesExtensionList" /> <c>&lt;a:extLst></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("dsp:cNvPr")]
    public partial class NonVisualDrawingProperties : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the NonVisualDrawingProperties class.
        /// </summary>
        public NonVisualDrawingProperties() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the NonVisualDrawingProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public NonVisualDrawingProperties(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the NonVisualDrawingProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public NonVisualDrawingProperties(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the NonVisualDrawingProperties class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public NonVisualDrawingProperties(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>Application defined unique identifier.</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>
        [SchemaAttr("id")]
        public UInt32Value? Id
        {
            get => GetAttribute<UInt32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Name compatible with Object Model (non-unique).</para>
        /// <para>Represents the following attribute in the schema: name</para>
        /// </summary>
        [SchemaAttr("name")]
        public StringValue? Name
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Description of the drawing element.</para>
        /// <para>Represents the following attribute in the schema: descr</para>
        /// </summary>
        [SchemaAttr("descr")]
        public StringValue? Description
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Flag determining to show or hide this element.</para>
        /// <para>Represents the following attribute in the schema: hidden</para>
        /// </summary>
        [SchemaAttr("hidden")]
        public BooleanValue? Hidden
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Title</para>
        /// <para>Represents the following attribute in the schema: title</para>
        /// </summary>
        [SchemaAttr("title")]
        public StringValue? Title
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("dsp:cNvPr");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddChild<DocumentFormat.OpenXml.Drawing.HyperlinkOnClick>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.HyperlinkOnHover>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.NonVisualDrawingPropertiesExtensionList>();
            builder.AddElement<NonVisualDrawingProperties>()
                .AddAttribute("id", a => a.Id, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                })
                .AddAttribute("name", a => a.Name, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                })
                .AddAttribute("descr", a => a.Description)
                .AddAttribute("hidden", a => a.Hidden)
                .AddAttribute("title", a => a.Title);
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.HyperlinkOnClick), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.HyperlinkOnHover), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.NonVisualDrawingPropertiesExtensionList), 0, 1)
            };
        }

        /// <summary>
        /// <para>Hyperlink associated with clicking or selecting the element..</para>
        /// <para>Represents the following element tag in the schema: a:hlinkClick.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.HyperlinkOnClick? HyperlinkOnClick
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.HyperlinkOnClick>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Hyperlink associated with hovering over the element..</para>
        /// <para>Represents the following element tag in the schema: a:hlinkHover.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.HyperlinkOnHover? HyperlinkOnHover
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.HyperlinkOnHover>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Future extension.</para>
        /// <para>Represents the following element tag in the schema: a:extLst.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.NonVisualDrawingPropertiesExtensionList? NonVisualDrawingPropertiesExtensionList
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.NonVisualDrawingPropertiesExtensionList>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<NonVisualDrawingProperties>(deep);
    }

    /// <summary>
    /// <para>Defines the NonVisualDrawingShapeProperties Class.</para>
    /// <para>This class is available in Office 2010 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is dsp:cNvSpPr.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.ExtensionList" /> <c>&lt;a:extLst></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.ShapeLocks" /> <c>&lt;a:spLocks></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("dsp:cNvSpPr")]
    public partial class NonVisualDrawingShapeProperties : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the NonVisualDrawingShapeProperties class.
        /// </summary>
        public NonVisualDrawingShapeProperties() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the NonVisualDrawingShapeProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public NonVisualDrawingShapeProperties(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the NonVisualDrawingShapeProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public NonVisualDrawingShapeProperties(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the NonVisualDrawingShapeProperties class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public NonVisualDrawingShapeProperties(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>Text Box</para>
        /// <para>Represents the following attribute in the schema: txBox</para>
        /// </summary>
        [SchemaAttr("txBox")]
        public BooleanValue? TextBox
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("dsp:cNvSpPr");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddChild<DocumentFormat.OpenXml.Drawing.ExtensionList>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.ShapeLocks>();
            builder.AddElement<NonVisualDrawingShapeProperties>()
                .AddAttribute("txBox", a => a.TextBox);
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.ShapeLocks), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.ExtensionList), 0, 1)
            };
        }

        /// <summary>
        /// <para>Shape Locks.</para>
        /// <para>Represents the following element tag in the schema: a:spLocks.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.ShapeLocks? ShapeLocks
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.ShapeLocks>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>ExtensionList.</para>
        /// <para>Represents the following element tag in the schema: a:extLst.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.ExtensionList? ExtensionList
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.ExtensionList>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<NonVisualDrawingShapeProperties>(deep);
    }

    /// <summary>
    /// <para>Defines the ShapeNonVisualProperties Class.</para>
    /// <para>This class is available in Office 2010 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is dsp:nvSpPr.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office.Drawing.NonVisualDrawingProperties" /> <c>&lt;dsp:cNvPr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office.Drawing.NonVisualDrawingShapeProperties" /> <c>&lt;dsp:cNvSpPr></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("dsp:nvSpPr")]
    public partial class ShapeNonVisualProperties : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the ShapeNonVisualProperties class.
        /// </summary>
        public ShapeNonVisualProperties() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the ShapeNonVisualProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ShapeNonVisualProperties(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ShapeNonVisualProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ShapeNonVisualProperties(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ShapeNonVisualProperties class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public ShapeNonVisualProperties(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("dsp:nvSpPr");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddChild<DocumentFormat.OpenXml.Office.Drawing.NonVisualDrawingProperties>();
            builder.AddChild<DocumentFormat.OpenXml.Office.Drawing.NonVisualDrawingShapeProperties>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office.Drawing.NonVisualDrawingProperties), 1, 1, version: FileFormatVersions.Office2010),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office.Drawing.NonVisualDrawingShapeProperties), 1, 1, version: FileFormatVersions.Office2010)
            };
        }

        /// <summary>
        /// <para>NonVisualDrawingProperties.</para>
        /// <para>Represents the following element tag in the schema: dsp:cNvPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:dsp = http://schemas.microsoft.com/office/drawing/2008/diagram
        /// </remark>
        public DocumentFormat.OpenXml.Office.Drawing.NonVisualDrawingProperties? NonVisualDrawingProperties
        {
            get => GetElement<DocumentFormat.OpenXml.Office.Drawing.NonVisualDrawingProperties>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>NonVisualDrawingShapeProperties.</para>
        /// <para>Represents the following element tag in the schema: dsp:cNvSpPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:dsp = http://schemas.microsoft.com/office/drawing/2008/diagram
        /// </remark>
        public DocumentFormat.OpenXml.Office.Drawing.NonVisualDrawingShapeProperties? NonVisualDrawingShapeProperties
        {
            get => GetElement<DocumentFormat.OpenXml.Office.Drawing.NonVisualDrawingShapeProperties>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ShapeNonVisualProperties>(deep);
    }

    /// <summary>
    /// <para>Defines the ShapeProperties Class.</para>
    /// <para>This class is available in Office 2010 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is dsp:spPr.</para>
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
    [SchemaAttr("dsp:spPr")]
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
            builder.SetSchema("dsp:spPr");
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
    /// <para>Defines the ShapeStyle Class.</para>
    /// <para>This class is available in Office 2010 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is dsp:style.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.FontReference" /> <c>&lt;a:fontRef></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.LineReference" /> <c>&lt;a:lnRef></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.FillReference" /> <c>&lt;a:fillRef></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.EffectReference" /> <c>&lt;a:effectRef></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("dsp:style")]
    public partial class ShapeStyle : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the ShapeStyle class.
        /// </summary>
        public ShapeStyle() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the ShapeStyle class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ShapeStyle(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ShapeStyle class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ShapeStyle(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ShapeStyle class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public ShapeStyle(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("dsp:style");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddChild<DocumentFormat.OpenXml.Drawing.FontReference>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.LineReference>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.FillReference>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.EffectReference>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.LineReference), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.FillReference), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.EffectReference), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.FontReference), 1, 1)
            };
        }

        /// <summary>
        /// <para>LineReference.</para>
        /// <para>Represents the following element tag in the schema: a:lnRef.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.LineReference? LineReference
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.LineReference>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>FillReference.</para>
        /// <para>Represents the following element tag in the schema: a:fillRef.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.FillReference? FillReference
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.FillReference>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>EffectReference.</para>
        /// <para>Represents the following element tag in the schema: a:effectRef.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.EffectReference? EffectReference
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.EffectReference>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Font Reference.</para>
        /// <para>Represents the following element tag in the schema: a:fontRef.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.FontReference? FontReference
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.FontReference>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ShapeStyle>(deep);
    }

    /// <summary>
    /// <para>Defines the TextBody Class.</para>
    /// <para>This class is available in Office 2010 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is dsp:txBody.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.BodyProperties" /> <c>&lt;a:bodyPr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.ListStyle" /> <c>&lt;a:lstStyle></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Paragraph" /> <c>&lt;a:p></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("dsp:txBody")]
    public partial class TextBody : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the TextBody class.
        /// </summary>
        public TextBody() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the TextBody class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public TextBody(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the TextBody class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public TextBody(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the TextBody class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public TextBody(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("dsp:txBody");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddChild<DocumentFormat.OpenXml.Drawing.BodyProperties>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.ListStyle>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Paragraph>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.BodyProperties), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.ListStyle), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Paragraph), 1, 0)
            };
        }

        /// <summary>
        /// <para>Body Properties.</para>
        /// <para>Represents the following element tag in the schema: a:bodyPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.BodyProperties? BodyProperties
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.BodyProperties>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Text List Styles.</para>
        /// <para>Represents the following element tag in the schema: a:lstStyle.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.ListStyle? ListStyle
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.ListStyle>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<TextBody>(deep);
    }

    /// <summary>
    /// <para>Defines the Transform2D Class.</para>
    /// <para>This class is available in Office 2010 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is dsp:txXfrm.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Offset" /> <c>&lt;a:off></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Extents" /> <c>&lt;a:ext></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("dsp:txXfrm")]
    public partial class Transform2D : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the Transform2D class.
        /// </summary>
        public Transform2D() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Transform2D class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Transform2D(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Transform2D class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Transform2D(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Transform2D class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public Transform2D(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>Rotation</para>
        /// <para>Represents the following attribute in the schema: rot</para>
        /// </summary>
        [SchemaAttr("rot")]
        public Int32Value? Rotation
        {
            get => GetAttribute<Int32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Horizontal Flip</para>
        /// <para>Represents the following attribute in the schema: flipH</para>
        /// </summary>
        [SchemaAttr("flipH")]
        public BooleanValue? HorizontalFlip
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Vertical Flip</para>
        /// <para>Represents the following attribute in the schema: flipV</para>
        /// </summary>
        [SchemaAttr("flipV")]
        public BooleanValue? VerticalFlip
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("dsp:txXfrm");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Offset>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Extents>();
            builder.AddElement<Transform2D>()
                .AddAttribute("rot", a => a.Rotation)
                .AddAttribute("flipH", a => a.HorizontalFlip)
                .AddAttribute("flipV", a => a.VerticalFlip);
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Offset), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Extents), 0, 1)
            };
        }

        /// <summary>
        /// <para>Offset.</para>
        /// <para>Represents the following element tag in the schema: a:off.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.Offset? Offset
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.Offset>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Extents.</para>
        /// <para>Represents the following element tag in the schema: a:ext.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.Extents? Extents
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.Extents>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Transform2D>(deep);
    }

    /// <summary>
    /// <para>Defines the OfficeArtExtensionList Class.</para>
    /// <para>This class is available in Office 2010 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is dsp:extLst.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Extension" /> <c>&lt;a:ext></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("dsp:extLst")]
    public partial class OfficeArtExtensionList : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the OfficeArtExtensionList class.
        /// </summary>
        public OfficeArtExtensionList() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the OfficeArtExtensionList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public OfficeArtExtensionList(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the OfficeArtExtensionList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public OfficeArtExtensionList(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the OfficeArtExtensionList class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public OfficeArtExtensionList(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("dsp:extLst");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Extension>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new CompositeParticle.Builder(ParticleType.Group, 1, 1)
                {
                    new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
                    {
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Extension), 0, 0)
                    }
                }
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<OfficeArtExtensionList>(deep);
    }

    /// <summary>
    /// <para>Defines the NonVisualGroupDrawingShapeProperties Class.</para>
    /// <para>This class is available in Office 2010 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is dsp:cNvGrpSpPr.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.GroupShapeLocks" /> <c>&lt;a:grpSpLocks></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.NonVisualGroupDrawingShapePropsExtensionList" /> <c>&lt;a:extLst></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("dsp:cNvGrpSpPr")]
    public partial class NonVisualGroupDrawingShapeProperties : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the NonVisualGroupDrawingShapeProperties class.
        /// </summary>
        public NonVisualGroupDrawingShapeProperties() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the NonVisualGroupDrawingShapeProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public NonVisualGroupDrawingShapeProperties(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the NonVisualGroupDrawingShapeProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public NonVisualGroupDrawingShapeProperties(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the NonVisualGroupDrawingShapeProperties class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public NonVisualGroupDrawingShapeProperties(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("dsp:cNvGrpSpPr");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddChild<DocumentFormat.OpenXml.Drawing.GroupShapeLocks>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.NonVisualGroupDrawingShapePropsExtensionList>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.GroupShapeLocks), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.NonVisualGroupDrawingShapePropsExtensionList), 0, 1)
            };
        }

        /// <summary>
        /// <para>GroupShapeLocks.</para>
        /// <para>Represents the following element tag in the schema: a:grpSpLocks.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.GroupShapeLocks? GroupShapeLocks
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.GroupShapeLocks>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>NonVisualGroupDrawingShapePropsExtensionList.</para>
        /// <para>Represents the following element tag in the schema: a:extLst.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.NonVisualGroupDrawingShapePropsExtensionList? NonVisualGroupDrawingShapePropsExtensionList
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.NonVisualGroupDrawingShapePropsExtensionList>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<NonVisualGroupDrawingShapeProperties>(deep);
    }

    /// <summary>
    /// <para>Defines the GroupShapeNonVisualProperties Class.</para>
    /// <para>This class is available in Office 2010 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is dsp:nvGrpSpPr.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office.Drawing.NonVisualDrawingProperties" /> <c>&lt;dsp:cNvPr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office.Drawing.NonVisualGroupDrawingShapeProperties" /> <c>&lt;dsp:cNvGrpSpPr></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("dsp:nvGrpSpPr")]
    public partial class GroupShapeNonVisualProperties : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the GroupShapeNonVisualProperties class.
        /// </summary>
        public GroupShapeNonVisualProperties() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the GroupShapeNonVisualProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public GroupShapeNonVisualProperties(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the GroupShapeNonVisualProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public GroupShapeNonVisualProperties(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the GroupShapeNonVisualProperties class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public GroupShapeNonVisualProperties(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("dsp:nvGrpSpPr");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddChild<DocumentFormat.OpenXml.Office.Drawing.NonVisualDrawingProperties>();
            builder.AddChild<DocumentFormat.OpenXml.Office.Drawing.NonVisualGroupDrawingShapeProperties>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office.Drawing.NonVisualDrawingProperties), 1, 1, version: FileFormatVersions.Office2010),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office.Drawing.NonVisualGroupDrawingShapeProperties), 1, 1, version: FileFormatVersions.Office2010)
            };
        }

        /// <summary>
        /// <para>NonVisualDrawingProperties.</para>
        /// <para>Represents the following element tag in the schema: dsp:cNvPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:dsp = http://schemas.microsoft.com/office/drawing/2008/diagram
        /// </remark>
        public DocumentFormat.OpenXml.Office.Drawing.NonVisualDrawingProperties? NonVisualDrawingProperties
        {
            get => GetElement<DocumentFormat.OpenXml.Office.Drawing.NonVisualDrawingProperties>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>NonVisualGroupDrawingShapeProperties.</para>
        /// <para>Represents the following element tag in the schema: dsp:cNvGrpSpPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:dsp = http://schemas.microsoft.com/office/drawing/2008/diagram
        /// </remark>
        public DocumentFormat.OpenXml.Office.Drawing.NonVisualGroupDrawingShapeProperties? NonVisualGroupDrawingShapeProperties
        {
            get => GetElement<DocumentFormat.OpenXml.Office.Drawing.NonVisualGroupDrawingShapeProperties>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<GroupShapeNonVisualProperties>(deep);
    }

    /// <summary>
    /// <para>Defines the GroupShapeProperties Class.</para>
    /// <para>This class is available in Office 2010 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is dsp:grpSpPr.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.BlipFill" /> <c>&lt;a:blipFill></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.EffectDag" /> <c>&lt;a:effectDag></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.EffectList" /> <c>&lt;a:effectLst></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.GradientFill" /> <c>&lt;a:gradFill></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.GroupFill" /> <c>&lt;a:grpFill></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.TransformGroup" /> <c>&lt;a:xfrm></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.NoFill" /> <c>&lt;a:noFill></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.ExtensionList" /> <c>&lt;a:extLst></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.PatternFill" /> <c>&lt;a:pattFill></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Scene3DType" /> <c>&lt;a:scene3d></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.SolidFill" /> <c>&lt;a:solidFill></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("dsp:grpSpPr")]
    public partial class GroupShapeProperties : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the GroupShapeProperties class.
        /// </summary>
        public GroupShapeProperties() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the GroupShapeProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public GroupShapeProperties(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the GroupShapeProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public GroupShapeProperties(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the GroupShapeProperties class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public GroupShapeProperties(string outerXml) : base(outerXml)
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
            builder.SetSchema("dsp:grpSpPr");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddChild<DocumentFormat.OpenXml.Drawing.BlipFill>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.EffectDag>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.EffectList>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.GradientFill>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.GroupFill>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.TransformGroup>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.NoFill>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.ExtensionList>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.PatternFill>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Scene3DType>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.SolidFill>();
            builder.AddElement<GroupShapeProperties>()
                .AddAttribute("bwMode", a => a.BlackWhiteMode, aBuilder =>
                {
                    aBuilder.AddValidator(new StringValidator() { IsToken = (true) });
                });
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.TransformGroup), 0, 1),
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
                new CompositeParticle.Builder(ParticleType.Group, 0, 1)
                {
                    new CompositeParticle.Builder(ParticleType.Choice, 1, 1)
                    {
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.EffectList), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.EffectDag), 1, 1)
                    }
                },
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Scene3DType), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.ExtensionList), 0, 1)
            };
        }

        /// <summary>
        /// <para>2D Transform for Grouped Objects.</para>
        /// <para>Represents the following element tag in the schema: a:xfrm.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.TransformGroup? TransformGroup
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.TransformGroup>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<GroupShapeProperties>(deep);
    }

    /// <summary>
    /// <para>Defines the Shape Class.</para>
    /// <para>This class is available in Office 2010 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is dsp:sp.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office.Drawing.OfficeArtExtensionList" /> <c>&lt;dsp:extLst></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office.Drawing.ShapeProperties" /> <c>&lt;dsp:spPr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office.Drawing.ShapeStyle" /> <c>&lt;dsp:style></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office.Drawing.TextBody" /> <c>&lt;dsp:txBody></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office.Drawing.Transform2D" /> <c>&lt;dsp:txXfrm></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office.Drawing.ShapeNonVisualProperties" /> <c>&lt;dsp:nvSpPr></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("dsp:sp")]
    public partial class Shape : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the Shape class.
        /// </summary>
        public Shape() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Shape class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Shape(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Shape class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Shape(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Shape class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public Shape(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>modelId, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: modelId</para>
        /// </summary>
        [SchemaAttr("modelId")]
        public StringValue? ModelId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("dsp:sp");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddChild<DocumentFormat.OpenXml.Office.Drawing.OfficeArtExtensionList>();
            builder.AddChild<DocumentFormat.OpenXml.Office.Drawing.ShapeProperties>();
            builder.AddChild<DocumentFormat.OpenXml.Office.Drawing.ShapeStyle>();
            builder.AddChild<DocumentFormat.OpenXml.Office.Drawing.TextBody>();
            builder.AddChild<DocumentFormat.OpenXml.Office.Drawing.Transform2D>();
            builder.AddChild<DocumentFormat.OpenXml.Office.Drawing.ShapeNonVisualProperties>();
            builder.AddElement<Shape>()
                .AddAttribute("modelId", a => a.ModelId, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                    aBuilder.AddUnion(union =>
                    {
                        union.AddValidator<Int32Value>(NumberValidator.Instance);
                        union.AddValidator(new StringValidator() { Pattern = ("\\{[0-9A-F]{8}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{12}\\}") });
                    });
                });
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office.Drawing.ShapeNonVisualProperties), 1, 1, version: FileFormatVersions.Office2010),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office.Drawing.ShapeProperties), 1, 1, version: FileFormatVersions.Office2010),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office.Drawing.ShapeStyle), 0, 1, version: FileFormatVersions.Office2010),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office.Drawing.TextBody), 0, 1, version: FileFormatVersions.Office2010),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office.Drawing.Transform2D), 0, 1, version: FileFormatVersions.Office2010),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office.Drawing.OfficeArtExtensionList), 0, 1, version: FileFormatVersions.Office2010)
            };
        }

        /// <summary>
        /// <para>ShapeNonVisualProperties.</para>
        /// <para>Represents the following element tag in the schema: dsp:nvSpPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:dsp = http://schemas.microsoft.com/office/drawing/2008/diagram
        /// </remark>
        public DocumentFormat.OpenXml.Office.Drawing.ShapeNonVisualProperties? ShapeNonVisualProperties
        {
            get => GetElement<DocumentFormat.OpenXml.Office.Drawing.ShapeNonVisualProperties>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>ShapeProperties.</para>
        /// <para>Represents the following element tag in the schema: dsp:spPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:dsp = http://schemas.microsoft.com/office/drawing/2008/diagram
        /// </remark>
        public DocumentFormat.OpenXml.Office.Drawing.ShapeProperties? ShapeProperties
        {
            get => GetElement<DocumentFormat.OpenXml.Office.Drawing.ShapeProperties>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>ShapeStyle.</para>
        /// <para>Represents the following element tag in the schema: dsp:style.</para>
        /// </summary>
        /// <remark>
        /// xmlns:dsp = http://schemas.microsoft.com/office/drawing/2008/diagram
        /// </remark>
        public DocumentFormat.OpenXml.Office.Drawing.ShapeStyle? ShapeStyle
        {
            get => GetElement<DocumentFormat.OpenXml.Office.Drawing.ShapeStyle>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>TextBody.</para>
        /// <para>Represents the following element tag in the schema: dsp:txBody.</para>
        /// </summary>
        /// <remark>
        /// xmlns:dsp = http://schemas.microsoft.com/office/drawing/2008/diagram
        /// </remark>
        public DocumentFormat.OpenXml.Office.Drawing.TextBody? TextBody
        {
            get => GetElement<DocumentFormat.OpenXml.Office.Drawing.TextBody>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Transform2D.</para>
        /// <para>Represents the following element tag in the schema: dsp:txXfrm.</para>
        /// </summary>
        /// <remark>
        /// xmlns:dsp = http://schemas.microsoft.com/office/drawing/2008/diagram
        /// </remark>
        public DocumentFormat.OpenXml.Office.Drawing.Transform2D? Transform2D
        {
            get => GetElement<DocumentFormat.OpenXml.Office.Drawing.Transform2D>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>OfficeArtExtensionList.</para>
        /// <para>Represents the following element tag in the schema: dsp:extLst.</para>
        /// </summary>
        /// <remark>
        /// xmlns:dsp = http://schemas.microsoft.com/office/drawing/2008/diagram
        /// </remark>
        public DocumentFormat.OpenXml.Office.Drawing.OfficeArtExtensionList? OfficeArtExtensionList
        {
            get => GetElement<DocumentFormat.OpenXml.Office.Drawing.OfficeArtExtensionList>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Shape>(deep);
    }

    /// <summary>
    /// <para>Defines the GroupShape Class.</para>
    /// <para>This class is available in Office 2010 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is dsp:grpSp.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office.Drawing.GroupShapeProperties" /> <c>&lt;dsp:grpSpPr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office.Drawing.OfficeArtExtensionList" /> <c>&lt;dsp:extLst></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office.Drawing.GroupShape" /> <c>&lt;dsp:grpSp></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office.Drawing.GroupShapeNonVisualProperties" /> <c>&lt;dsp:nvGrpSpPr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office.Drawing.Shape" /> <c>&lt;dsp:sp></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("dsp:grpSp")]
    public partial class GroupShape : GroupShapeType
    {
        /// <summary>
        /// Initializes a new instance of the GroupShape class.
        /// </summary>
        public GroupShape() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the GroupShape class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public GroupShape(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the GroupShape class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public GroupShape(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the GroupShape class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public GroupShape(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("dsp:grpSp");
            builder.Availability = FileFormatVersions.Office2010;
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office.Drawing.GroupShapeNonVisualProperties), 1, 1, version: FileFormatVersions.Office2010),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office.Drawing.GroupShapeProperties), 1, 1, version: FileFormatVersions.Office2010),
                new CompositeParticle.Builder(ParticleType.Choice, 0, 0)
                {
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Office.Drawing.Shape), 1, 1, version: FileFormatVersions.Office2010),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Office.Drawing.GroupShape), 1, 1, version: FileFormatVersions.Office2010)
                },
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office.Drawing.OfficeArtExtensionList), 0, 1, version: FileFormatVersions.Office2010)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<GroupShape>(deep);
    }

    /// <summary>
    /// <para>Defines the ShapeTree Class.</para>
    /// <para>This class is available in Office 2010 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is dsp:spTree.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office.Drawing.GroupShapeProperties" /> <c>&lt;dsp:grpSpPr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office.Drawing.OfficeArtExtensionList" /> <c>&lt;dsp:extLst></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office.Drawing.GroupShape" /> <c>&lt;dsp:grpSp></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office.Drawing.GroupShapeNonVisualProperties" /> <c>&lt;dsp:nvGrpSpPr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office.Drawing.Shape" /> <c>&lt;dsp:sp></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("dsp:spTree")]
    public partial class ShapeTree : GroupShapeType
    {
        /// <summary>
        /// Initializes a new instance of the ShapeTree class.
        /// </summary>
        public ShapeTree() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the ShapeTree class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ShapeTree(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ShapeTree class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ShapeTree(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ShapeTree class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public ShapeTree(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("dsp:spTree");
            builder.Availability = FileFormatVersions.Office2010;
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office.Drawing.GroupShapeNonVisualProperties), 1, 1, version: FileFormatVersions.Office2010),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office.Drawing.GroupShapeProperties), 1, 1, version: FileFormatVersions.Office2010),
                new CompositeParticle.Builder(ParticleType.Choice, 0, 0)
                {
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Office.Drawing.Shape), 1, 1, version: FileFormatVersions.Office2010),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Office.Drawing.GroupShape), 1, 1, version: FileFormatVersions.Office2010)
                },
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office.Drawing.OfficeArtExtensionList), 0, 1, version: FileFormatVersions.Office2010)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ShapeTree>(deep);
    }

    /// <summary>
    /// <para>Defines the GroupShapeType Class.</para>
    /// <para>This class is available in Office 2010 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is :.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office.Drawing.GroupShapeProperties" /> <c>&lt;dsp:grpSpPr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office.Drawing.OfficeArtExtensionList" /> <c>&lt;dsp:extLst></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office.Drawing.GroupShape" /> <c>&lt;dsp:grpSp></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office.Drawing.GroupShapeNonVisualProperties" /> <c>&lt;dsp:nvGrpSpPr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office.Drawing.Shape" /> <c>&lt;dsp:sp></c></description></item>
    /// </list>
    /// </remark>
    public abstract partial class GroupShapeType : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the GroupShapeType class.
        /// </summary>
        protected GroupShapeType() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the GroupShapeType class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        protected GroupShapeType(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the GroupShapeType class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        protected GroupShapeType(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the GroupShapeType class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        protected GroupShapeType(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.AddChild<DocumentFormat.OpenXml.Office.Drawing.GroupShapeProperties>();
            builder.AddChild<DocumentFormat.OpenXml.Office.Drawing.OfficeArtExtensionList>();
            builder.AddChild<DocumentFormat.OpenXml.Office.Drawing.GroupShape>();
            builder.AddChild<DocumentFormat.OpenXml.Office.Drawing.GroupShapeNonVisualProperties>();
            builder.AddChild<DocumentFormat.OpenXml.Office.Drawing.Shape>();
        }

        /// <summary>
        /// <para>GroupShapeNonVisualProperties.</para>
        /// <para>Represents the following element tag in the schema: dsp:nvGrpSpPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:dsp = http://schemas.microsoft.com/office/drawing/2008/diagram
        /// </remark>
        public DocumentFormat.OpenXml.Office.Drawing.GroupShapeNonVisualProperties? GroupShapeNonVisualProperties
        {
            get => GetElement<DocumentFormat.OpenXml.Office.Drawing.GroupShapeNonVisualProperties>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>GroupShapeProperties.</para>
        /// <para>Represents the following element tag in the schema: dsp:grpSpPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:dsp = http://schemas.microsoft.com/office/drawing/2008/diagram
        /// </remark>
        public DocumentFormat.OpenXml.Office.Drawing.GroupShapeProperties? GroupShapeProperties
        {
            get => GetElement<DocumentFormat.OpenXml.Office.Drawing.GroupShapeProperties>();
            set => SetElement(value);
        }
    }
}