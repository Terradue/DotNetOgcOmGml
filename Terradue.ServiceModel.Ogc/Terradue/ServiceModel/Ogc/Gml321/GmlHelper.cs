// ------------------------------------------------------------------------------
//  <auto-generated>
//    Generated by Xsd2Code. Version 3.4.0.38967
//    <NameSpace>Terradue.ServiceModel.Ogc.Gml311</NameSpace><Collection>Array</Collection><codeType>CSharp</codeType><EnableDataBinding>False</EnableDataBinding><EnableLazyLoading>False</EnableLazyLoading><TrackingChangesEnable>False</TrackingChangesEnable><GenTrackingClasses>False</GenTrackingClasses><HidePrivateFieldInIDE>False</HidePrivateFieldInIDE><EnableSummaryComment>False</EnableSummaryComment><VirtualProp>False</VirtualProp><IncludeSerializeMethod>False</IncludeSerializeMethod><UseBaseClass>False</UseBaseClass><GenBaseClass>False</GenBaseClass><GenerateCloneMethod>False</GenerateCloneMethod><GenerateDataContracts>False</GenerateDataContracts><CodeBaseTag>Net40</CodeBaseTag><SerializeMethodName>Serialize</SerializeMethodName><DeserializeMethodName>Deserialize</DeserializeMethodName><SaveToFileMethodName>SaveToFile</SaveToFileMethodName><LoadFromFileMethodName>LoadFromFile</LoadFromFileMethodName><GenerateXMLAttributes>True</GenerateXMLAttributes><EnableEncoding>False</EnableEncoding><AutomaticProperties>False</AutomaticProperties><GenerateShouldSerialize>False</GenerateShouldSerialize><DisableDebug>False</DisableDebug><PropNameSpecified>Default</PropNameSpecified><Encoder>UTF8</Encoder><CustomUsings></CustomUsings><ExcludeIncludedTypes>True</ExcludeIncludedTypes><EnableInitializeFields>False</EnableInitializeFields>
//  </auto-generated>
// ------------------------------------------------------------------------------
using Terradue.ServiceModel.W3c.Smil20Lang;
using System.Xml;
using System.Xml.Linq;

namespace Terradue.ServiceModel.Ogc.Gml321
{
    using System;
    using System.Diagnostics;
    using System.Xml.Serialization;
    using System.Collections;
    using System.Xml.Schema;
    using System.ComponentModel;

    public static class GmlHelper {

        static XmlSerializer multiCurveSerializer;
        static XmlSerializer nultiSurfaceSerializer;

        public static AbstractGeometryType Deserialize(XmlReader reader){

            var node = XElement.Load(reader);
            reader = node.CreateReader();

            if (node.Name.NamespaceName != "http://www.opengis.net/gml/3.2")
                throw new FormatException("The xml is not GML");

            if (node.Name.LocalName == "MultiCurve") {
                return (MultiCurveType)MultiCurveSerializer.Deserialize(reader);
            }

            if (node.Name.LocalName == "MultiSurface") {
                return (MultiSurfaceType)MultiSurfaceSerializer.Deserialize(reader);
            }

            throw new NotImplementedException();
        }

        public static void Serialize(XmlWriter writer, AbstractGeometryType gmlObject){

            XmlSerializerNamespaces namespaces = new XmlSerializerNamespaces();
            namespaces.Add(string.Empty, string.Empty);
            namespaces.Add("gml", "http://www.opengis.net/gml/3.2");

            if (gmlObject is MultiCurveType) {
                MultiCurveSerializer.Serialize(writer, gmlObject, namespaces);
                return;
            }

            if (gmlObject is MultiSurfaceType) {
                MultiSurfaceSerializer.Serialize(writer, gmlObject, namespaces);
                return;
            }

            throw new NotImplementedException();

        }

        public static XmlSerializer MultiCurveSerializer {
            get {
                if (multiCurveSerializer == null)
                    multiCurveSerializer = new XmlSerializer(typeof(MultiCurveType));
                return multiCurveSerializer;
            }
        }

        public static XmlSerializer MultiSurfaceSerializer {
            get {
                if (nultiSurfaceSerializer == null)
                    nultiSurfaceSerializer = new XmlSerializer(typeof(MultiSurfaceType));
                return nultiSurfaceSerializer;
            }
        }
    }
    
}