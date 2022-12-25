/*
 * Ory APIs
 *
 * Documentation for all public and administrative Ory APIs. Administrative APIs can only be accessed with a valid Personal Access Token. Public APIs are mostly used in browsers. 
 *
 * The version of the OpenAPI document: v1.1.4
 * Contact: support@ory.sh
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using Xunit;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using Ory.Client.Api;
using Ory.Client.Model;
using Ory.Client.Client;
using System.Reflection;
using Newtonsoft.Json;

namespace Ory.Client.Test.Model
{
    /// <summary>
    ///  Class for testing ClientOidcConfiguration
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class ClientOidcConfigurationTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for ClientOidcConfiguration
        //private ClientOidcConfiguration instance;

        public ClientOidcConfigurationTests()
        {
            // TODO uncomment below to create an instance of ClientOidcConfiguration
            //instance = new ClientOidcConfiguration();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of ClientOidcConfiguration
        /// </summary>
        [Fact]
        public void ClientOidcConfigurationInstanceTest()
        {
            // TODO uncomment below to test "IsType" ClientOidcConfiguration
            //Assert.IsType<ClientOidcConfiguration>(instance);
        }


        /// <summary>
        /// Test the property 'AuthorizationEndpoint'
        /// </summary>
        [Fact]
        public void AuthorizationEndpointTest()
        {
            // TODO unit test for the property 'AuthorizationEndpoint'
        }
        /// <summary>
        /// Test the property 'BackchannelLogoutSessionSupported'
        /// </summary>
        [Fact]
        public void BackchannelLogoutSessionSupportedTest()
        {
            // TODO unit test for the property 'BackchannelLogoutSessionSupported'
        }
        /// <summary>
        /// Test the property 'BackchannelLogoutSupported'
        /// </summary>
        [Fact]
        public void BackchannelLogoutSupportedTest()
        {
            // TODO unit test for the property 'BackchannelLogoutSupported'
        }
        /// <summary>
        /// Test the property 'ClaimsParameterSupported'
        /// </summary>
        [Fact]
        public void ClaimsParameterSupportedTest()
        {
            // TODO unit test for the property 'ClaimsParameterSupported'
        }
        /// <summary>
        /// Test the property 'ClaimsSupported'
        /// </summary>
        [Fact]
        public void ClaimsSupportedTest()
        {
            // TODO unit test for the property 'ClaimsSupported'
        }
        /// <summary>
        /// Test the property 'CodeChallengeMethodsSupported'
        /// </summary>
        [Fact]
        public void CodeChallengeMethodsSupportedTest()
        {
            // TODO unit test for the property 'CodeChallengeMethodsSupported'
        }
        /// <summary>
        /// Test the property 'EndSessionEndpoint'
        /// </summary>
        [Fact]
        public void EndSessionEndpointTest()
        {
            // TODO unit test for the property 'EndSessionEndpoint'
        }
        /// <summary>
        /// Test the property 'FrontchannelLogoutSessionSupported'
        /// </summary>
        [Fact]
        public void FrontchannelLogoutSessionSupportedTest()
        {
            // TODO unit test for the property 'FrontchannelLogoutSessionSupported'
        }
        /// <summary>
        /// Test the property 'FrontchannelLogoutSupported'
        /// </summary>
        [Fact]
        public void FrontchannelLogoutSupportedTest()
        {
            // TODO unit test for the property 'FrontchannelLogoutSupported'
        }
        /// <summary>
        /// Test the property 'GrantTypesSupported'
        /// </summary>
        [Fact]
        public void GrantTypesSupportedTest()
        {
            // TODO unit test for the property 'GrantTypesSupported'
        }
        /// <summary>
        /// Test the property 'IdTokenSignedResponseAlg'
        /// </summary>
        [Fact]
        public void IdTokenSignedResponseAlgTest()
        {
            // TODO unit test for the property 'IdTokenSignedResponseAlg'
        }
        /// <summary>
        /// Test the property 'IdTokenSigningAlgValuesSupported'
        /// </summary>
        [Fact]
        public void IdTokenSigningAlgValuesSupportedTest()
        {
            // TODO unit test for the property 'IdTokenSigningAlgValuesSupported'
        }
        /// <summary>
        /// Test the property 'Issuer'
        /// </summary>
        [Fact]
        public void IssuerTest()
        {
            // TODO unit test for the property 'Issuer'
        }
        /// <summary>
        /// Test the property 'JwksUri'
        /// </summary>
        [Fact]
        public void JwksUriTest()
        {
            // TODO unit test for the property 'JwksUri'
        }
        /// <summary>
        /// Test the property 'RegistrationEndpoint'
        /// </summary>
        [Fact]
        public void RegistrationEndpointTest()
        {
            // TODO unit test for the property 'RegistrationEndpoint'
        }
        /// <summary>
        /// Test the property 'RequestObjectSigningAlgValuesSupported'
        /// </summary>
        [Fact]
        public void RequestObjectSigningAlgValuesSupportedTest()
        {
            // TODO unit test for the property 'RequestObjectSigningAlgValuesSupported'
        }
        /// <summary>
        /// Test the property 'RequestParameterSupported'
        /// </summary>
        [Fact]
        public void RequestParameterSupportedTest()
        {
            // TODO unit test for the property 'RequestParameterSupported'
        }
        /// <summary>
        /// Test the property 'RequestUriParameterSupported'
        /// </summary>
        [Fact]
        public void RequestUriParameterSupportedTest()
        {
            // TODO unit test for the property 'RequestUriParameterSupported'
        }
        /// <summary>
        /// Test the property 'RequireRequestUriRegistration'
        /// </summary>
        [Fact]
        public void RequireRequestUriRegistrationTest()
        {
            // TODO unit test for the property 'RequireRequestUriRegistration'
        }
        /// <summary>
        /// Test the property 'ResponseModesSupported'
        /// </summary>
        [Fact]
        public void ResponseModesSupportedTest()
        {
            // TODO unit test for the property 'ResponseModesSupported'
        }
        /// <summary>
        /// Test the property 'ResponseTypesSupported'
        /// </summary>
        [Fact]
        public void ResponseTypesSupportedTest()
        {
            // TODO unit test for the property 'ResponseTypesSupported'
        }
        /// <summary>
        /// Test the property 'RevocationEndpoint'
        /// </summary>
        [Fact]
        public void RevocationEndpointTest()
        {
            // TODO unit test for the property 'RevocationEndpoint'
        }
        /// <summary>
        /// Test the property 'ScopesSupported'
        /// </summary>
        [Fact]
        public void ScopesSupportedTest()
        {
            // TODO unit test for the property 'ScopesSupported'
        }
        /// <summary>
        /// Test the property 'SubjectTypesSupported'
        /// </summary>
        [Fact]
        public void SubjectTypesSupportedTest()
        {
            // TODO unit test for the property 'SubjectTypesSupported'
        }
        /// <summary>
        /// Test the property 'TokenEndpoint'
        /// </summary>
        [Fact]
        public void TokenEndpointTest()
        {
            // TODO unit test for the property 'TokenEndpoint'
        }
        /// <summary>
        /// Test the property 'TokenEndpointAuthMethodsSupported'
        /// </summary>
        [Fact]
        public void TokenEndpointAuthMethodsSupportedTest()
        {
            // TODO unit test for the property 'TokenEndpointAuthMethodsSupported'
        }
        /// <summary>
        /// Test the property 'UserinfoEndpoint'
        /// </summary>
        [Fact]
        public void UserinfoEndpointTest()
        {
            // TODO unit test for the property 'UserinfoEndpoint'
        }
        /// <summary>
        /// Test the property 'UserinfoSignedResponseAlg'
        /// </summary>
        [Fact]
        public void UserinfoSignedResponseAlgTest()
        {
            // TODO unit test for the property 'UserinfoSignedResponseAlg'
        }
        /// <summary>
        /// Test the property 'UserinfoSigningAlgValuesSupported'
        /// </summary>
        [Fact]
        public void UserinfoSigningAlgValuesSupportedTest()
        {
            // TODO unit test for the property 'UserinfoSigningAlgValuesSupported'
        }

    }

}
