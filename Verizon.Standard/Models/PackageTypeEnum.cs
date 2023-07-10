// <copyright file="PackageTypeEnum.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
namespace Verizon.Standard.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using Verizon.Standard;
    using Verizon.Standard.Utilities;

    /// <summary>
    /// PackageTypeEnum.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PackageTypeEnum
    {
        /// <summary>
        /// HELM.
        /// </summary>
        [EnumMember(Value = "HELM")]
        HELM,

        /// <summary>
        /// YAML.
        /// </summary>
        [EnumMember(Value = "YAML")]
        YAML,

        /// <summary>
        /// TERRAFORM.
        /// </summary>
        [EnumMember(Value = "TERRAFORM")]
        TERRAFORM
    }
}