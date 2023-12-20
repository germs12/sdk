/*
 * Ory APIs
 *
 * Documentation for all public and administrative Ory APIs. Administrative APIs can only be accessed with a valid Personal Access Token. Public APIs are mostly used in browsers. 
 *
 * The version of the OpenAPI document: v1.4.7
 * Contact: support@ory.sh
 * Generated by: https://openapi-generator.tech
 */




#[derive(Clone, Debug, PartialEq, Serialize, Deserialize)]
pub struct AcceptOAuth2ConsentRequest {
    #[serde(rename = "grant_access_token_audience", skip_serializing_if = "Option::is_none")]
    pub grant_access_token_audience: Option<Vec<String>>,
    #[serde(rename = "grant_scope", skip_serializing_if = "Option::is_none")]
    pub grant_scope: Option<Vec<String>>,
    #[serde(rename = "handled_at", skip_serializing_if = "Option::is_none")]
    pub handled_at: Option<String>,
    /// Remember, if set to true, tells ORY Hydra to remember this consent authorization and reuse it if the same client asks the same user for the same, or a subset of, scope.
    #[serde(rename = "remember", skip_serializing_if = "Option::is_none")]
    pub remember: Option<bool>,
    /// RememberFor sets how long the consent authorization should be remembered for in seconds. If set to `0`, the authorization will be remembered indefinitely.
    #[serde(rename = "remember_for", skip_serializing_if = "Option::is_none")]
    pub remember_for: Option<i64>,
    #[serde(rename = "session", skip_serializing_if = "Option::is_none")]
    pub session: Option<Box<crate::models::AcceptOAuth2ConsentRequestSession>>,
}

impl Default for AcceptOAuth2ConsentRequest {
    fn default() -> Self {
        Self::new()
    }
}

impl AcceptOAuth2ConsentRequest {
    pub fn new() -> AcceptOAuth2ConsentRequest {
        AcceptOAuth2ConsentRequest {
                grant_access_token_audience: None,
                grant_scope: None,
                handled_at: None,
                remember: None,
                remember_for: None,
                session: None,
        }
    }
}


