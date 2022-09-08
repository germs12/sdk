/*
 * Ory APIs
 *
 * Documentation for all public and administrative Ory APIs. Administrative APIs can only be accessed with a valid Personal Access Token. Public APIs are mostly used in browsers. 
 *
 * The version of the OpenAPI document: v0.2.0-alpha.36
 * Contact: support@ory.sh
 * Generated by: https://openapi-generator.tech
 */




#[derive(Clone, Debug, PartialEq, Serialize, Deserialize)]
pub struct GetManagedIdentitySchemaLocation {
    #[serde(rename = "location", skip_serializing_if = "Option::is_none")]
    pub location: Option<String>,
}

impl Default for GetManagedIdentitySchemaLocation {
    fn default() -> Self {
        Self::new()
    }
}

impl GetManagedIdentitySchemaLocation {
    pub fn new() -> GetManagedIdentitySchemaLocation {
        GetManagedIdentitySchemaLocation {
                location: None,
        }
    }
}


