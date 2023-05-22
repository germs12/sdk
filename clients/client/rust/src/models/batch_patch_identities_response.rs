/*
 * Ory APIs
 *
 * Documentation for all public and administrative Ory APIs. Administrative APIs can only be accessed with a valid Personal Access Token. Public APIs are mostly used in browsers. 
 *
 * The version of the OpenAPI document: v1.1.32
 * Contact: support@ory.sh
 * Generated by: https://openapi-generator.tech
 */

/// BatchPatchIdentitiesResponse : Patch identities response



#[derive(Clone, Debug, PartialEq, Serialize, Deserialize)]
pub struct BatchPatchIdentitiesResponse {
    /// The patch responses for the individual identities.
    #[serde(rename = "identities", skip_serializing_if = "Option::is_none")]
    pub identities: Option<Vec<crate::models::IdentityPatchResponse>>,
}

impl Default for BatchPatchIdentitiesResponse {
    fn default() -> Self {
        Self::new()
    }
}

impl BatchPatchIdentitiesResponse {
    /// Patch identities response
    pub fn new() -> BatchPatchIdentitiesResponse {
        BatchPatchIdentitiesResponse {
                identities: None,
        }
    }
}


