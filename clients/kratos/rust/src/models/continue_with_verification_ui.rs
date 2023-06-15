/*
 * Ory Identities API
 *
 * This is the API specification for Ory Identities with features such as registration, login, recovery, account verification, profile settings, password reset, identity management, session management, email and sms delivery, and more. 
 *
 * The version of the OpenAPI document: v0.13.1
 * Contact: office@ory.sh
 * Generated by: https://openapi-generator.tech
 */

/// ContinueWithVerificationUi : Indicates, that the UI flow could be continued by showing a verification ui



#[derive(Clone, Debug, PartialEq, Serialize, Deserialize)]
pub struct ContinueWithVerificationUi {
    /// Action will always be `show_verification_ui` set_ory_session_token ContinueWithActionSetOrySessionToken show_verification_ui ContinueWithActionShowVerificationUI
    #[serde(rename = "action")]
    pub action: ActionEnum,
    #[serde(rename = "flow")]
    pub flow: Box<crate::models::ContinueWithVerificationUiFlow>,
}


impl ContinueWithVerificationUi {
    /// Indicates, that the UI flow could be continued by showing a verification ui
    pub fn new(action: ActionEnum, flow: crate::models::ContinueWithVerificationUiFlow) -> ContinueWithVerificationUi {
        ContinueWithVerificationUi {
                action,
                flow: Box::new(flow),
        }
    }
}

/// Action will always be `show_verification_ui` set_ory_session_token ContinueWithActionSetOrySessionToken show_verification_ui ContinueWithActionShowVerificationUI
#[derive(Clone, Copy, Debug, Eq, PartialEq, Ord, PartialOrd, Hash, Serialize, Deserialize)]
pub enum ActionEnum {
    #[serde(rename = "set_ory_session_token")]
    SetOrySessionToken,
    #[serde(rename = "show_verification_ui")]
    ShowVerificationUi,
}
