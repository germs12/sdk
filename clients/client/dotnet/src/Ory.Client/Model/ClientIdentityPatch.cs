/*
 * Ory APIs
 *
 * Documentation for all public and administrative Ory APIs. Administrative APIs can only be accessed with a valid Personal Access Token. Public APIs are mostly used in browsers. 
 *
 * The version of the OpenAPI document: v1.1.32
 * Contact: support@ory.sh
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Ory.Client.Client.OpenAPIDateConverter;

namespace Ory.Client.Model
{
    /// <summary>
    /// Payload for patching an identity
    /// </summary>
    [DataContract(Name = "identityPatch")]
    public partial class ClientIdentityPatch : IEquatable<ClientIdentityPatch>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ClientIdentityPatch" /> class.
        /// </summary>
        /// <param name="create">create.</param>
        /// <param name="patchId">The ID of this patch.  The patch ID is optional. If specified, the ID will be returned in the response, so consumers of this API can correlate the response with the patch..</param>
        public ClientIdentityPatch(ClientCreateIdentityBody create = default(ClientCreateIdentityBody), string patchId = default(string))
        {
            this.Create = create;
            this.PatchId = patchId;
            this.AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// Gets or Sets Create
        /// </summary>
        [DataMember(Name = "create", EmitDefaultValue = false)]
        public ClientCreateIdentityBody Create { get; set; }

        /// <summary>
        /// The ID of this patch.  The patch ID is optional. If specified, the ID will be returned in the response, so consumers of this API can correlate the response with the patch.
        /// </summary>
        /// <value>The ID of this patch.  The patch ID is optional. If specified, the ID will be returned in the response, so consumers of this API can correlate the response with the patch.</value>
        [DataMember(Name = "patch_id", EmitDefaultValue = false)]
        public string PatchId { get; set; }

        /// <summary>
        /// Gets or Sets additional properties
        /// </summary>
        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ClientIdentityPatch {\n");
            sb.Append("  Create: ").Append(Create).Append("\n");
            sb.Append("  PatchId: ").Append(PatchId).Append("\n");
            sb.Append("  AdditionalProperties: ").Append(AdditionalProperties).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as ClientIdentityPatch);
        }

        /// <summary>
        /// Returns true if ClientIdentityPatch instances are equal
        /// </summary>
        /// <param name="input">Instance of ClientIdentityPatch to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ClientIdentityPatch input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Create == input.Create ||
                    (this.Create != null &&
                    this.Create.Equals(input.Create))
                ) && 
                (
                    this.PatchId == input.PatchId ||
                    (this.PatchId != null &&
                    this.PatchId.Equals(input.PatchId))
                )
                && (this.AdditionalProperties.Count == input.AdditionalProperties.Count && !this.AdditionalProperties.Except(input.AdditionalProperties).Any());
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Create != null)
                {
                    hashCode = (hashCode * 59) + this.Create.GetHashCode();
                }
                if (this.PatchId != null)
                {
                    hashCode = (hashCode * 59) + this.PatchId.GetHashCode();
                }
                if (this.AdditionalProperties != null)
                {
                    hashCode = (hashCode * 59) + this.AdditionalProperties.GetHashCode();
                }
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        public IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
