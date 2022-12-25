/*
Ory APIs

Documentation for all public and administrative Ory APIs. Administrative APIs can only be accessed with a valid Personal Access Token. Public APIs are mostly used in browsers. 

API version: v1.1.4
Contact: support@ory.sh
*/

// Code generated by OpenAPI Generator (https://openapi-generator.tech); DO NOT EDIT.

package client

import (
	"encoding/json"
)

// CustomDomainQuota Custom Domain Quota
type CustomDomainQuota struct {
	AvailableDomains *int64 `json:"available_domains,omitempty"`
	CanUse *bool `json:"can_use,omitempty"`
	UsedDomains *int64 `json:"used_domains,omitempty"`
}

// NewCustomDomainQuota instantiates a new CustomDomainQuota object
// This constructor will assign default values to properties that have it defined,
// and makes sure properties required by API are set, but the set of arguments
// will change when the set of required properties is changed
func NewCustomDomainQuota() *CustomDomainQuota {
	this := CustomDomainQuota{}
	return &this
}

// NewCustomDomainQuotaWithDefaults instantiates a new CustomDomainQuota object
// This constructor will only assign default values to properties that have it defined,
// but it doesn't guarantee that properties required by API are set
func NewCustomDomainQuotaWithDefaults() *CustomDomainQuota {
	this := CustomDomainQuota{}
	return &this
}

// GetAvailableDomains returns the AvailableDomains field value if set, zero value otherwise.
func (o *CustomDomainQuota) GetAvailableDomains() int64 {
	if o == nil || o.AvailableDomains == nil {
		var ret int64
		return ret
	}
	return *o.AvailableDomains
}

// GetAvailableDomainsOk returns a tuple with the AvailableDomains field value if set, nil otherwise
// and a boolean to check if the value has been set.
func (o *CustomDomainQuota) GetAvailableDomainsOk() (*int64, bool) {
	if o == nil || o.AvailableDomains == nil {
		return nil, false
	}
	return o.AvailableDomains, true
}

// HasAvailableDomains returns a boolean if a field has been set.
func (o *CustomDomainQuota) HasAvailableDomains() bool {
	if o != nil && o.AvailableDomains != nil {
		return true
	}

	return false
}

// SetAvailableDomains gets a reference to the given int64 and assigns it to the AvailableDomains field.
func (o *CustomDomainQuota) SetAvailableDomains(v int64) {
	o.AvailableDomains = &v
}

// GetCanUse returns the CanUse field value if set, zero value otherwise.
func (o *CustomDomainQuota) GetCanUse() bool {
	if o == nil || o.CanUse == nil {
		var ret bool
		return ret
	}
	return *o.CanUse
}

// GetCanUseOk returns a tuple with the CanUse field value if set, nil otherwise
// and a boolean to check if the value has been set.
func (o *CustomDomainQuota) GetCanUseOk() (*bool, bool) {
	if o == nil || o.CanUse == nil {
		return nil, false
	}
	return o.CanUse, true
}

// HasCanUse returns a boolean if a field has been set.
func (o *CustomDomainQuota) HasCanUse() bool {
	if o != nil && o.CanUse != nil {
		return true
	}

	return false
}

// SetCanUse gets a reference to the given bool and assigns it to the CanUse field.
func (o *CustomDomainQuota) SetCanUse(v bool) {
	o.CanUse = &v
}

// GetUsedDomains returns the UsedDomains field value if set, zero value otherwise.
func (o *CustomDomainQuota) GetUsedDomains() int64 {
	if o == nil || o.UsedDomains == nil {
		var ret int64
		return ret
	}
	return *o.UsedDomains
}

// GetUsedDomainsOk returns a tuple with the UsedDomains field value if set, nil otherwise
// and a boolean to check if the value has been set.
func (o *CustomDomainQuota) GetUsedDomainsOk() (*int64, bool) {
	if o == nil || o.UsedDomains == nil {
		return nil, false
	}
	return o.UsedDomains, true
}

// HasUsedDomains returns a boolean if a field has been set.
func (o *CustomDomainQuota) HasUsedDomains() bool {
	if o != nil && o.UsedDomains != nil {
		return true
	}

	return false
}

// SetUsedDomains gets a reference to the given int64 and assigns it to the UsedDomains field.
func (o *CustomDomainQuota) SetUsedDomains(v int64) {
	o.UsedDomains = &v
}

func (o CustomDomainQuota) MarshalJSON() ([]byte, error) {
	toSerialize := map[string]interface{}{}
	if o.AvailableDomains != nil {
		toSerialize["available_domains"] = o.AvailableDomains
	}
	if o.CanUse != nil {
		toSerialize["can_use"] = o.CanUse
	}
	if o.UsedDomains != nil {
		toSerialize["used_domains"] = o.UsedDomains
	}
	return json.Marshal(toSerialize)
}

type NullableCustomDomainQuota struct {
	value *CustomDomainQuota
	isSet bool
}

func (v NullableCustomDomainQuota) Get() *CustomDomainQuota {
	return v.value
}

func (v *NullableCustomDomainQuota) Set(val *CustomDomainQuota) {
	v.value = val
	v.isSet = true
}

func (v NullableCustomDomainQuota) IsSet() bool {
	return v.isSet
}

func (v *NullableCustomDomainQuota) Unset() {
	v.value = nil
	v.isSet = false
}

func NewNullableCustomDomainQuota(val *CustomDomainQuota) *NullableCustomDomainQuota {
	return &NullableCustomDomainQuota{value: val, isSet: true}
}

func (v NullableCustomDomainQuota) MarshalJSON() ([]byte, error) {
	return json.Marshal(v.value)
}

func (v *NullableCustomDomainQuota) UnmarshalJSON(src []byte) error {
	v.isSet = true
	return json.Unmarshal(src, &v.value)
}


