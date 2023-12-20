/*
Ory APIs

Documentation for all public and administrative Ory APIs. Administrative APIs can only be accessed with a valid Personal Access Token. Public APIs are mostly used in browsers. 

API version: v1.4.7
Contact: support@ory.sh
*/

// Code generated by OpenAPI Generator (https://openapi-generator.tech); DO NOT EDIT.

package client

import (
	"encoding/json"
	"fmt"
)

// checks if the Project type satisfies the MappedNullable interface at compile time
var _ MappedNullable = &Project{}

// Project struct for Project
type Project struct {
	CorsAdmin *ProjectCors `json:"cors_admin,omitempty"`
	CorsPublic *ProjectCors `json:"cors_public,omitempty"`
	// The project's ID.
	Id string `json:"id"`
	// The name of the project.
	Name string `json:"name"`
	// The configuration revision ID.
	RevisionId string `json:"revision_id"`
	Services ProjectServices `json:"services"`
	// The project's slug
	Slug string `json:"slug"`
	// The state of the project. running Running halted Halted deleted Deleted
	State string `json:"state"`
	WorkspaceId NullableString `json:"workspace_id,omitempty"`
	AdditionalProperties map[string]interface{}
}

type _Project Project

// NewProject instantiates a new Project object
// This constructor will assign default values to properties that have it defined,
// and makes sure properties required by API are set, but the set of arguments
// will change when the set of required properties is changed
func NewProject(id string, name string, revisionId string, services ProjectServices, slug string, state string) *Project {
	this := Project{}
	this.Id = id
	this.Name = name
	this.RevisionId = revisionId
	this.Services = services
	this.Slug = slug
	this.State = state
	return &this
}

// NewProjectWithDefaults instantiates a new Project object
// This constructor will only assign default values to properties that have it defined,
// but it doesn't guarantee that properties required by API are set
func NewProjectWithDefaults() *Project {
	this := Project{}
	return &this
}

// GetCorsAdmin returns the CorsAdmin field value if set, zero value otherwise.
func (o *Project) GetCorsAdmin() ProjectCors {
	if o == nil || IsNil(o.CorsAdmin) {
		var ret ProjectCors
		return ret
	}
	return *o.CorsAdmin
}

// GetCorsAdminOk returns a tuple with the CorsAdmin field value if set, nil otherwise
// and a boolean to check if the value has been set.
func (o *Project) GetCorsAdminOk() (*ProjectCors, bool) {
	if o == nil || IsNil(o.CorsAdmin) {
		return nil, false
	}
	return o.CorsAdmin, true
}

// HasCorsAdmin returns a boolean if a field has been set.
func (o *Project) HasCorsAdmin() bool {
	if o != nil && !IsNil(o.CorsAdmin) {
		return true
	}

	return false
}

// SetCorsAdmin gets a reference to the given ProjectCors and assigns it to the CorsAdmin field.
func (o *Project) SetCorsAdmin(v ProjectCors) {
	o.CorsAdmin = &v
}

// GetCorsPublic returns the CorsPublic field value if set, zero value otherwise.
func (o *Project) GetCorsPublic() ProjectCors {
	if o == nil || IsNil(o.CorsPublic) {
		var ret ProjectCors
		return ret
	}
	return *o.CorsPublic
}

// GetCorsPublicOk returns a tuple with the CorsPublic field value if set, nil otherwise
// and a boolean to check if the value has been set.
func (o *Project) GetCorsPublicOk() (*ProjectCors, bool) {
	if o == nil || IsNil(o.CorsPublic) {
		return nil, false
	}
	return o.CorsPublic, true
}

// HasCorsPublic returns a boolean if a field has been set.
func (o *Project) HasCorsPublic() bool {
	if o != nil && !IsNil(o.CorsPublic) {
		return true
	}

	return false
}

