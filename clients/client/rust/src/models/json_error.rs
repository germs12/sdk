/*
 * Ory APIs
 *
 * Documentation for all public and administrative Ory APIs. Administrative APIs can only be accessed with a valid Personal Access Token. Public APIs are mostly used in browsers. 
 *
 * The version of the OpenAPI document: v0.2.0-alpha.36
 * Contact: support@ory.sh
 * Generated by: https://openapi-generator.tech
 */

/// JsonError : The standard Ory JSON API error format.



#[derive(Clone, Debug, PartialEq, Serialize, Deserialize)]
pub struct JsonError {
    #[serde(rename = "error")]
    pub error: Box<crate::models::GenericError>,
    /// Debug contains debug information. This is usually not available and has to be enabled.
    #[serde(rename = "error_debug", skip_serializing_if = "Option::is_none")]
    pub error_debug: Option<String>,
    /// Description contains further information on the nature of the error.
    #[serde(rename = "error_description", skip_serializing_if = "Option::is_none")]
    pub error_description: Option<String>,
    /// Code represents the error status code (404, 403, 401, ...).
    #[serde(rename = "status_code", skip_serializing_if = "Option::is_none")]
    pub status_code: Option<i64>,
}


impl JsonError {
    /// The standard Ory JSON API error format.
    pub fn new(error: crate::models::GenericError) -> JsonError {
        JsonError {
                error: Box::new(error),
                error_debug: None,
                error_description: None,
                status_code: None,
        }
    }
}


