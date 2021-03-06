﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//    Generated by Xsd2Code. Version 3.4.0.38967
//    <NameSpace>Terradue.ServiceModel.Ogc.Alt20</NameSpace><Collection>Array</Collection><codeType>CSharp</codeType><EnableDataBinding>False</EnableDataBinding><EnableLazyLoading>False</EnableLazyLoading><TrackingChangesEnable>False</TrackingChangesEnable><GenTrackingClasses>False</GenTrackingClasses><HidePrivateFieldInIDE>False</HidePrivateFieldInIDE><EnableSummaryComment>False</EnableSummaryComment><VirtualProp>False</VirtualProp><IncludeSerializeMethod>False</IncludeSerializeMethod><UseBaseClass>False</UseBaseClass><GenBaseClass>False</GenBaseClass><GenerateCloneMethod>False</GenerateCloneMethod><GenerateDataContracts>False</GenerateDataContracts><CodeBaseTag>Net40</CodeBaseTag><SerializeMethodName>Serialize</SerializeMethodName><DeserializeMethodName>Deserialize</DeserializeMethodName><SaveToFileMethodName>SaveToFile</SaveToFileMethodName><LoadFromFileMethodName>LoadFromFile</LoadFromFileMethodName><GenerateXMLAttributes>True</GenerateXMLAttributes><EnableEncoding>False</EnableEncoding><AutomaticProperties>False</AutomaticProperties><GenerateShouldSerialize>False</GenerateShouldSerialize><DisableDebug>False</DisableDebug><PropNameSpecified>Default</PropNameSpecified><Encoder>UTF8</Encoder><CustomUsings></CustomUsings><ExcludeIncludedTypes>True</ExcludeIncludedTypes><EnableInitializeFields>False</EnableInitializeFields>
//  </auto-generated>
// ------------------------------------------------------------------------------
using Terradue.ServiceModel.Ogc.Eop20;
using Terradue.ServiceModel.Ogc.Om;
using Terradue.ServiceModel.Ogc.Gml321;

