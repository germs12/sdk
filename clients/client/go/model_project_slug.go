/*
 * Ory APIs
 *
 * Documentation for all public and administrative Ory APIs. Administrative APIs can only be accessed with a valid Personal Access Token. Public APIs are mostly used in browsers. 
 *
 * API version: v0.0.1-alpha.79
 * Contact: support@ory.sh
 */

// Code generated by OpenAPI Generator (https://openapi-generator.tech); DO NOT EDIT.

package client

import (
	"encoding/json"
)

// ProjectSlug struct for ProjectSlug
type ProjectSlug struct {
	// The Project Slug
	Slug *string `json:"slug,omitempty"`
}

// NewProjectSlug instantiates a new ProjectSlug object
// This constructor will assign default values to properties that have it defined,
// and makes sure properties required by API are set, but the set of arguments
// will change when the set of required properties is changed
func NewProjectSlug() *ProjectSlug {
	this := ProjectSlug{}
	return &this
}

// NewProjectSlugWithDefaults instantiates a new ProjectSlug object
// This constructor will only assign default values to properties that have it defined,
// but it doesn't guarantee that properties required by API are set
func NewProjectSlugWithDefaults() *ProjectSlug {
	this := ProjectSlug{}
	return &this
}

// GetSlug returns the Slug field value if set, zero value otherwise.
func (o *ProjectSlug) GetSlug() string {
	if o == nil || o.Slug == nil {
		var ret string
		return ret
	}
	return *o.Slug
}

// GetSlugOk returns a tuple with the Slug field value if set, nil otherwise
// and a boolean to check if the value has been set.
func (o *ProjectSlug) GetSlugOk() (*string, bool) {
	if o == nil || o.Slug == nil {
		return nil, false
	}
	return o.Slug, true
}

// HasSlug returns a boolean if a field has been set.
func (o *ProjectSlug) HasSlug() bool {
	if o != nil && o.Slug != nil {
		return true
	}

	return false
}

// SetSlug gets a reference to the given string and assigns it to the Slug field.
func (o *ProjectSlug) SetSlug(v string) {
	o.Slug = &v
}

func (o ProjectSlug) MarshalJSON() ([]byte, error) {
	toSerialize := map[string]interface{}{}
	if o.Slug != nil {
		toSerialize["slug"] = o.Slug
	}
	return json.Marshal(toSerialize)
}

type NullableProjectSlug struct {
	value *ProjectSlug
	isSet bool
}

func (v NullableProjectSlug) Get() *ProjectSlug {
	return v.value
}

func (v *NullableProjectSlug) Set(val *ProjectSlug) {
	v.value = val
	v.isSet = true
}

func (v NullableProjectSlug) IsSet() bool {
	return v.isSet
}

func (v *NullableProjectSlug) Unset() {
	v.value = nil
	v.isSet = false
}

func NewNullableProjectSlug(val *ProjectSlug) *NullableProjectSlug {
	return &NullableProjectSlug{value: val, isSet: true}
}

func (v NullableProjectSlug) MarshalJSON() ([]byte, error) {
	return json.Marshal(v.value)
}

func (v *NullableProjectSlug) UnmarshalJSON(src []byte) error {
	v.isSet = true
	return json.Unmarshal(src, &v.value)
}


