/*
 * Ory APIs
 *
 * Documentation for all public and administrative Ory APIs. Administrative APIs can only be accessed with a valid Personal Access Token. Public APIs are mostly used in browsers. 
 *
 * The version of the OpenAPI document: v0.0.1-alpha.183
 * Contact: support@ory.sh
 * Generated by: https://openapi-generator.tech
 */

/// GetCheckResponse : The content of the allowed field is mirrored in the HTTP status code.



#[derive(Clone, Debug, PartialEq, Serialize, Deserialize)]
pub struct GetCheckResponse {
    /// whether the relation tuple is allowed
    #[serde(rename = "allowed")]
    pub allowed: bool,
}

impl GetCheckResponse {
    /// The content of the allowed field is mirrored in the HTTP status code.
    pub fn new(allowed: bool) -> GetCheckResponse {
        GetCheckResponse {
            allowed,
        }
    }
}

