/*
 * Ory APIs
 *
 * Documentation for all public and administrative Ory APIs. Administrative APIs can only be accessed with a valid Personal Access Token. Public APIs are mostly used in browsers. 
 *
 * The version of the OpenAPI document: v0.2.0-alpha.32
 * Contact: support@ory.sh
 * Generated by: https://openapi-generator.tech
 */




#[derive(Clone, Debug, PartialEq, Serialize, Deserialize)]
pub struct ManagedIdentitySchemaValidationResult {
    #[serde(rename = "message", skip_serializing_if = "Option::is_none")]
    pub message: Option<String>,
    #[serde(rename = "valid", skip_serializing_if = "Option::is_none")]
    pub valid: Option<bool>,
}

impl Default for ManagedIdentitySchemaValidationResult {
    fn default() -> Self {
        Self::new()
    }
}

impl ManagedIdentitySchemaValidationResult {
    pub fn new() -> ManagedIdentitySchemaValidationResult {
        ManagedIdentitySchemaValidationResult {
                message: None,
                valid: None,
        }
    }
}

