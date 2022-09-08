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
pub struct CreateCustomHostnameBody {
    /// The domain where cookies will be set. Has to be a parent domain of the custom hostname to work.
    #[serde(rename = "cookie_domain", skip_serializing_if = "Option::is_none")]
    pub cookie_domain: Option<String>,
    /// CORS Allowed origins for the custom hostname.
    #[serde(rename = "cors_allowed_origins", skip_serializing_if = "Option::is_none")]
    pub cors_allowed_origins: Option<Vec<String>>,
    /// CORS Enabled for the custom hostname.
    #[serde(rename = "cors_enabled", skip_serializing_if = "Option::is_none")]
    pub cors_enabled: Option<bool>,
    /// The custom hostname where the API will be exposed.
    #[serde(rename = "hostname", skip_serializing_if = "Option::is_none")]
    pub hostname: Option<String>,
}

impl Default for CreateCustomHostnameBody {
    fn default() -> Self {
        Self::new()
    }
}

impl CreateCustomHostnameBody {
    pub fn new() -> CreateCustomHostnameBody {
        CreateCustomHostnameBody {
                cookie_domain: None,
                cors_allowed_origins: None,
                cors_enabled: None,
                hostname: None,
        }
    }
}


