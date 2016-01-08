﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//    Generated by Xsd2Code. Version 3.4.0.38967
//    <NameSpace>Terradue.ServiceModel.Ogc.Sar20</NameSpace><Collection>Array</Collection><codeType>CSharp</codeType><EnableDataBinding>False</EnableDataBinding><EnableLazyLoading>False</EnableLazyLoading><TrackingChangesEnable>False</TrackingChangesEnable><GenTrackingClasses>False</GenTrackingClasses><HidePrivateFieldInIDE>False</HidePrivateFieldInIDE><EnableSummaryComment>False</EnableSummaryComment><VirtualProp>False</VirtualProp><IncludeSerializeMethod>False</IncludeSerializeMethod><UseBaseClass>False</UseBaseClass><GenBaseClass>False</GenBaseClass><GenerateCloneMethod>False</GenerateCloneMethod><GenerateDataContracts>False</GenerateDataContracts><CodeBaseTag>Net40</CodeBaseTag><SerializeMethodName>Serialize</SerializeMethodName><DeserializeMethodName>Deserialize</DeserializeMethodName><SaveToFileMethodName>SaveToFile</SaveToFileMethodName><LoadFromFileMethodName>LoadFromFile</LoadFromFileMethodName><GenerateXMLAttributes>True</GenerateXMLAttributes><EnableEncoding>False</EnableEncoding><AutomaticProperties>False</AutomaticProperties><GenerateShouldSerialize>False</GenerateShouldSerialize><DisableDebug>False</DisableDebug><PropNameSpecified>Default</PropNameSpecified><Encoder>UTF8</Encoder><CustomUsings></CustomUsings><ExcludeIncludedTypes>True</ExcludeIncludedTypes><EnableInitializeFields>False</EnableInitializeFields>
//  </auto-generated>
// ------------------------------------------------------------------------------
using Terradue.ServiceModel.Ogc.Eop20;
using Terradue.ServiceModel.Ogc.Om;
using Terradue.ServiceModel.Ogc.Gml321;

namespace Terradue.ServiceModel.Ogc.Sar20
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
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "EarthObservationType", Namespace = "http://www.opengis.net/sar/2.0")]
    [System.Xml.Serialization.XmlRootAttribute("EarthObservation", Namespace = "http://www.opengis.net/sar/2.0", IsNullable = false)]
    public partial class SarEarthObservationType : EarthObservationType
    {

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/eop/2.0")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.opengis.net/eop/2.0", IsNullable = true)]
    public partial class SarEarthObservationEquipmentPropertyType : EarthObservationEquipmentPropertyType
    {


    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/eop/2.0")]
    [System.Xml.Serialization.XmlRootAttribute("EarthObservationEquipment", Namespace = "http://www.opengis.net/eop/2.0", IsNullable = false)]
    public partial class SarEarthObservationEquipmentType : EarthObservationEquipmentType
    {

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "AcquisitionPropertyType", Namespace = "http://www.opengis.net/sar/2.0")]
    [System.Xml.Serialization.XmlRootAttribute("AcquisitionPropertyType", Namespace = "http://www.opengis.net/sar/2.0", IsNullable = true)]
    public partial class SarAcquisitionPropertyType : AcquisitionPropertyType 
    {

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "AcquisitionType", Namespace = "http://www.opengis.net/sar/2.0")]
    [System.Xml.Serialization.XmlRootAttribute("Acquisition", Namespace = "http://www.opengis.net/sar/2.0", IsNullable = false)]
    public partial class SarAcquisitionType : AcquisitionType
    {

        private string polarisationModeField;

        private string polarisationChannelsField;

        private string antennaLookDirectionField;

        private AngleType minimumIncidenceAngleField;

        private AngleType maximumIncidenceAngleField;

        private AngleType incidenceAngleVariationField;

        private MeasureType dopplerFrequencyField;

        [System.Xml.Serialization.XmlElementAttribute()]
        public string polarisationMode
        {
            get
            {
                return this.polarisationModeField;
            }
            set
            {
                this.polarisationModeField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute()]
        public string polarisationChannels
        {
            get
            {
                return this.polarisationChannelsField;
            }
            set
            {
                this.polarisationChannelsField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute()]
        public string antennaLookDirection
        {
            get
            {
                return this.antennaLookDirectionField;
            }
            set
            {
                this.antennaLookDirectionField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute()]
        public AngleType minimumIncidenceAngle
        {
            get
            {
                return this.minimumIncidenceAngleField;
            }
            set
            {
                this.minimumIncidenceAngleField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute()]
        public AngleType maximumIncidenceAngle
        {
            get
            {
                return this.maximumIncidenceAngleField;
            }
            set
            {
                this.maximumIncidenceAngleField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute()]
        public AngleType incidenceAngleVariation
        {
            get
            {
                return this.incidenceAngleVariationField;
            }
            set
            {
                this.incidenceAngleVariationField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute()]
        public MeasureType dopplerFrequency
        {
            get
            {
                return this.dopplerFrequencyField;
            }
            set
            {
                this.dopplerFrequencyField = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/sar/2.0")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.opengis.net/sar/2.0", IsNullable = true)]
    public partial class EarthObservationPropertyType
    {

        private SarEarthObservationType earthObservationField;

        private string nilReasonField;

        private string remoteSchemaField;

        private bool ownsField;

        public EarthObservationPropertyType()
        {
            this.ownsField = false;
        }

        [System.Xml.Serialization.XmlElementAttribute()]
        public SarEarthObservationType EarthObservation
        {
            get
            {
                return this.earthObservationField;
            }
            set
            {
                this.earthObservationField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string nilReason
        {
            get
            {
                return this.nilReasonField;
            }
            set
            {
                this.nilReasonField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.opengis.net/gml/3.2", DataType = "anyURI")]
        public string remoteSchema
        {
            get
            {
                return this.remoteSchemaField;
            }
            set
            {
                this.remoteSchemaField = value;
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
}
