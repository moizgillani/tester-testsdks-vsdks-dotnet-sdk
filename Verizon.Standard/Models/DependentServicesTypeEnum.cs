// <copyright file="DependentServicesTypeEnum.cs" company="APIMatic">
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
    /// DependentServicesTypeEnum.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum DependentServicesTypeEnum
    {
        /// <summary>
        /// MYSERVICE.
        /// </summary>
        [EnumMember(Value = "MY_SERVICE")]
        MYSERVICE
    }
}