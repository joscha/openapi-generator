/*
 * Echo Server API
 *
 * Echo Server API
 *
 * The version of the OpenAPI document: 0.1.0
 * Contact: team@openapitools.org
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Net.Mime;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Org.OpenAPITools.Api
{

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IPathApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Test path parameter(s)
        /// </summary>
        /// <remarks>
        /// Test path parameter(s)
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pathString"></param>
        /// <param name="pathInteger"></param>
        /// <param name="enumNonrefStringPath"></param>
        /// <param name="enumRefStringPath"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>string</returns>
        string TestsPathStringpathStringIntegerPathIntegerEnumNonrefStringPathEnumRefStringPath(string pathString, int pathInteger, string enumNonrefStringPath, StringEnumRef enumRefStringPath, int operationIndex = 0);

        /// <summary>
        /// Test path parameter(s)
        /// </summary>
        /// <remarks>
        /// Test path parameter(s)
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pathString"></param>
        /// <param name="pathInteger"></param>
        /// <param name="enumNonrefStringPath"></param>
        /// <param name="enumRefStringPath"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> TestsPathStringpathStringIntegerPathIntegerEnumNonrefStringPathEnumRefStringPathWithHttpInfo(string pathString, int pathInteger, string enumNonrefStringPath, StringEnumRef enumRefStringPath, int operationIndex = 0);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IPathApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// Test path parameter(s)
        /// </summary>
        /// <remarks>
        /// Test path parameter(s)
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pathString"></param>
        /// <param name="pathInteger"></param>
        /// <param name="enumNonrefStringPath"></param>
        /// <param name="enumRefStringPath"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> TestsPathStringpathStringIntegerPathIntegerEnumNonrefStringPathEnumRefStringPathAsync(string pathString, int pathInteger, string enumNonrefStringPath, StringEnumRef enumRefStringPath, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Test path parameter(s)
        /// </summary>
        /// <remarks>
        /// Test path parameter(s)
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pathString"></param>
        /// <param name="pathInteger"></param>
        /// <param name="enumNonrefStringPath"></param>
        /// <param name="enumRefStringPath"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> TestsPathStringpathStringIntegerPathIntegerEnumNonrefStringPathEnumRefStringPathWithHttpInfoAsync(string pathString, int pathInteger, string enumNonrefStringPath, StringEnumRef enumRefStringPath, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IPathApi : IPathApiSync, IPathApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class PathApi : IPathApi
    {
        private Org.OpenAPITools.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="PathApi"/> class.
        /// </summary>
        /// <returns></returns>
        public PathApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PathApi"/> class.
        /// </summary>
        /// <returns></returns>
        public PathApi(string basePath)
        {
            this.Configuration = Org.OpenAPITools.Client.Configuration.MergeConfigurations(
                Org.OpenAPITools.Client.GlobalConfiguration.Instance,
                new Org.OpenAPITools.Client.Configuration { BasePath = basePath }
            );
            this.Client = new Org.OpenAPITools.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new Org.OpenAPITools.Client.ApiClient(this.Configuration.BasePath);
            this.ExceptionFactory = Org.OpenAPITools.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PathApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public PathApi(Org.OpenAPITools.Client.Configuration configuration)
        {
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Configuration = Org.OpenAPITools.Client.Configuration.MergeConfigurations(
                Org.OpenAPITools.Client.GlobalConfiguration.Instance,
                configuration
            );
            this.Client = new Org.OpenAPITools.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new Org.OpenAPITools.Client.ApiClient(this.Configuration.BasePath);
            ExceptionFactory = Org.OpenAPITools.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PathApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public PathApi(Org.OpenAPITools.Client.ISynchronousClient client, Org.OpenAPITools.Client.IAsynchronousClient asyncClient, Org.OpenAPITools.Client.IReadableConfiguration configuration)
        {
            if (client == null) throw new ArgumentNullException("client");
            if (asyncClient == null) throw new ArgumentNullException("asyncClient");
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Client = client;
            this.AsynchronousClient = asyncClient;
            this.Configuration = configuration;
            this.ExceptionFactory = Org.OpenAPITools.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// The client for accessing this underlying API asynchronously.
        /// </summary>
        public Org.OpenAPITools.Client.IAsynchronousClient AsynchronousClient { get; set; }

        /// <summary>
        /// The client for accessing this underlying API synchronously.
        /// </summary>
        public Org.OpenAPITools.Client.ISynchronousClient Client { get; set; }

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
        public Org.OpenAPITools.Client.IReadableConfiguration Configuration { get; set; }

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public Org.OpenAPITools.Client.ExceptionFactory ExceptionFactory
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
        /// Test path parameter(s) Test path parameter(s)
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pathString"></param>
        /// <param name="pathInteger"></param>
        /// <param name="enumNonrefStringPath"></param>
        /// <param name="enumRefStringPath"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>string</returns>
        public string TestsPathStringpathStringIntegerPathIntegerEnumNonrefStringPathEnumRefStringPath(string pathString, int pathInteger, string enumNonrefStringPath, StringEnumRef enumRefStringPath, int operationIndex = 0)
        {
            Org.OpenAPITools.Client.ApiResponse<string> localVarResponse = TestsPathStringpathStringIntegerPathIntegerEnumNonrefStringPathEnumRefStringPathWithHttpInfo(pathString, pathInteger, enumNonrefStringPath, enumRefStringPath);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Test path parameter(s) Test path parameter(s)
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pathString"></param>
        /// <param name="pathInteger"></param>
        /// <param name="enumNonrefStringPath"></param>
        /// <param name="enumRefStringPath"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of string</returns>
        public Org.OpenAPITools.Client.ApiResponse<string> TestsPathStringpathStringIntegerPathIntegerEnumNonrefStringPathEnumRefStringPathWithHttpInfo(string pathString, int pathInteger, string enumNonrefStringPath, StringEnumRef enumRefStringPath, int operationIndex = 0)
        {
            // verify the required parameter 'pathString' is set
            if (pathString == null)
            {
                throw new Org.OpenAPITools.Client.ApiException(400, "Missing required parameter 'pathString' when calling PathApi->TestsPathStringpathStringIntegerPathIntegerEnumNonrefStringPathEnumRefStringPath");
            }

            // verify the required parameter 'enumNonrefStringPath' is set
            if (enumNonrefStringPath == null)
            {
                throw new Org.OpenAPITools.Client.ApiException(400, "Missing required parameter 'enumNonrefStringPath' when calling PathApi->TestsPathStringpathStringIntegerPathIntegerEnumNonrefStringPathEnumRefStringPath");
            }

            Org.OpenAPITools.Client.RequestOptions localVarRequestOptions = new Org.OpenAPITools.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "text/plain"
            };

            var localVarContentType = Org.OpenAPITools.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = Org.OpenAPITools.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.PathParameters.Add("path_string", Org.OpenAPITools.Client.ClientUtils.ParameterToString(pathString)); // path parameter
            localVarRequestOptions.PathParameters.Add("path_integer", Org.OpenAPITools.Client.ClientUtils.ParameterToString(pathInteger)); // path parameter
            localVarRequestOptions.PathParameters.Add("enum_nonref_string_path", Org.OpenAPITools.Client.ClientUtils.ParameterToString(enumNonrefStringPath)); // path parameter
            localVarRequestOptions.PathParameters.Add("enum_ref_string_path", Org.OpenAPITools.Client.ClientUtils.ParameterToString(enumRefStringPath)); // path parameter

            localVarRequestOptions.Operation = "PathApi.TestsPathStringpathStringIntegerPathIntegerEnumNonrefStringPathEnumRefStringPath";
            localVarRequestOptions.OperationIndex = operationIndex;


            // make the HTTP request
            var localVarResponse = this.Client.Get<string>("/path/string/{path_string}/integer/{path_integer}/{enum_nonref_string_path}/{enum_ref_string_path}", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("TestsPathStringpathStringIntegerPathIntegerEnumNonrefStringPathEnumRefStringPath", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Test path parameter(s) Test path parameter(s)
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pathString"></param>
        /// <param name="pathInteger"></param>
        /// <param name="enumNonrefStringPath"></param>
        /// <param name="enumRefStringPath"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> TestsPathStringpathStringIntegerPathIntegerEnumNonrefStringPathEnumRefStringPathAsync(string pathString, int pathInteger, string enumNonrefStringPath, StringEnumRef enumRefStringPath, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Org.OpenAPITools.Client.ApiResponse<string> localVarResponse = await TestsPathStringpathStringIntegerPathIntegerEnumNonrefStringPathEnumRefStringPathWithHttpInfoAsync(pathString, pathInteger, enumNonrefStringPath, enumRefStringPath, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Test path parameter(s) Test path parameter(s)
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pathString"></param>
        /// <param name="pathInteger"></param>
        /// <param name="enumNonrefStringPath"></param>
        /// <param name="enumRefStringPath"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<Org.OpenAPITools.Client.ApiResponse<string>> TestsPathStringpathStringIntegerPathIntegerEnumNonrefStringPathEnumRefStringPathWithHttpInfoAsync(string pathString, int pathInteger, string enumNonrefStringPath, StringEnumRef enumRefStringPath, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'pathString' is set
            if (pathString == null)
            {
                throw new Org.OpenAPITools.Client.ApiException(400, "Missing required parameter 'pathString' when calling PathApi->TestsPathStringpathStringIntegerPathIntegerEnumNonrefStringPathEnumRefStringPath");
            }

            // verify the required parameter 'enumNonrefStringPath' is set
            if (enumNonrefStringPath == null)
            {
                throw new Org.OpenAPITools.Client.ApiException(400, "Missing required parameter 'enumNonrefStringPath' when calling PathApi->TestsPathStringpathStringIntegerPathIntegerEnumNonrefStringPathEnumRefStringPath");
            }


            Org.OpenAPITools.Client.RequestOptions localVarRequestOptions = new Org.OpenAPITools.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "text/plain"
            };

            var localVarContentType = Org.OpenAPITools.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = Org.OpenAPITools.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.PathParameters.Add("path_string", Org.OpenAPITools.Client.ClientUtils.ParameterToString(pathString)); // path parameter
            localVarRequestOptions.PathParameters.Add("path_integer", Org.OpenAPITools.Client.ClientUtils.ParameterToString(pathInteger)); // path parameter
            localVarRequestOptions.PathParameters.Add("enum_nonref_string_path", Org.OpenAPITools.Client.ClientUtils.ParameterToString(enumNonrefStringPath)); // path parameter
            localVarRequestOptions.PathParameters.Add("enum_ref_string_path", Org.OpenAPITools.Client.ClientUtils.ParameterToString(enumRefStringPath)); // path parameter

            localVarRequestOptions.Operation = "PathApi.TestsPathStringpathStringIntegerPathIntegerEnumNonrefStringPathEnumRefStringPath";
            localVarRequestOptions.OperationIndex = operationIndex;


            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.GetAsync<string>("/path/string/{path_string}/integer/{path_integer}/{enum_nonref_string_path}/{enum_ref_string_path}", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("TestsPathStringpathStringIntegerPathIntegerEnumNonrefStringPathEnumRefStringPath", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

    }
}
