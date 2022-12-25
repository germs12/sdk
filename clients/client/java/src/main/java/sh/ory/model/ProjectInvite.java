/*
 * Ory APIs
 * Documentation for all public and administrative Ory APIs. Administrative APIs can only be accessed with a valid Personal Access Token. Public APIs are mostly used in browsers. 
 *
 * The version of the OpenAPI document: v1.1.4
 * Contact: support@ory.sh
 *
 * NOTE: This class is auto generated by OpenAPI Generator (https://openapi-generator.tech).
 * https://openapi-generator.tech
 * Do not edit the class manually.
 */


package sh.ory.model;

import java.util.Objects;
import java.util.Arrays;
import com.google.gson.TypeAdapter;
import com.google.gson.annotations.JsonAdapter;
import com.google.gson.annotations.SerializedName;
import com.google.gson.stream.JsonReader;
import com.google.gson.stream.JsonWriter;
import io.swagger.annotations.ApiModel;
import io.swagger.annotations.ApiModelProperty;
import java.io.IOException;
import java.time.OffsetDateTime;
import org.openapitools.jackson.nullable.JsonNullable;

import com.google.gson.Gson;
import com.google.gson.GsonBuilder;
import com.google.gson.JsonArray;
import com.google.gson.JsonDeserializationContext;
import com.google.gson.JsonDeserializer;
import com.google.gson.JsonElement;
import com.google.gson.JsonObject;
import com.google.gson.JsonParseException;
import com.google.gson.TypeAdapterFactory;
import com.google.gson.reflect.TypeToken;

import java.lang.reflect.Type;
import java.util.HashMap;
import java.util.HashSet;
import java.util.List;
import java.util.Map;
import java.util.Map.Entry;
import java.util.Set;

import sh.ory.JSON;

/**
 * ProjectInvite
 */
@javax.annotation.Generated(value = "org.openapitools.codegen.languages.JavaClientCodegen", date = "2022-12-25T13:32:36.626616586Z[Etc/UTC]")
public class ProjectInvite {
  public static final String SERIALIZED_NAME_CREATED_AT = "created_at";
  @SerializedName(SERIALIZED_NAME_CREATED_AT)
  private OffsetDateTime createdAt;

  public static final String SERIALIZED_NAME_ID = "id";
  @SerializedName(SERIALIZED_NAME_ID)
  private String id;

  public static final String SERIALIZED_NAME_INVITEE_EMAIL = "invitee_email";
  @SerializedName(SERIALIZED_NAME_INVITEE_EMAIL)
  private String inviteeEmail;

  public static final String SERIALIZED_NAME_INVITEE_ID = "invitee_id";
  @SerializedName(SERIALIZED_NAME_INVITEE_ID)
  private String inviteeId;

  public static final String SERIALIZED_NAME_OWNER_EMAIL = "owner_email";
  @SerializedName(SERIALIZED_NAME_OWNER_EMAIL)
  private String ownerEmail;

  public static final String SERIALIZED_NAME_OWNER_ID = "owner_id";
  @SerializedName(SERIALIZED_NAME_OWNER_ID)
  private String ownerId;

  public static final String SERIALIZED_NAME_PROJECT_ID = "project_id";
  @SerializedName(SERIALIZED_NAME_PROJECT_ID)
  private String projectId;

  /**
   * The invite&#39;s status Keeps track of the invites status such as pending, accepted, declined, expired pending PENDING accepted ACCEPTED declined DECLINED expired EXPIRED cancelled CANCELLED removed REMOVED
   */
  @JsonAdapter(StatusEnum.Adapter.class)
  public enum StatusEnum {
    PENDING("pending"),
    
    ACCEPTED("accepted"),
    
    DECLINED("declined"),
    
    EXPIRED("expired"),
    
    CANCELLED("cancelled"),
    
    REMOVED("removed");

    private String value;

    StatusEnum(String value) {
      this.value = value;
    }

    public String getValue() {
      return value;
    }

    @Override
    public String toString() {
      return String.valueOf(value);
    }

    public static StatusEnum fromValue(String value) {
      for (StatusEnum b : StatusEnum.values()) {
        if (b.value.equals(value)) {
          return b;
        }
      }
      throw new IllegalArgumentException("Unexpected value '" + value + "'");
    }

    public static class Adapter extends TypeAdapter<StatusEnum> {
      @Override
      public void write(final JsonWriter jsonWriter, final StatusEnum enumeration) throws IOException {
        jsonWriter.value(enumeration.getValue());
      }

