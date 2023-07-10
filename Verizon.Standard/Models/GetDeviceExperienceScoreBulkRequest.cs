// <copyright file="GetDeviceExperienceScoreBulkRequest.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
namespace Verizon.Standard.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using Verizon.Standard;
    using Verizon.Standard.Utilities;

    /// <summary>
    /// GetDeviceExperienceScoreBulkRequest.
    /// </summary>
    public class GetDeviceExperienceScoreBulkRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetDeviceExperienceScoreBulkRequest"/> class.
        /// </summary>
        public GetDeviceExperienceScoreBulkRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetDeviceExperienceScoreBulkRequest"/> class.
        /// </summary>
        /// <param name="accountName">accountName.</param>
        /// <param name="deviceListItem">deviceListItem.</param>
        public GetDeviceExperienceScoreBulkRequest(
            string accountName,
            List<Models.DeviceIdentifier> deviceListItem)
        {
            this.AccountName = accountName;
            this.DeviceListItem = deviceListItem;
        }

        /// <summary>
        /// Gets or sets AccountName.
        /// </summary>
        [JsonProperty("accountName")]
        public string AccountName { get; set; }

        /// <summary>
        /// Gets or sets DeviceListItem.
        /// </summary>
        [JsonProperty("deviceListItem")]
        public List<Models.DeviceIdentifier> DeviceListItem { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"GetDeviceExperienceScoreBulkRequest : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }

            if (obj == this)
            {
                return true;
            }
            return obj is GetDeviceExperienceScoreBulkRequest other &&                ((this.AccountName == null && other.AccountName == null) || (this.AccountName?.Equals(other.AccountName) == true)) &&
                ((this.DeviceListItem == null && other.DeviceListItem == null) || (this.DeviceListItem?.Equals(other.DeviceListItem) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.AccountName = {(this.AccountName == null ? "null" : this.AccountName == string.Empty ? "" : this.AccountName)}");
            toStringOutput.Add($"this.DeviceListItem = {(this.DeviceListItem == null ? "null" : $"[{string.Join(", ", this.DeviceListItem)} ]")}");
        }
    }
}