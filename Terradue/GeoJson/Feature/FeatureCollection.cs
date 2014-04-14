﻿//
//  FeatureCollection.cs
//
//  Author:
//       Emmanuel Mathot <emmanuel.mathot@terradue.com>
//
//  Copyright (c) 2014 Terradue
//
//  Adapted from GeoJSON.Net / https://github.com/jbattermann/GeoJSON.Net
//      Copyright (c) Jörg Battermann 2011

namespace Terradue.GeoJson.Feature {
    using System.Collections.Generic;
    using System.Runtime.Serialization;
    using System;

    /// <summary>
    /// Defines the FeatureCollection type.
    /// </summary>
    [DataContract]
    public class FeatureCollection : GeoJsonObject {
        /// <summary>
        /// Initializes a new instance of the <see cref="FeatureCollection"/> class.
        /// </summary>
        public FeatureCollection() {
            this.Features = new List<Feature>();
            this.Type = GeoJsonObjectType.FeatureCollection;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FeatureCollection"/> class.
        /// </summary>
        /// <param name="features">The features.</param>
        public FeatureCollection(List<Feature> features) {
            this.Features = features;
            this.Type = GeoJsonObjectType.FeatureCollection;
        }

        /// <summary>
        /// Gets the features.
        /// </summary>
        /// <value>The features.</value>
        [DataMember(Name = "features", IsRequired = true)]
        public List<Feature> Features { get; private set; }

        /// <summary>
        /// Gets the properties.
        /// </summary>
        /// <value>The properties.</value>
        [DataMember(Name = "properties")]
        public Dictionary<string, object> Properties { get; set; }
    }
}