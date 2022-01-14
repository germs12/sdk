/*
 * Ory APIs
 *
 * Documentation for all public and administrative Ory APIs. Administrative APIs can only be accessed with a valid Personal Access Token. Public APIs are mostly used in browsers. 
 *
 * API version: v0.0.1-alpha.45
 * Contact: support@ory.sh
 */

// Code generated by OpenAPI Generator (https://openapi-generator.tech); DO NOT EDIT.

package client

import (
	"encoding/json"
	"fmt"
)

// IdentityCredentialsType and so on.
type IdentityCredentialsType string

// List of identityCredentialsType
const (
	IDENTITYCREDENTIALSTYPE_PASSWORD IdentityCredentialsType = "password"
	IDENTITYCREDENTIALSTYPE_TOTP IdentityCredentialsType = "totp"
	IDENTITYCREDENTIALSTYPE_OIDC IdentityCredentialsType = "oidc"
)

var allowedIdentityCredentialsTypeEnumValues = []IdentityCredentialsType{
	"password",
	"totp",
	"oidc",
}

func (v *IdentityCredentialsType) UnmarshalJSON(src []byte) error {
	var value string
	err := json.Unmarshal(src, &value)
	if err != nil {
		return err
	}
	enumTypeValue := IdentityCredentialsType(value)
	for _, existing := range allowedIdentityCredentialsTypeEnumValues {
		if existing == enumTypeValue {
			*v = enumTypeValue
			return nil
		}
	}

	return fmt.Errorf("%+v is not a valid IdentityCredentialsType", value)
}

// NewIdentityCredentialsTypeFromValue returns a pointer to a valid IdentityCredentialsType
// for the value passed as argument, or an error if the value passed is not allowed by the enum
func NewIdentityCredentialsTypeFromValue(v string) (*IdentityCredentialsType, error) {
	ev := IdentityCredentialsType(v)
	if ev.IsValid() {
		return &ev, nil
	} else {
		return nil, fmt.Errorf("invalid value '%v' for IdentityCredentialsType: valid values are %v", v, allowedIdentityCredentialsTypeEnumValues)
	}
}

// IsValid return true if the value is valid for the enum, false otherwise
func (v IdentityCredentialsType) IsValid() bool {
	for _, existing := range allowedIdentityCredentialsTypeEnumValues {
		if existing == v {
			return true
		}
	}
	return false
}

// Ptr returns reference to identityCredentialsType value
func (v IdentityCredentialsType) Ptr() *IdentityCredentialsType {
	return &v
}

type NullableIdentityCredentialsType struct {
	value *IdentityCredentialsType
	isSet bool
}

func (v NullableIdentityCredentialsType) Get() *IdentityCredentialsType {
	return v.value
}

func (v *NullableIdentityCredentialsType) Set(val *IdentityCredentialsType) {
	v.value = val
	v.isSet = true
}

func (v NullableIdentityCredentialsType) IsSet() bool {
	return v.isSet
}

func (v *NullableIdentityCredentialsType) Unset() {
	v.value = nil
	v.isSet = false
}

func NewNullableIdentityCredentialsType(val *IdentityCredentialsType) *NullableIdentityCredentialsType {
	return &NullableIdentityCredentialsType{value: val, isSet: true}
}

func (v NullableIdentityCredentialsType) MarshalJSON() ([]byte, error) {
	return json.Marshal(v.value)
}

func (v *NullableIdentityCredentialsType) UnmarshalJSON(src []byte) error {
	v.isSet = true
	return json.Unmarshal(src, &v.value)
}

