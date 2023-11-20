/*
 * Ory APIs
 *
 * Documentation for all public and administrative Ory APIs. Administrative APIs can only be accessed with a valid Personal Access Token. Public APIs are mostly used in browsers. 
 *
 * The version of the OpenAPI document: v1.4.2
 * Contact: support@ory.sh
 * Generated by: https://openapi-generator.tech
 */




#[derive(Clone, Debug, PartialEq, Serialize, Deserialize)]
pub struct Message {
    #[serde(rename = "body")]
    pub body: String,
    /// CreatedAt is a helper struct field for gobuffalo.pop.
    #[serde(rename = "created_at")]
    pub created_at: String,
    /// Dispatches store information about the attempts of delivering a message May contain an error if any happened, or just the `success` state.
    #[serde(rename = "dispatches", skip_serializing_if = "Option::is_none")]
    pub dispatches: Option<Vec<crate::models::MessageDispatch>>,
    #[serde(rename = "id")]
    pub id: String,
    #[serde(rename = "recipient")]
    pub recipient: String,
    #[serde(rename = "send_count")]
    pub send_count: i64,
    #[serde(rename = "status")]
    pub status: crate::models::CourierMessageStatus,
    #[serde(rename = "subject")]
    pub subject: String,
    ///  recovery_invalid TypeRecoveryInvalid recovery_valid TypeRecoveryValid recovery_code_invalid TypeRecoveryCodeInvalid recovery_code_valid TypeRecoveryCodeValid verification_invalid TypeVerificationInvalid verification_valid TypeVerificationValid verification_code_invalid TypeVerificationCodeInvalid verification_code_valid TypeVerificationCodeValid otp TypeOTP stub TypeTestStub login_code_valid TypeLoginCodeValid registration_code_valid TypeRegistrationCodeValid
    #[serde(rename = "template_type")]
    pub template_type: TemplateTypeEnum,
    #[serde(rename = "type")]
    pub _type: crate::models::CourierMessageType,
    /// UpdatedAt is a helper struct field for gobuffalo.pop.
    #[serde(rename = "updated_at")]
    pub updated_at: String,
}


impl Message {
    pub fn new(body: String, created_at: String, id: String, recipient: String, send_count: i64, status: crate::models::CourierMessageStatus, subject: String, template_type: TemplateTypeEnum, _type: crate::models::CourierMessageType, updated_at: String) -> Message {
        Message {
                body,
                created_at,
                dispatches: None,
                id,
                recipient,
                send_count,
                status,
                subject,
                template_type,
                _type,
                updated_at,
        }
    }
}

///  recovery_invalid TypeRecoveryInvalid recovery_valid TypeRecoveryValid recovery_code_invalid TypeRecoveryCodeInvalid recovery_code_valid TypeRecoveryCodeValid verification_invalid TypeVerificationInvalid verification_valid TypeVerificationValid verification_code_invalid TypeVerificationCodeInvalid verification_code_valid TypeVerificationCodeValid otp TypeOTP stub TypeTestStub login_code_valid TypeLoginCodeValid registration_code_valid TypeRegistrationCodeValid
#[derive(Clone, Copy, Debug, Eq, PartialEq, Ord, PartialOrd, Hash, Serialize, Deserialize)]
pub enum TemplateTypeEnum {
    #[serde(rename = "recovery_invalid")]
    RecoveryInvalid,
    #[serde(rename = "recovery_valid")]
    RecoveryValid,
    #[serde(rename = "recovery_code_invalid")]
    RecoveryCodeInvalid,
    #[serde(rename = "recovery_code_valid")]
    RecoveryCodeValid,
    #[serde(rename = "verification_invalid")]
    VerificationInvalid,
    #[serde(rename = "verification_valid")]
    VerificationValid,
    #[serde(rename = "verification_code_invalid")]
    VerificationCodeInvalid,
    #[serde(rename = "verification_code_valid")]
    VerificationCodeValid,
    #[serde(rename = "otp")]
    Otp,
    #[serde(rename = "stub")]
    Stub,
    #[serde(rename = "login_code_valid")]
    LoginCodeValid,
    #[serde(rename = "registration_code_valid")]
    RegistrationCodeValid,
}

