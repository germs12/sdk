/*
 * Ory Kratos API
 *
 * Documentation for all public and administrative Ory Kratos APIs. Public and administrative APIs are exposed on different ports. Public APIs can face the public internet without any protection while administrative APIs should never be exposed without prior authorization. To protect the administative API port you should use something like Nginx, Ory Oathkeeper, or any other technology capable of authorizing incoming requests. 
 *
 * The version of the OpenAPI document: v0.6.0-alpha.15
 * Contact: hi@ory.sh
 * Generated by: https://openapi-generator.tech
 */




#[derive(Clone, Debug, PartialEq, Serialize, Deserialize)]
pub struct UiNodeAnchorAttributes {
    /// The link's href (destination) URL.  format: uri
    #[serde(rename = "href")]
    pub href: String,
    #[serde(rename = "title")]
    pub title: Box<crate::models::UiText>,
}

impl UiNodeAnchorAttributes {
    pub fn new(href: String, title: crate::models::UiText) -> UiNodeAnchorAttributes {
        UiNodeAnchorAttributes {
            href,
            title: Box::new(title),
        }
    }
}