      @Override
      public StatusEnum read(final JsonReader jsonReader) throws IOException {
        String value =  jsonReader.nextString();
        return StatusEnum.fromValue(value);
      }
    }
  }

  public static final String SERIALIZED_NAME_STATUS = "status";
  @SerializedName(SERIALIZED_NAME_STATUS)
  private StatusEnum status;

  public static final String SERIALIZED_NAME_UPDATED_AT = "updated_at";
  @SerializedName(SERIALIZED_NAME_UPDATED_AT)
  private OffsetDateTime updatedAt;

  public ProjectInvite() {
  }

  
  public ProjectInvite(
     OffsetDateTime createdAt, 
     String id, 
     OffsetDateTime updatedAt
  ) {
    this();
    this.createdAt = createdAt;
    this.id = id;
    this.updatedAt = updatedAt;
  }

   /**
   * The Project&#39;s Revision Creation Date
   * @return createdAt
  **/
  @javax.annotation.Nonnull
  @ApiModelProperty(required = true, value = "The Project's Revision Creation Date")

  public OffsetDateTime getCreatedAt() {
    return createdAt;
  }




   /**
   * The invite&#39;s ID.
   * @return id
  **/
  @javax.annotation.Nonnull
  @ApiModelProperty(required = true, value = "The invite's ID.")

  public String getId() {
    return id;
  }




  public ProjectInvite inviteeEmail(String inviteeEmail) {
    
    this.inviteeEmail = inviteeEmail;
    return this;
  }

   /**
   * The invitee&#39;s email
   * @return inviteeEmail
  **/
  @javax.annotation.Nonnull
  @ApiModelProperty(required = true, value = "The invitee's email")

  public String getInviteeEmail() {
    return inviteeEmail;
  }


  public void setInviteeEmail(String inviteeEmail) {
    this.inviteeEmail = inviteeEmail;
  }


  public ProjectInvite inviteeId(String inviteeId) {
    
    this.inviteeId = inviteeId;
    return this;
  }

   /**
   * Get inviteeId
   * @return inviteeId
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public String getInviteeId() {
    return inviteeId;
  }


  public void setInviteeId(String inviteeId) {
    this.inviteeId = inviteeId;
  }


  public ProjectInvite ownerEmail(String ownerEmail) {
    
    this.ownerEmail = ownerEmail;
    return this;
  }

   /**
   * The invite owner&#39;s email Usually the project&#39;s owner email
   * @return ownerEmail
  **/
  @javax.annotation.Nonnull
  @ApiModelProperty(required = true, value = "The invite owner's email Usually the project's owner email")

  public String getOwnerEmail() {
    return ownerEmail;
  }


  public void setOwnerEmail(String ownerEmail) {
    this.ownerEmail = ownerEmail;
  }


  public ProjectInvite ownerId(String ownerId) {
    
    this.ownerId = ownerId;
    return this;
  }

   /**
   * The invite owner&#39;s ID Usually the project&#39;s owner
   * @return ownerId
  **/
  @javax.annotation.Nonnull
  @ApiModelProperty(required = true, value = "The invite owner's ID Usually the project's owner")

  public String getOwnerId() {
    return ownerId;
  }


  public void setOwnerId(String ownerId) {
    this.ownerId = ownerId;
  }


  public ProjectInvite projectId(String projectId) {
    
    this.projectId = projectId;
    return this;
  }

   /**
   * The Project&#39;s ID this invite is associated with
   * @return projectId
  **/
  @javax.annotation.Nonnull
  @ApiModelProperty(required = true, value = "The Project's ID this invite is associated with")

  public String getProjectId() {
    return projectId;
  }


  public void setProjectId(String projectId) {
    this.projectId = projectId;
  }


  public ProjectInvite status(StatusEnum status) {
    
    this.status = status;
    return this;
  }

   /**
   * The invite&#39;s status Keeps track of the invites status such as pending, accepted, declined, expired pending PENDING accepted ACCEPTED declined DECLINED expired EXPIRED cancelled CANCELLED removed REMOVED
   * @return status
  **/
  @javax.annotation.Nonnull
  @ApiModelProperty(required = true, value = "The invite's status Keeps track of the invites status such as pending, accepted, declined, expired pending PENDING accepted ACCEPTED declined DECLINED expired EXPIRED cancelled CANCELLED removed REMOVED")

  public StatusEnum getStatus() {
    return status;
  }