// SetCorsPublic gets a reference to the given ProjectCors and assigns it to the CorsPublic field.
func (o *Project) SetCorsPublic(v ProjectCors) {
	o.CorsPublic = &v
}

// GetId returns the Id field value
func (o *Project) GetId() string {
	if o == nil {
		var ret string
		return ret
	}

	return o.Id
}

// GetIdOk returns a tuple with the Id field value
// and a boolean to check if the value has been set.
func (o *Project) GetIdOk() (*string, bool) {
	if o == nil {
		return nil, false
	}
	return &o.Id, true
}

// SetId sets field value
func (o *Project) SetId(v string) {
	o.Id = v
}

// GetName returns the Name field value
func (o *Project) GetName() string {
	if o == nil {
		var ret string
		return ret
	}

	return o.Name
}

// GetNameOk returns a tuple with the Name field value
// and a boolean to check if the value has been set.
func (o *Project) GetNameOk() (*string, bool) {
	if o == nil {
		return nil, false
	}
	return &o.Name, true
}

// SetName sets field value
func (o *Project) SetName(v string) {
	o.Name = v
}

// GetRevisionId returns the RevisionId field value
func (o *Project) GetRevisionId() string {
	if o == nil {
		var ret string
		return ret
	}

	return o.RevisionId
}

// GetRevisionIdOk returns a tuple with the RevisionId field value
// and a boolean to check if the value has been set.
func (o *Project) GetRevisionIdOk() (*string, bool) {
	if o == nil {
		return nil, false
	}
	return &o.RevisionId, true
}

// SetRevisionId sets field value
func (o *Project) SetRevisionId(v string) {
	o.RevisionId = v
}

// GetServices returns the Services field value
func (o *Project) GetServices() ProjectServices {
	if o == nil {
		var ret ProjectServices
		return ret
	}

	return o.Services
}

// GetServicesOk returns a tuple with the Services field value
// and a boolean to check if the value has been set.
func (o *Project) GetServicesOk() (*ProjectServices, bool) {
	if o == nil {
		return nil, false
	}
	return &o.Services, true
}

// SetServices sets field value
func (o *Project) SetServices(v ProjectServices) {
	o.Services = v
}

// GetSlug returns the Slug field value
func (o *Project) GetSlug() string {
	if o == nil {
		var ret string
		return ret
	}

	return o.Slug
}

// GetSlugOk returns a tuple with the Slug field value
// and a boolean to check if the value has been set.
func (o *Project) GetSlugOk() (*string, bool) {
	if o == nil {
		return nil, false
	}
	return &o.Slug, true
}

// SetSlug sets field value
func (o *Project) SetSlug(v string) {
	o.Slug = v
}

// GetState returns the State field value
func (o *Project) GetState() string {
	if o == nil {
		var ret string
		return ret
	}

	return o.State
}

// GetStateOk returns a tuple with the State field value
// and a boolean to check if the value has been set.
func (o *Project) GetStateOk() (*string, bool) {
	if o == nil {
		return nil, false
	}
	return &o.State, true
}

// SetState sets field value
func (o *Project) SetState(v string) {
	o.State = v
}

// GetWorkspaceId returns the WorkspaceId field value if set, zero value otherwise (both if not set or set to explicit null).
func (o *Project) GetWorkspaceId() string {
	if o == nil || IsNil(o.WorkspaceId.Get()) {
		var ret string
		return ret
	}
	return *o.WorkspaceId.Get()
}

// GetWorkspaceIdOk returns a tuple with the WorkspaceId field value if set, nil otherwise
// and a boolean to check if the value has been set.
// NOTE: If the value is an explicit nil, `nil, true` will be returned
func (o *Project) GetWorkspaceIdOk() (*string, bool) {
	if o == nil {
		return nil, false
	}
	return o.WorkspaceId.Get(), o.WorkspaceId.IsSet()
}

// HasWorkspaceId returns a boolean if a field has been set.
func (o *Project) HasWorkspaceId() bool {
	if o != nil && o.WorkspaceId.IsSet() {
		return true
	}

	return false
}

