﻿using System;
using Terradue.ServiceModel.Ogc.Ssp20;
using System.Xml.Serialization;


namespace Terradue.ServiceModel.Ogc.Eop20 {
    
    public partial class FootprintPropertyType {

        [XmlIgnore]
        public SspFootprintType SspFootprint {
            get {
                if (Footprint is SspFootprintType)
                    return (SspFootprintType)Footprint;
                return null;
            }
            set {
                Footprint = value;
            }
        }

    }


    public partial class EarthObservationMetaDataPropertyType {

        [XmlIgnore]
        public SspEarthObservationMetaDataType SspEarthObservationMetaData {
            get {
                if (EarthObservationMetaData is SspEarthObservationMetaDataType)
                    return (SspEarthObservationMetaDataType)EarthObservationMetaData;
                return null;
            }
            set {
                EarthObservationMetaData = value;
            }
        }

    }
}