  public void setStatus(StatusEnum status) {
    this.status = status;
  }


   /**
   * Last Time Project&#39;s Revision was Updated
   * @return updatedAt
  **/
  @javax.annotation.Nonnull
  @ApiModelProperty(required = true, value = "Last Time Project's Revision was Updated")

  public OffsetDateTime getUpdatedAt() {
    return updatedAt;
  }





  @Override
  public boolean equals(Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    ProjectInvite projectInvite = (ProjectInvite) o;
    return Objects.equals(this.createdAt, projectInvite.createdAt) &&
        Objects.equals(this.id, projectInvite.id) &&
        Objects.equals(this.inviteeEmail, projectInvite.inviteeEmail) &&
        Objects.equals(this.inviteeId, projectInvite.inviteeId) &&
        Objects.equals(this.ownerEmail, projectInvite.ownerEmail) &&
        Objects.equals(this.ownerId, projectInvite.ownerId) &&
        Objects.equals(this.projectId, projectInvite.projectId) &&
        Objects.equals(this.status, projectInvite.status) &&
        Objects.equals(this.updatedAt, projectInvite.updatedAt);
  }

  private static <T> boolean equalsNullable(JsonNullable<T> a, JsonNullable<T> b) {
    return a == b || (a != null && b != null && a.isPresent() && b.isPresent() && Objects.deepEquals(a.get(), b.get()));
  }

  @Override
  public int hashCode() {
    return Objects.hash(createdAt, id, inviteeEmail, inviteeId, ownerEmail, ownerId, projectId, status, updatedAt);
  }

  private static <T> int hashCodeNullable(JsonNullable<T> a) {
    if (a == null) {
      return 1;
    }
    return a.isPresent() ? Arrays.deepHashCode(new Object[]{a.get()}) : 31;
  }

  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class ProjectInvite {\n");
    sb.append("    createdAt: ").append(toIndentedString(createdAt)).append("\n");
    sb.append("    id: ").append(toIndentedString(id)).append("\n");
    sb.append("    inviteeEmail: ").append(toIndentedString(inviteeEmail)).append("\n");
    sb.append("    inviteeId: ").append(toIndentedString(inviteeId)).append("\n");
    sb.append("    ownerEmail: ").append(toIndentedString(ownerEmail)).append("\n");
    sb.append("    ownerId: ").append(toIndentedString(ownerId)).append("\n");
    sb.append("    projectId: ").append(toIndentedString(projectId)).append("\n");
    sb.append("    status: ").append(toIndentedString(status)).append("\n");
    sb.append("    updatedAt: ").append(toIndentedString(updatedAt)).append("\n");
    sb.append("}");
    return sb.toString();
  }

  /**
   * Convert the given object to string with each line indented by 4 spaces
   * (except the first line).
   */
  private String toIndentedString(Object o) {
    if (o == null) {
      return "null";
    }
    return o.toString().replace("\n", "\n    ");
  }


  public static HashSet<String> openapiFields;
  public static HashSet<String> openapiRequiredFields;

  static {
    // a set of all properties/fields (JSON key names)
    openapiFields = new HashSet<String>();
    openapiFields.add("created_at");
    openapiFields.add("id");
    openapiFields.add("invitee_email");
    openapiFields.add("invitee_id");
    openapiFields.add("owner_email");
    openapiFields.add("owner_id");
    openapiFields.add("project_id");
    openapiFields.add("status");
    openapiFields.add("updated_at");

    // a set of required properties/fields (JSON key names)
    openapiRequiredFields = new HashSet<String>();
    openapiRequiredFields.add("created_at");
    openapiRequiredFields.add("id");
    openapiRequiredFields.add("invitee_email");
    openapiRequiredFields.add("owner_email");
    openapiRequiredFields.add("owner_id");
    openapiRequiredFields.add("project_id");
    openapiRequiredFields.add("status");
    openapiRequiredFields.add("updated_at");
  }

