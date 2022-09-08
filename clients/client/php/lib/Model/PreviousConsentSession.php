<?php
/**
 * PreviousConsentSession
 *
 * PHP version 7.3
 *
 * @category Class
 * @package  Ory\Client
 * @author   OpenAPI Generator team
 * @link     https://openapi-generator.tech
 */

/**
 * Ory APIs
 *
 * Documentation for all public and administrative Ory APIs. Administrative APIs can only be accessed with a valid Personal Access Token. Public APIs are mostly used in browsers.
 *
 * The version of the OpenAPI document: v0.2.0-alpha.36
 * Contact: support@ory.sh
 * Generated by: https://openapi-generator.tech
 * OpenAPI Generator version: 5.4.0
 */

/**
 * NOTE: This class is auto generated by OpenAPI Generator (https://openapi-generator.tech).
 * https://openapi-generator.tech
 * Do not edit the class manually.
 */

namespace Ory\Client\Model;

use \ArrayAccess;
use \Ory\Client\ObjectSerializer;

/**
 * PreviousConsentSession Class Doc Comment
 *
 * @category Class
 * @description The response used to return used consent requests same as HandledLoginRequest, just with consent_request exposed as json
 * @package  Ory\Client
 * @author   OpenAPI Generator team
 * @link     https://openapi-generator.tech
 * @implements \ArrayAccess<TKey, TValue>
 * @template TKey int|null
 * @template TValue mixed|null
 */
class PreviousConsentSession implements ModelInterface, ArrayAccess, \JsonSerializable
{
    public const DISCRIMINATOR = null;

    /**
      * The original name of the model.
      *
      * @var string
      */
    protected static $openAPIModelName = 'PreviousConsentSession';

    /**
      * Array of property to type mappings. Used for (de)serialization
      *
      * @var string[]
      */
    protected static $openAPITypes = [
        'consentRequest' => '\Ory\Client\Model\ConsentRequest',
        'grantAccessTokenAudience' => 'string[]',
        'grantScope' => 'string[]',
        'handledAt' => '\DateTime',
        'remember' => 'bool',
        'rememberFor' => 'int',
        'session' => '\Ory\Client\Model\ConsentRequestSession'
    ];

    /**
      * Array of property to format mappings. Used for (de)serialization
      *
      * @var string[]
      * @phpstan-var array<string, string|null>
      * @psalm-var array<string, string|null>
      */
    protected static $openAPIFormats = [
        'consentRequest' => null,
        'grantAccessTokenAudience' => null,
        'grantScope' => null,
        'handledAt' => 'date-time',
        'remember' => null,
        'rememberFor' => 'int64',
        'session' => null
    ];

    /**
     * Array of property to type mappings. Used for (de)serialization
     *
     * @return array
     */
    public static function openAPITypes()
    {
        return self::$openAPITypes;
    }

    /**
     * Array of property to format mappings. Used for (de)serialization
     *
     * @return array
     */
    public static function openAPIFormats()
    {
        return self::$openAPIFormats;
    }

    /**
     * Array of attributes where the key is the local name,
     * and the value is the original name
     *
     * @var string[]
     */
    protected static $attributeMap = [
        'consentRequest' => 'consent_request',
        'grantAccessTokenAudience' => 'grant_access_token_audience',
        'grantScope' => 'grant_scope',
        'handledAt' => 'handled_at',
        'remember' => 'remember',
        'rememberFor' => 'remember_for',
        'session' => 'session'
    ];

    /**
     * Array of attributes to setter functions (for deserialization of responses)
     *
     * @var string[]
     */
    protected static $setters = [
        'consentRequest' => 'setConsentRequest',
        'grantAccessTokenAudience' => 'setGrantAccessTokenAudience',
        'grantScope' => 'setGrantScope',
        'handledAt' => 'setHandledAt',
        'remember' => 'setRemember',
        'rememberFor' => 'setRememberFor',
        'session' => 'setSession'
    ];

    /**
     * Array of attributes to getter functions (for serialization of requests)
     *
     * @var string[]
     */
    protected static $getters = [
        'consentRequest' => 'getConsentRequest',
        'grantAccessTokenAudience' => 'getGrantAccessTokenAudience',
        'grantScope' => 'getGrantScope',
        'handledAt' => 'getHandledAt',
        'remember' => 'getRemember',
        'rememberFor' => 'getRememberFor',
        'session' => 'getSession'
    ];

    /**
     * Array of attributes where the key is the local name,
     * and the value is the original name
     *
     * @return array
     */
    public static function attributeMap()
    {
        return self::$attributeMap;
    }

    /**
     * Array of attributes to setter functions (for deserialization of responses)
     *
     * @return array
     */
    public static function setters()
    {
        return self::$setters;
    }

    /**
     * Array of attributes to getter functions (for serialization of requests)
     *
     * @return array
     */
    public static function getters()
    {
        return self::$getters;
    }

    /**
     * The original name of the model.
     *
     * @return string
     */
    public function getModelName()
    {
        return self::$openAPIModelName;
    }


    /**
     * Associative array for storing property values
     *
     * @var mixed[]
     */
    protected $container = [];

    /**
     * Constructor
     *
     * @param mixed[] $data Associated array of property values
     *                      initializing the model
     */
    public function __construct(array $data = null)
    {
        $this->container['consentRequest'] = $data['consentRequest'] ?? null;
        $this->container['grantAccessTokenAudience'] = $data['grantAccessTokenAudience'] ?? null;
        $this->container['grantScope'] = $data['grantScope'] ?? null;
        $this->container['handledAt'] = $data['handledAt'] ?? null;
        $this->container['remember'] = $data['remember'] ?? null;
        $this->container['rememberFor'] = $data['rememberFor'] ?? null;
        $this->container['session'] = $data['session'] ?? null;
    }