// SetWorkspaceId gets a reference to the given NullableString and assigns it to the WorkspaceId field.
func (o *Project) SetWorkspaceId(v string) {
	o.WorkspaceId.Set(&v)
}
// SetWorkspaceIdNil sets the value for WorkspaceId to be an explicit nil
func (o *Project) SetWorkspaceIdNil() {
	o.WorkspaceId.Set(nil)
}

// UnsetWorkspaceId ensures that no value is present for WorkspaceId, not even an explicit nil
func (o *Project) UnsetWorkspaceId() {
	o.WorkspaceId.Unset()
}

func (o Project) MarshalJSON() ([]byte, error) {
	toSerialize,err := o.ToMap()
	if err != nil {
		return []byte{}, err
	}
	return json.Marshal(toSerialize)
}

func (o Project) ToMap() (map[string]interface{}, error) {
	toSerialize := map[string]interface{}{}
	if !IsNil(o.CorsAdmin) {
		toSerialize["cors_admin"] = o.CorsAdmin
	}
	if !IsNil(o.CorsPublic) {
		toSerialize["cors_public"] = o.CorsPublic
	}
	toSerialize["id"] = o.Id
	toSerialize["name"] = o.Name
	toSerialize["revision_id"] = o.RevisionId
	toSerialize["services"] = o.Services
	toSerialize["slug"] = o.Slug
	toSerialize["state"] = o.State
	if o.WorkspaceId.IsSet() {
		toSerialize["workspace_id"] = o.WorkspaceId.Get()
	}

	for key, value := range o.AdditionalProperties {
		toSerialize[key] = value
	}

	return toSerialize, nil
}

func (o *Project) UnmarshalJSON(bytes []byte) (err error) {
    // This validates that all required properties are included in the JSON object
	// by unmarshalling the object into a generic map with string keys and checking
	// that every required field exists as a key in the generic map.
	requiredProperties := []string{
		"id",
		"name",
		"revision_id",
		"services",
		"slug",
		"state",
	}

	allProperties := make(map[string]interface{})

	err = json.Unmarshal(bytes, &allProperties)

	if err != nil {
		return err;
	}

	for _, requiredProperty := range(requiredProperties) {
		if _, exists := allProperties[requiredProperty]; !exists {
			return fmt.Errorf("no value given for required property %v", requiredProperty)
		}
	}

	varProject := _Project{}

	err = json.Unmarshal(bytes, &varProject)

	if err != nil {
		return err
	}

	*o = Project(varProject)

	additionalProperties := make(map[string]interface{})

	if err = json.Unmarshal(bytes, &additionalProperties); err == nil {
		delete(additionalProperties, "cors_admin")
		delete(additionalProperties, "cors_public")
		delete(additionalProperties, "id")
		delete(additionalProperties, "name")
		delete(additionalProperties, "revision_id")
		delete(additionalProperties, "services")
		delete(additionalProperties, "slug")
		delete(additionalProperties, "state")
		delete(additionalProperties, "workspace_id")
		o.AdditionalProperties = additionalProperties
	}

	return err
}

type NullableProject struct {
	value *Project
	isSet bool
}

func (v NullableProject) Get() *Project {
	return v.value
}

func (v *NullableProject) Set(val *Project) {
	v.value = val
	v.isSet = true
}

func (v NullableProject) IsSet() bool {
	return v.isSet
}

func (v *NullableProject) Unset() {
	v.value = nil
	v.isSet = false
}

func NewNullableProject(val *Project) *NullableProject {
	return &NullableProject{value: val, isSet: true}
}

func (v NullableProject) MarshalJSON() ([]byte, error) {
	return json.Marshal(v.value)
}

func (v *NullableProject) UnmarshalJSON(src []byte) error {
	v.isSet = true
	return json.Unmarshal(src, &v.value)
}


