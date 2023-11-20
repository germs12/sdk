/*
 * Ory APIs
 *
 * Documentation for all public and administrative Ory APIs. Administrative APIs can only be accessed with a valid Personal Access Token. Public APIs are mostly used in browsers. 
 *
 * The version of the OpenAPI document: v1.4.2
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
    /// ClientAttributesCountDatapoint
    /// </summary>
    [DataContract(Name = "AttributesCountDatapoint")]
    public partial class ClientAttributesCountDatapoint : IEquatable<ClientAttributesCountDatapoint>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ClientAttributesCountDatapoint" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ClientAttributesCountDatapoint()
        {
            this.AdditionalProperties = new Dictionary<string, object>();
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="ClientAttributesCountDatapoint" /> class.
        /// </summary>
        /// <param name="count">Count of the attribute value for given key (required).</param>
        /// <param name="name">Name of the attribute value for given key (required).</param>
        public ClientAttributesCountDatapoint(long count = default(long), string name = default(string))
        {
            this.Count = count;
            // to ensure "name" is required (not null)
            if (name == null) {
                throw new ArgumentNullException("name is a required property for ClientAttributesCountDatapoint and cannot be null");
            }
            this.Name = name;
            this.AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// Count of the attribute value for given key
        /// </summary>
        /// <value>Count of the attribute value for given key</value>
        [DataMember(Name = "count", IsRequired = true, EmitDefaultValue = false)]
        public long Count { get; set; }

        /// <summary>
        /// Name of the attribute value for given key
        /// </summary>
        /// <value>Name of the attribute value for given key</value>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = false)]
        public string Name { get; set; }

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
            sb.Append("class ClientAttributesCountDatapoint {\n");
            sb.Append("  Count: ").Append(Count).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
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
            return this.Equals(input as ClientAttributesCountDatapoint);
        }

        /// <summary>
        /// Returns true if ClientAttributesCountDatapoint instances are equal
        /// </summary>
        /// <param name="input">Instance of ClientAttributesCountDatapoint to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ClientAttributesCountDatapoint input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Count == input.Count ||
                    this.Count.Equals(input.Count)
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
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
                hashCode = (hashCode * 59) + this.Count.GetHashCode();
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
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