    /**
     * Show all the invalid properties with reasons.
     *
     * @return array invalid properties with reasons
     */
    public function listInvalidProperties()
    {
        $invalidProperties = [];

        return $invalidProperties;
    }

    /**
     * Validate all the properties in the model
     * return true if all passed
     *
     * @return bool True if all properties are valid
     */
    public function valid()
    {
        return count($this->listInvalidProperties()) === 0;
    }


    /**
     * Gets consentRequest
     *
     * @return \Ory\Client\Model\ConsentRequest|null
     */
    public function getConsentRequest()
    {
        return $this->container['consentRequest'];
    }

    /**
     * Sets consentRequest
     *
     * @param \Ory\Client\Model\ConsentRequest|null $consentRequest consentRequest
     *
     * @return self
     */
    public function setConsentRequest($consentRequest)
    {
        $this->container['consentRequest'] = $consentRequest;

        return $this;
    }

    /**
     * Gets grantAccessTokenAudience
     *
     * @return string[]|null
     */
    public function getGrantAccessTokenAudience()
    {
        return $this->container['grantAccessTokenAudience'];
    }

    /**
     * Sets grantAccessTokenAudience
     *
     * @param string[]|null $grantAccessTokenAudience grantAccessTokenAudience
     *
     * @return self
     */
    public function setGrantAccessTokenAudience($grantAccessTokenAudience)
    {
        $this->container['grantAccessTokenAudience'] = $grantAccessTokenAudience;

        return $this;
    }

    /**
     * Gets grantScope
     *
     * @return string[]|null
     */
    public function getGrantScope()
    {
        return $this->container['grantScope'];
    }

    /**
     * Sets grantScope
     *
     * @param string[]|null $grantScope grantScope
     *
     * @return self
     */
    public function setGrantScope($grantScope)
    {
        $this->container['grantScope'] = $grantScope;

        return $this;
    }

    /**
     * Gets handledAt
     *
     * @return \DateTime|null
     */
    public function getHandledAt()
    {
        return $this->container['handledAt'];
    }

    /**
     * Sets handledAt
     *
     * @param \DateTime|null $handledAt handledAt
     *
     * @return self
     */
    public function setHandledAt($handledAt)
    {
        $this->container['handledAt'] = $handledAt;

        return $this;
    }

    /**
     * Gets remember
     *
     * @return bool|null
     */
    public function getRemember()
    {
        return $this->container['remember'];
    }

    /**
     * Sets remember
     *
     * @param bool|null $remember Remember, if set to true, tells ORY Hydra to remember this consent authorization and reuse it if the same client asks the same user for the same, or a subset of, scope.
     *
     * @return self
     */
    public function setRemember($remember)
    {
        $this->container['remember'] = $remember;

        return $this;
    }

    /**
     * Gets rememberFor
     *
     * @return int|null
     */
    public function getRememberFor()
    {
        return $this->container['rememberFor'];
    }

    /**
     * Sets rememberFor
     *
     * @param int|null $rememberFor RememberFor sets how long the consent authorization should be remembered for in seconds. If set to `0`, the authorization will be remembered indefinitely.
     *
     * @return self
     */
    public function setRememberFor($rememberFor)
    {
        $this->container['rememberFor'] = $rememberFor;

        return $this;
    }

    /**
     * Gets session
     *
     * @return \Ory\Client\Model\ConsentRequestSession|null
     */
    public function getSession()
    {
        return $this->container['session'];
    }

    /**
     * Sets session
     *
     * @param \Ory\Client\Model\ConsentRequestSession|null $session session
     *
     * @return self
     */
    public function setSession($session)
    {
        $this->container['session'] = $session;

        return $this;
    }
    /**
     * Returns true if offset exists. False otherwise.
     *
     * @param integer $offset Offset
     *
     * @return boolean
     */
    public function offsetExists($offset)
    {
        return isset($this->container[$offset]);
    }

    /**
     * Gets offset.
     *
     * @param integer $offset Offset
     *
     * @return mixed|null
     */
    public function offsetGet($offset)
    {
        return $this->container[$offset] ?? null;
    }

    /**
     * Sets value based on offset.
     *
     * @param int|null $offset Offset
     * @param mixed    $value  Value to be set
     *
     * @return void
     */
    public function offsetSet($offset, $value)
    {
        if (is_null($offset)) {
            $this->container[] = $value;
        } else {
            $this->container[$offset] = $value;
        }
    }

    /**
     * Unsets offset.
     *
     * @param integer $offset Offset
     *
     * @return void
     */
    public function offsetUnset($offset)
    {
        unset($this->container[$offset]);
    }

    /**
     * Serializes the object to a value that can be serialized natively by json_encode().
     * @link https://www.php.net/manual/en/jsonserializable.jsonserialize.php
     *
     * @return mixed Returns data which can be serialized by json_encode(), which is a value
     * of any type other than a resource.
     */
    public function jsonSerialize()
    {
       return ObjectSerializer::sanitizeForSerialization($this);
    }

    /**
     * Gets the string presentation of the object
     *
     * @return string
     */
    public function __toString()
    {
        return json_encode(
            ObjectSerializer::sanitizeForSerialization($this),
            JSON_PRETTY_PRINT
        );
    }

    /**
     * Gets a header-safe presentation of the object
     *
     * @return string
     */
    public function toHeaderValue()
    {
        return json_encode(ObjectSerializer::sanitizeForSerialization($this));
    }
}


