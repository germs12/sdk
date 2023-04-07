/*
 * Ory Hydra API
 *
 * Documentation for all of Ory Hydra's APIs. 
 *
 * The version of the OpenAPI document: v2.1.0
 * Contact: hi@ory.sh
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Net.Mime;
using Ory.Hydra.Client.Client;
using Ory.Hydra.Client.Model;

namespace Ory.Hydra.Client.Api
{

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IWellknownApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Discover Well-Known JSON Web Keys
        /// </summary>
        /// <remarks>
        /// This endpoint returns JSON Web Keys required to verifying OpenID Connect ID Tokens and, if enabled, OAuth 2.0 JWT Access Tokens. This endpoint can be used with client libraries like [node-jwks-rsa](https://github.com/auth0/node-jwks-rsa) among others.
        /// </remarks>
        /// <exception cref="Ory.Hydra.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>HydraJsonWebKeySet</returns>
        HydraJsonWebKeySet DiscoverJsonWebKeys();

        /// <summary>
        /// Discover Well-Known JSON Web Keys
        /// </summary>
        /// <remarks>
        /// This endpoint returns JSON Web Keys required to verifying OpenID Connect ID Tokens and, if enabled, OAuth 2.0 JWT Access Tokens. This endpoint can be used with client libraries like [node-jwks-rsa](https://github.com/auth0/node-jwks-rsa) among others.
        /// </remarks>
        /// <exception cref="Ory.Hydra.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of HydraJsonWebKeySet</returns>
        ApiResponse<HydraJsonWebKeySet> DiscoverJsonWebKeysWithHttpInfo();
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IWellknownApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// Discover Well-Known JSON Web Keys
        /// </summary>
        /// <remarks>
        /// This endpoint returns JSON Web Keys required to verifying OpenID Connect ID Tokens and, if enabled, OAuth 2.0 JWT Access Tokens. This endpoint can be used with client libraries like [node-jwks-rsa](https://github.com/auth0/node-jwks-rsa) among others.
        /// </remarks>
        /// <exception cref="Ory.Hydra.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of HydraJsonWebKeySet</returns>
        System.Threading.Tasks.Task<HydraJsonWebKeySet> DiscoverJsonWebKeysAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Discover Well-Known JSON Web Keys
        /// </summary>
        /// <remarks>
        /// This endpoint returns JSON Web Keys required to verifying OpenID Connect ID Tokens and, if enabled, OAuth 2.0 JWT Access Tokens. This endpoint can be used with client libraries like [node-jwks-rsa](https://github.com/auth0/node-jwks-rsa) among others.
        /// </remarks>
        /// <exception cref="Ory.Hydra.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (HydraJsonWebKeySet)</returns>
        System.Threading.Tasks.Task<ApiResponse<HydraJsonWebKeySet>> DiscoverJsonWebKeysWithHttpInfoAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IWellknownApi : IWellknownApiSync, IWellknownApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class WellknownApi : IWellknownApi
    {
        private Ory.Hydra.Client.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="WellknownApi"/> class.
        /// </summary>
        /// <returns></returns>
        public WellknownApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WellknownApi"/> class.
        /// </summary>
        /// <returns></returns>
        public WellknownApi(string basePath)
        {
            this.Configuration = Ory.Hydra.Client.Client.Configuration.MergeConfigurations(
                Ory.Hydra.Client.Client.GlobalConfiguration.Instance,
                new Ory.Hydra.Client.Client.Configuration { BasePath = basePath }
            );
            this.Client = new Ory.Hydra.Client.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new Ory.Hydra.Client.Client.ApiClient(this.Configuration.BasePath);
            this.ExceptionFactory = Ory.Hydra.Client.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WellknownApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public WellknownApi(Ory.Hydra.Client.Client.Configuration configuration)
        {
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Configuration = Ory.Hydra.Client.Client.Configuration.MergeConfigurations(
                Ory.Hydra.Client.Client.GlobalConfiguration.Instance,
                configuration
            );
            this.Client = new Ory.Hydra.Client.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new Ory.Hydra.Client.Client.ApiClient(this.Configuration.BasePath);
            ExceptionFactory = Ory.Hydra.Client.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WellknownApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public WellknownApi(Ory.Hydra.Client.Client.ISynchronousClient client, Ory.Hydra.Client.Client.IAsynchronousClient asyncClient, Ory.Hydra.Client.Client.IReadableConfiguration configuration)
        {
            if (client == null) throw new ArgumentNullException("client");
            if (asyncClient == null) throw new ArgumentNullException("asyncClient");
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Client = client;
            this.AsynchronousClient = asyncClient;
            this.Configuration = configuration;
            this.ExceptionFactory = Ory.Hydra.Client.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// The client for accessing this underlying API asynchronously.
        /// </summary>
        public Ory.Hydra.Client.Client.IAsynchronousClient AsynchronousClient { get; set; }

        /// <summary>
        /// The client for accessing this underlying API synchronously.
        /// </summary>
        public Ory.Hydra.Client.Client.ISynchronousClient Client { get; set; }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public string GetBasePath()
        {
            return this.Configuration.BasePath;
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public Ory.Hydra.Client.Client.IReadableConfiguration Configuration { get; set; }

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public Ory.Hydra.Client.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// Discover Well-Known JSON Web Keys This endpoint returns JSON Web Keys required to verifying OpenID Connect ID Tokens and, if enabled, OAuth 2.0 JWT Access Tokens. This endpoint can be used with client libraries like [node-jwks-rsa](https://github.com/auth0/node-jwks-rsa) among others.
        /// </summary>
        /// <exception cref="Ory.Hydra.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>HydraJsonWebKeySet</returns>
        public HydraJsonWebKeySet DiscoverJsonWebKeys()
        {
            Ory.Hydra.Client.Client.ApiResponse<HydraJsonWebKeySet> localVarResponse = DiscoverJsonWebKeysWithHttpInfo();
            return localVarResponse.Data;
        }

        /// <summary>
        /// Discover Well-Known JSON Web Keys This endpoint returns JSON Web Keys required to verifying OpenID Connect ID Tokens and, if enabled, OAuth 2.0 JWT Access Tokens. This endpoint can be used with client libraries like [node-jwks-rsa](https://github.com/auth0/node-jwks-rsa) among others.
        /// </summary>
        /// <exception cref="Ory.Hydra.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of HydraJsonWebKeySet</returns>
        public Ory.Hydra.Client.Client.ApiResponse<HydraJsonWebKeySet> DiscoverJsonWebKeysWithHttpInfo()
        {
            Ory.Hydra.Client.Client.RequestOptions localVarRequestOptions = new Ory.Hydra.Client.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = Ory.Hydra.Client.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = Ory.Hydra.Client.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }



            // make the HTTP request
            var localVarResponse = this.Client.Get<HydraJsonWebKeySet>("/.well-known/jwks.json", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("DiscoverJsonWebKeys", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Discover Well-Known JSON Web Keys This endpoint returns JSON Web Keys required to verifying OpenID Connect ID Tokens and, if enabled, OAuth 2.0 JWT Access Tokens. This endpoint can be used with client libraries like [node-jwks-rsa](https://github.com/auth0/node-jwks-rsa) among others.
        /// </summary>
        /// <exception cref="Ory.Hydra.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of HydraJsonWebKeySet</returns>
        public async System.Threading.Tasks.Task<HydraJsonWebKeySet> DiscoverJsonWebKeysAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Ory.Hydra.Client.Client.ApiResponse<HydraJsonWebKeySet> localVarResponse = await DiscoverJsonWebKeysWithHttpInfoAsync(cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Discover Well-Known JSON Web Keys This endpoint returns JSON Web Keys required to verifying OpenID Connect ID Tokens and, if enabled, OAuth 2.0 JWT Access Tokens. This endpoint can be used with client libraries like [node-jwks-rsa](https://github.com/auth0/node-jwks-rsa) among others.
        /// </summary>
        /// <exception cref="Ory.Hydra.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (HydraJsonWebKeySet)</returns>
        public async System.Threading.Tasks.Task<Ory.Hydra.Client.Client.ApiResponse<HydraJsonWebKeySet>> DiscoverJsonWebKeysWithHttpInfoAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {

            Ory.Hydra.Client.Client.RequestOptions localVarRequestOptions = new Ory.Hydra.Client.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = Ory.Hydra.Client.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = Ory.Hydra.Client.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }



            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.GetAsync<HydraJsonWebKeySet>("/.well-known/jwks.json", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("DiscoverJsonWebKeys", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

    }
}