 /**
  * Validates the JSON Object and throws an exception if issues found
  *
  * @param jsonObj JSON Object
  * @throws IOException if the JSON Object is invalid with respect to ProjectInvite
  */
  public static void validateJsonObject(JsonObject jsonObj) throws IOException {
      if (jsonObj == null) {
        if (!ProjectInvite.openapiRequiredFields.isEmpty()) { // has required fields but JSON object is null
          throw new IllegalArgumentException(String.format("The required field(s) %s in ProjectInvite is not found in the empty JSON string", ProjectInvite.openapiRequiredFields.toString()));
        }
      }

      Set<Entry<String, JsonElement>> entries = jsonObj.entrySet();
      // check to see if the JSON string contains additional fields
      for (Entry<String, JsonElement> entry : entries) {
        if (!ProjectInvite.openapiFields.contains(entry.getKey())) {
          throw new IllegalArgumentException(String.format("The field `%s` in the JSON string is not defined in the `ProjectInvite` properties. JSON: %s", entry.getKey(), jsonObj.toString()));
        }
      }

      // check to make sure all required properties/fields are present in the JSON string
      for (String requiredField : ProjectInvite.openapiRequiredFields) {
        if (jsonObj.get(requiredField) == null) {
          throw new IllegalArgumentException(String.format("The required field `%s` is not found in the JSON string: %s", requiredField, jsonObj.toString()));
        }
      }
      if (!jsonObj.get("id").isJsonPrimitive()) {
        throw new IllegalArgumentException(String.format("Expected the field `id` to be a primitive type in the JSON string but got `%s`", jsonObj.get("id").toString()));
      }
      if (!jsonObj.get("invitee_email").isJsonPrimitive()) {
        throw new IllegalArgumentException(String.format("Expected the field `invitee_email` to be a primitive type in the JSON string but got `%s`", jsonObj.get("invitee_email").toString()));
      }
      if ((jsonObj.get("invitee_id") != null && !jsonObj.get("invitee_id").isJsonNull()) && !jsonObj.get("invitee_id").isJsonPrimitive()) {
        throw new IllegalArgumentException(String.format("Expected the field `invitee_id` to be a primitive type in the JSON string but got `%s`", jsonObj.get("invitee_id").toString()));
      }
      if (!jsonObj.get("owner_email").isJsonPrimitive()) {
        throw new IllegalArgumentException(String.format("Expected the field `owner_email` to be a primitive type in the JSON string but got `%s`", jsonObj.get("owner_email").toString()));
      }
      if (!jsonObj.get("owner_id").isJsonPrimitive()) {
        throw new IllegalArgumentException(String.format("Expected the field `owner_id` to be a primitive type in the JSON string but got `%s`", jsonObj.get("owner_id").toString()));
      }
      if (!jsonObj.get("project_id").isJsonPrimitive()) {
        throw new IllegalArgumentException(String.format("Expected the field `project_id` to be a primitive type in the JSON string but got `%s`", jsonObj.get("project_id").toString()));
      }
      if (!jsonObj.get("status").isJsonPrimitive()) {
        throw new IllegalArgumentException(String.format("Expected the field `status` to be a primitive type in the JSON string but got `%s`", jsonObj.get("status").toString()));
      }
  }

  public static class CustomTypeAdapterFactory implements TypeAdapterFactory {
    @SuppressWarnings("unchecked")
    @Override
    public <T> TypeAdapter<T> create(Gson gson, TypeToken<T> type) {
       if (!ProjectInvite.class.isAssignableFrom(type.getRawType())) {
         return null; // this class only serializes 'ProjectInvite' and its subtypes
       }
       final TypeAdapter<JsonElement> elementAdapter = gson.getAdapter(JsonElement.class);
       final TypeAdapter<ProjectInvite> thisAdapter
                        = gson.getDelegateAdapter(this, TypeToken.get(ProjectInvite.class));

       return (TypeAdapter<T>) new TypeAdapter<ProjectInvite>() {
           @Override
           public void write(JsonWriter out, ProjectInvite value) throws IOException {
             JsonObject obj = thisAdapter.toJsonTree(value).getAsJsonObject();
             elementAdapter.write(out, obj);
           }

           @Override
           public ProjectInvite read(JsonReader in) throws IOException {
             JsonObject jsonObj = elementAdapter.read(in).getAsJsonObject();
             validateJsonObject(jsonObj);
             return thisAdapter.fromJsonTree(jsonObj);
           }

       }.nullSafe();
    }
  }

 /**
  * Create an instance of ProjectInvite given an JSON string
  *
  * @param jsonString JSON string
  * @return An instance of ProjectInvite
  * @throws IOException if the JSON string is invalid with respect to ProjectInvite
  */
  public static ProjectInvite fromJson(String jsonString) throws IOException {
    return JSON.getGson().fromJson(jsonString, ProjectInvite.class);
  }

 /**
  * Convert an instance of ProjectInvite to an JSON string
  *
  * @return JSON string
  */
  public String toJson() {
    return JSON.getGson().toJson(this);
  }
}