namespace Terradue.ServiceModel.Ogc.Alt20
{
    using System;
    using System.Diagnostics;
    using System.Xml.Serialization;
    using System.Collections;
    using System.Xml.Schema;
    using System.ComponentModel;

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "EarthObservationType", Namespace = "http://www.opengis.net/alt/2.0")]
    [System.Xml.Serialization.XmlRootAttribute("EarthObservation", Namespace = "http://www.opengis.net/alt/2.0", IsNullable = false)]
    public partial class AltEarthObservationType : EarthObservationType
    {



    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "FootprintType", Namespace = "http://www.opengis.net/alt/2.0")]
    [System.Xml.Serialization.XmlRootAttribute("Footprint", Namespace = "http://www.opengis.net/alt/2.0", IsNullable = false)]
    public partial class AltFootprintType : FootprintType
    {

        private MultiCurvePropertyType nominalTrackField;

        [System.Xml.Serialization.XmlElementAttribute()]
        public MultiCurvePropertyType nominalTrack
        {
            get
            {
                return this.nominalTrackField;
            }
            set
            {
                this.nominalTrackField = value;
            }
        }
    }

    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AltEarthObservationEquipmentType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/alt/2.0")]
    public partial class AltEarthObservationEquipmentType : EarthObservationEquipmentType
    {

        private AuxiliaryInstrumentPropertyType[] auxiliaryInstrumentField;

        [System.Xml.Serialization.XmlElementAttribute("auxiliaryInstrument")]
        public AuxiliaryInstrumentPropertyType[] auxiliaryInstrument
        {
            get
            {
                return this.auxiliaryInstrumentField;
            }
            set
            {
                this.auxiliaryInstrumentField = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "AcquisitionType", Namespace = "http://www.opengis.net/alt/2.0")]
    [System.Xml.Serialization.XmlRootAttribute("Acquisition", Namespace = "http://www.opengis.net/alt/2.0", IsNullable = false)]
    public partial class AltAcquisitionType : AcquisitionType
    {

        private string cycleNumberField;

        private bool isSegmentField;

        private bool isSegmentFieldSpecified;

        private string relativePassNumberField;

        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string cycleNumber
        {
            get
            {
                return this.cycleNumberField;
            }
            set
            {
                this.cycleNumberField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute()]
        public bool isSegment
        {
            get
            {
                return this.isSegmentField;
            }
            set
            {
                this.isSegmentField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isSegmentSpecified
        {
            get
            {
                return this.isSegmentFieldSpecified;
            }
            set
            {
                this.isSegmentFieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string relativePassNumber
        {
            get
            {
                return this.relativePassNumberField;
            }
            set
            {
                this.relativePassNumberField = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/eop/2.0")]
    public partial class AltEarthObservationMetaDataPropertyType : EarthObservationMetaDataPropertyType
    {

        private EarthObservationMetaDataType earthObservationMetaDataField;

        [System.Xml.Serialization.XmlElementAttribute(Type=typeof(AltEarthObservationMetaDataType))]
        public EarthObservationMetaDataType EarthObservationMetaData
        {
            get
            {
                return this.earthObservationMetaDataField;
            }
            set
            {
                this.earthObservationMetaDataField = value;
            }
        }
    }

    [System.Xml.Serialization.XmlIncludeAttribute(typeof(EarthObservationMetaDataType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/eop/2.0")]
    public partial class AltEarthObservationMetaDataType : EarthObservationMetaDataType
    {
        
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "ProcessingInformationType", Namespace = "http://www.opengis.net/alt/2.0")]
    [System.Xml.Serialization.XmlRootAttribute("ProcessingInformation", Namespace = "http://www.opengis.net/alt/2.0", IsNullable = false)]
    public partial class AltProcessingInformationType : ProcessingInformationType
    {

        private MeasureType groundTrackUncertaintyField;

        private string[] productContentsTypeField;

        private MeasureType[] samplingRateField;

        [System.Xml.Serialization.XmlElementAttribute()]
        public MeasureType groundTrackUncertainty
        {
            get
            {
                return this.groundTrackUncertaintyField;
            }
            set
            {
                this.groundTrackUncertaintyField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("productContentsType")]
        public string[] productContentsType
        {
            get
            {
                return this.productContentsTypeField;
            }
            set
            {
                this.productContentsTypeField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("samplingRate")]
        public MeasureType[] samplingRate
        {
            get
            {
                return this.samplingRateField;
            }
            set
            {
                this.samplingRateField = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/alt/2.0")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.opengis.net/alt/2.0", IsNullable = true)]
    public partial class AuxiliaryInstrumentPropertyType
    {

        private AuxiliaryInstrumentType auxiliaryInstrumentField;

        private bool ownsField;

        public AuxiliaryInstrumentPropertyType()
        {
            this.ownsField = false;
        }

        [System.Xml.Serialization.XmlElementAttribute()]
        public AuxiliaryInstrumentType AuxiliaryInstrument
        {
            get
            {
                return this.auxiliaryInstrumentField;
            }
            set
            {
                this.auxiliaryInstrumentField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool owns
        {
            get
            {
                return this.ownsField;
            }
            set
            {
                this.ownsField = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/alt/2.0")]
    [System.Xml.Serialization.XmlRootAttribute("AuxiliaryInstrument", Namespace = "http://www.opengis.net/alt/2.0", IsNullable = false)]
    public partial class AuxiliaryInstrumentType : InstrumentType
    {

        private string instrumentType1Field;

        [System.Xml.Serialization.XmlElementAttribute("instrumentType")]
        public string instrumentType1
        {
            get
            {
                return this.instrumentType1Field;
            }
            set
            {
                this.instrumentType1Field = value;
            }
        }
    }

   
}
