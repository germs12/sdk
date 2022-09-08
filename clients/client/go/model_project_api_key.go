/*
Ory APIs

Documentation for all public and administrative Ory APIs. Administrative APIs can only be accessed with a valid Personal Access Token. Public APIs are mostly used in browsers. 

API version: v0.2.0-alpha.36
Contact: support@ory.sh
*/

// Code generated by OpenAPI Generator (https://openapi-generator.tech); DO NOT EDIT.

package client

import (
	"encoding/json"
)

// ProjectApiKey struct for ProjectApiKey
type ProjectApiKey struct {
	// The token's ID.
	Id string `json:"id"`
	// The Token's Name  Set this to help you remember, for example, where you use the token.
	Name string `json:"name"`
	// The token's owner
	OwnerId string `json:"owner_id"`
	// The Token's Project ID
	ProjectId *string `json:"project_id,omitempty"`
	// The token's value
	Value *string `json:"value,omitempty"`
}

// NewProjectApiKey instantiates a new ProjectApiKey object
// This constructor will assign default values to properties that have it defined,
// and makes sure properties required by API are set, but the set of arguments
// will change when the set of required properties is changed
func NewProjectApiKey(id string, name string, ownerId string) *ProjectApiKey {
	this := ProjectApiKey{}
	this.Id = id
	this.Name = name
	this.OwnerId = ownerId
	return &this
}

// NewProjectApiKeyWithDefaults instantiates a new ProjectApiKey object
// This constructor will only assign default values to properties that have it defined,
// but it doesn't guarantee that properties required by API are set
func NewProjectApiKeyWithDefaults() *ProjectApiKey {
	this := ProjectApiKey{}
	return &this
}

// GetId returns the Id field value
func (o *ProjectApiKey) GetId() string {
	if o == nil {
		var ret string
		return ret
	}

	return o.Id
}

// GetIdOk returns a tuple with the Id field value
// and a boolean to check if the value has been set.
func (o *ProjectApiKey) GetIdOk() (*string, bool) {
	if o == nil {
		return nil, false
	}
	return &o.Id, true
}

// SetId sets field value
func (o *ProjectApiKey) SetId(v string) {
	o.Id = v
}

// GetName returns the Name field value
func (o *ProjectApiKey) GetName() string {
	if o == nil {
		var ret string
		return ret
	}

	return o.Name
}

// GetNameOk returns a tuple with the Name field value
// and a boolean to check if the value has been set.
func (o *ProjectApiKey) GetNameOk() (*string, bool) {
	if o == nil {
		return nil, false
	}
	return &o.Name, true
}

// SetName sets field value
func (o *ProjectApiKey) SetName(v string) {
	o.Name = v
}

// GetOwnerId returns the OwnerId field value
func (o *ProjectApiKey) GetOwnerId() string {
	if o == nil {
		var ret string
		return ret
	}

	return o.OwnerId
}

// GetOwnerIdOk returns a tuple with the OwnerId field value
// and a boolean to check if the value has been set.
func (o *ProjectApiKey) GetOwnerIdOk() (*string, bool) {
	if o == nil {
		return nil, false
	}
	return &o.OwnerId, true
}

// SetOwnerId sets field value
func (o *ProjectApiKey) SetOwnerId(v string) {
	o.OwnerId = v
}

// GetProjectId returns the ProjectId field value if set, zero value otherwise.
func (o *ProjectApiKey) GetProjectId() string {
	if o == nil || o.ProjectId == nil {
		var ret string
		return ret
	}
	return *o.ProjectId
}

// GetProjectIdOk returns a tuple with the ProjectId field value if set, nil otherwise
// and a boolean to check if the value has been set.
func (o *ProjectApiKey) GetProjectIdOk() (*string, bool) {
	if o == nil || o.ProjectId == nil {
		return nil, false
	}
	return o.ProjectId, true
}

// HasProjectId returns a boolean if a field has been set.
func (o *ProjectApiKey) HasProjectId() bool {
	if o != nil && o.ProjectId != nil {
		return true
	}

	return false
}

// SetProjectId gets a reference to the given string and assigns it to the ProjectId field.
func (o *ProjectApiKey) SetProjectId(v string) {
	o.ProjectId = &v
}

// GetValue returns the Value field value if set, zero value otherwise.
func (o *ProjectApiKey) GetValue() string {
	if o == nil || o.Value == nil {
		var ret string
		return ret
	}
	return *o.Value
}

// GetValueOk returns a tuple with the Value field value if set, nil otherwise
// and a boolean to check if the value has been set.
func (o *ProjectApiKey) GetValueOk() (*string, bool) {
	if o == nil || o.Value == nil {
		return nil, false
	}
	return o.Value, true
}

// HasValue returns a boolean if a field has been set.
func (o *ProjectApiKey) HasValue() bool {
	if o != nil && o.Value != nil {
		return true
	}

	return false
}

// SetValue gets a reference to the given string and assigns it to the Value field.
func (o *ProjectApiKey) SetValue(v string) {
	o.Value = &v
}

func (o ProjectApiKey) MarshalJSON() ([]byte, error) {
	toSerialize := map[string]interface{}{}
	if true {
		toSerialize["id"] = o.Id
	}
	if true {
		toSerialize["name"] = o.Name
	}
	if true {
		toSerialize["owner_id"] = o.OwnerId
	}
	if o.ProjectId != nil {
		toSerialize["project_id"] = o.ProjectId
	}
	if o.Value != nil {
		toSerialize["value"] = o.Value
	}
	return json.Marshal(toSerialize)
}

type NullableProjectApiKey struct {
	value *ProjectApiKey
	isSet bool
}

func (v NullableProjectApiKey) Get() *ProjectApiKey {
	return v.value
}

func (v *NullableProjectApiKey) Set(val *ProjectApiKey) {
	v.value = val
	v.isSet = true
}

func (v NullableProjectApiKey) IsSet() bool {
	return v.isSet
}

func (v *NullableProjectApiKey) Unset() {
	v.value = nil
	v.isSet = false
}

func NewNullableProjectApiKey(val *ProjectApiKey) *NullableProjectApiKey {
	return &NullableProjectApiKey{value: val, isSet: true}
}

func (v NullableProjectApiKey) MarshalJSON() ([]byte, error) {
	return json.Marshal(v.value)
}

func (v *NullableProjectApiKey) UnmarshalJSON(src []byte) error {
	v.isSet = true
	return json.Unmarshal(src, &v.value)
}


