/*
 * Ory APIs
 * Documentation for all public and administrative Ory APIs. Administrative APIs can only be accessed with a valid Personal Access Token. Public APIs are mostly used in browsers. 
 *
 * The version of the OpenAPI document: v1.1.32
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
import sh.ory.model.ContinueWithSetOrySessionToken;
import sh.ory.model.ContinueWithVerificationUi;
import sh.ory.model.ContinueWithVerificationUiFlow;

import javax.ws.rs.core.GenericType;

import java.io.IOException;
import java.lang.reflect.Type;
import java.util.logging.Level;
import java.util.logging.Logger;
import java.util.ArrayList;
import java.util.Collections;
import java.util.HashSet;
import java.util.HashMap;
import java.util.Map;

import com.google.gson.Gson;
import com.google.gson.GsonBuilder;
import com.google.gson.JsonParseException;
import com.google.gson.TypeAdapter;
import com.google.gson.TypeAdapterFactory;
import com.google.gson.reflect.TypeToken;
import com.google.gson.JsonPrimitive;
import com.google.gson.annotations.JsonAdapter;
import com.google.gson.annotations.SerializedName;
import com.google.gson.stream.JsonReader;
import com.google.gson.stream.JsonWriter;
import com.google.gson.JsonDeserializationContext;
import com.google.gson.JsonDeserializer;
import com.google.gson.JsonSerializationContext;
import com.google.gson.JsonSerializer;
import com.google.gson.JsonElement;
import com.google.gson.JsonObject;
import com.google.gson.JsonParseException;

import sh.ory.JSON;

@javax.annotation.Generated(value = "org.openapitools.codegen.languages.JavaClientCodegen", date = "2023-05-22T11:17:25.564791557Z[Etc/UTC]")
public class ContinueWith extends AbstractOpenApiSchema {
    private static final Logger log = Logger.getLogger(ContinueWith.class.getName());

    public static class CustomTypeAdapterFactory implements TypeAdapterFactory {
        @SuppressWarnings("unchecked")
        @Override
        public <T> TypeAdapter<T> create(Gson gson, TypeToken<T> type) {
            if (!ContinueWith.class.isAssignableFrom(type.getRawType())) {
                return null; // this class only serializes 'ContinueWith' and its subtypes
            }
            final TypeAdapter<JsonElement> elementAdapter = gson.getAdapter(JsonElement.class);
            final TypeAdapter<ContinueWithSetOrySessionToken> adapterContinueWithSetOrySessionToken = gson.getDelegateAdapter(this, TypeToken.get(ContinueWithSetOrySessionToken.class));
            final TypeAdapter<ContinueWithVerificationUi> adapterContinueWithVerificationUi = gson.getDelegateAdapter(this, TypeToken.get(ContinueWithVerificationUi.class));

            return (TypeAdapter<T>) new TypeAdapter<ContinueWith>() {
                @Override
                public void write(JsonWriter out, ContinueWith value) throws IOException {
                    if (value == null || value.getActualInstance() == null) {
                        elementAdapter.write(out, null);
                        return;
                    }

                    // check if the actual instance is of the type `ContinueWithSetOrySessionToken`
                    if (value.getActualInstance() instanceof ContinueWithSetOrySessionToken) {
                        JsonObject obj = adapterContinueWithSetOrySessionToken.toJsonTree((ContinueWithSetOrySessionToken)value.getActualInstance()).getAsJsonObject();
                        elementAdapter.write(out, obj);
                        return;
                    }

                    // check if the actual instance is of the type `ContinueWithVerificationUi`
                    if (value.getActualInstance() instanceof ContinueWithVerificationUi) {
                        JsonObject obj = adapterContinueWithVerificationUi.toJsonTree((ContinueWithVerificationUi)value.getActualInstance()).getAsJsonObject();
                        elementAdapter.write(out, obj);
                        return;
                    }

                    throw new IOException("Failed to serialize as the type doesn't match oneOf schemas: ContinueWithSetOrySessionToken, ContinueWithVerificationUi");
                }

                @Override
                public ContinueWith read(JsonReader in) throws IOException {
                    Object deserialized = null;
                    JsonObject jsonObject = elementAdapter.read(in).getAsJsonObject();

                    int match = 0;
                    ArrayList<String> errorMessages = new ArrayList<>();
                    TypeAdapter actualAdapter = elementAdapter;

                    // deserialize ContinueWithSetOrySessionToken
                    try {
                        // validate the JSON object to see if any exception is thrown
                        ContinueWithSetOrySessionToken.validateJsonObject(jsonObject);
                        actualAdapter = adapterContinueWithSetOrySessionToken;
                        match++;
                        log.log(Level.FINER, "Input data matches schema 'ContinueWithSetOrySessionToken'");
                    } catch (Exception e) {
                        // deserialization failed, continue
                        errorMessages.add(String.format("Deserialization for ContinueWithSetOrySessionToken failed with `%s`.", e.getMessage()));
                        log.log(Level.FINER, "Input data does not match schema 'ContinueWithSetOrySessionToken'", e);
                    }

                    // deserialize ContinueWithVerificationUi
                    try {
                        // validate the JSON object to see if any exception is thrown
                        ContinueWithVerificationUi.validateJsonObject(jsonObject);
                        actualAdapter = adapterContinueWithVerificationUi;
                        match++;
                        log.log(Level.FINER, "Input data matches schema 'ContinueWithVerificationUi'");
                    } catch (Exception e) {
                        // deserialization failed, continue
                        errorMessages.add(String.format("Deserialization for ContinueWithVerificationUi failed with `%s`.", e.getMessage()));
                        log.log(Level.FINER, "Input data does not match schema 'ContinueWithVerificationUi'", e);
                    }

                    if (match == 1) {
                        ContinueWith ret = new ContinueWith();
                        ret.setActualInstance(actualAdapter.fromJsonTree(jsonObject));
                        return ret;
                    }

                    throw new IOException(String.format("Failed deserialization for ContinueWith: %d classes match result, expected 1. Detailed failure message for oneOf schemas: %s. JSON: %s", match, errorMessages, jsonObject.toString()));
                }
            }.nullSafe();
        }
    }

    // store a list of schema names defined in oneOf
    public static final Map<String, GenericType> schemas = new HashMap<String, GenericType>();

    public ContinueWith() {
        super("oneOf", Boolean.FALSE);
    }

    public ContinueWith(ContinueWithSetOrySessionToken o) {
        super("oneOf", Boolean.FALSE);
        setActualInstance(o);
    }

    public ContinueWith(ContinueWithVerificationUi o) {
        super("oneOf", Boolean.FALSE);
        setActualInstance(o);
    }

    static {
        schemas.put("ContinueWithSetOrySessionToken", new GenericType<ContinueWithSetOrySessionToken>() {
        });
        schemas.put("ContinueWithVerificationUi", new GenericType<ContinueWithVerificationUi>() {
        });
    }

    @Override
    public Map<String, GenericType> getSchemas() {
        return ContinueWith.schemas;
    }

    /**
     * Set the instance that matches the oneOf child schema, check
     * the instance parameter is valid against the oneOf child schemas:
     * ContinueWithSetOrySessionToken, ContinueWithVerificationUi
     *
     * It could be an instance of the 'oneOf' schemas.
     * The oneOf child schemas may themselves be a composed schema (allOf, anyOf, oneOf).
     */
    @Override
    public void setActualInstance(Object instance) {
        if (instance instanceof ContinueWithSetOrySessionToken) {
            super.setActualInstance(instance);
            return;
        }

        if (instance instanceof ContinueWithVerificationUi) {
            super.setActualInstance(instance);
            return;
        }

        throw new RuntimeException("Invalid instance type. Must be ContinueWithSetOrySessionToken, ContinueWithVerificationUi");
    }

    /**
     * Get the actual instance, which can be the following:
     * ContinueWithSetOrySessionToken, ContinueWithVerificationUi
     *
     * @return The actual instance (ContinueWithSetOrySessionToken, ContinueWithVerificationUi)
     */
    @Override
    public Object getActualInstance() {
        return super.getActualInstance();
    }

    /**
     * Get the actual instance of `ContinueWithSetOrySessionToken`. If the actual instance is not `ContinueWithSetOrySessionToken`,
     * the ClassCastException will be thrown.
     *
     * @return The actual instance of `ContinueWithSetOrySessionToken`
     * @throws ClassCastException if the instance is not `ContinueWithSetOrySessionToken`
     */
    public ContinueWithSetOrySessionToken getContinueWithSetOrySessionToken() throws ClassCastException {
        return (ContinueWithSetOrySessionToken)super.getActualInstance();
    }

    /**
     * Get the actual instance of `ContinueWithVerificationUi`. If the actual instance is not `ContinueWithVerificationUi`,
     * the ClassCastException will be thrown.
     *
     * @return The actual instance of `ContinueWithVerificationUi`
     * @throws ClassCastException if the instance is not `ContinueWithVerificationUi`
     */
    public ContinueWithVerificationUi getContinueWithVerificationUi() throws ClassCastException {
        return (ContinueWithVerificationUi)super.getActualInstance();
    }


 /**
  * Validates the JSON Object and throws an exception if issues found
  *
  * @param jsonObj JSON Object
  * @throws IOException if the JSON Object is invalid with respect to ContinueWith
  */
  public static void validateJsonObject(JsonObject jsonObj) throws IOException {
    // validate oneOf schemas one by one
    int validCount = 0;
    ArrayList<String> errorMessages = new ArrayList<>();
    // validate the json string with ContinueWithSetOrySessionToken
    try {
      ContinueWithSetOrySessionToken.validateJsonObject(jsonObj);
      validCount++;
    } catch (Exception e) {
      errorMessages.add(String.format("Deserialization for ContinueWithSetOrySessionToken failed with `%s`.", e.getMessage()));
      // continue to the next one
    }
    // validate the json string with ContinueWithVerificationUi
    try {
      ContinueWithVerificationUi.validateJsonObject(jsonObj);
      validCount++;
    } catch (Exception e) {
      errorMessages.add(String.format("Deserialization for ContinueWithVerificationUi failed with `%s`.", e.getMessage()));
      // continue to the next one
    }
    if (validCount != 1) {
      throw new IOException(String.format("The JSON string is invalid for ContinueWith with oneOf schemas: ContinueWithSetOrySessionToken, ContinueWithVerificationUi. %d class(es) match the result, expected 1. Detailed failure message for oneOf schemas: %s. JSON: %s", validCount, errorMessages, jsonObj.toString()));
    }
  }

 /**
  * Create an instance of ContinueWith given an JSON string
  *
  * @param jsonString JSON string
  * @return An instance of ContinueWith
  * @throws IOException if the JSON string is invalid with respect to ContinueWith
  */
  public static ContinueWith fromJson(String jsonString) throws IOException {
    return JSON.getGson().fromJson(jsonString, ContinueWith.class);
  }

 /**
  * Convert an instance of ContinueWith to an JSON string
  *
  * @return JSON string
  */
  public String toJson() {
    return JSON.getGson().toJson(this);
  }
}

