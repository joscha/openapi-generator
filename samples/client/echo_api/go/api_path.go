/*
Echo Server API

Echo Server API

API version: 0.1.0
Contact: team@openapitools.org
*/

// Code generated by OpenAPI Generator (https://openapi-generator.tech); DO NOT EDIT.

package openapi

import (
	"bytes"
	"context"
	"io"
	"net/http"
	"net/url"
	"strings"
)


// PathAPIService PathAPI service
type PathAPIService service

type ApiTestsPathStringpathStringIntegerPathIntegerEnumNonrefStringPathEnumRefStringPathRequest struct {
	ctx context.Context
	ApiService *PathAPIService
	pathString string
	pathInteger int32
	enumNonrefStringPath string
	enumRefStringPath StringEnumRef
}

func (r ApiTestsPathStringpathStringIntegerPathIntegerEnumNonrefStringPathEnumRefStringPathRequest) Execute() (string, *http.Response, error) {
	return r.ApiService.TestsPathStringpathStringIntegerPathIntegerEnumNonrefStringPathEnumRefStringPathExecute(r)
}

/*
TestsPathStringpathStringIntegerPathIntegerEnumNonrefStringPathEnumRefStringPath Test path parameter(s)

Test path parameter(s)

 @param ctx context.Context - for authentication, logging, cancellation, deadlines, tracing, etc. Passed from http.Request or context.Background().
 @param pathString
 @param pathInteger
 @param enumNonrefStringPath
 @param enumRefStringPath
 @return ApiTestsPathStringpathStringIntegerPathIntegerEnumNonrefStringPathEnumRefStringPathRequest
*/
func (a *PathAPIService) TestsPathStringpathStringIntegerPathIntegerEnumNonrefStringPathEnumRefStringPath(ctx context.Context, pathString string, pathInteger int32, enumNonrefStringPath string, enumRefStringPath StringEnumRef) ApiTestsPathStringpathStringIntegerPathIntegerEnumNonrefStringPathEnumRefStringPathRequest {
	return ApiTestsPathStringpathStringIntegerPathIntegerEnumNonrefStringPathEnumRefStringPathRequest{
		ApiService: a,
		ctx: ctx,
		pathString: pathString,
		pathInteger: pathInteger,
		enumNonrefStringPath: enumNonrefStringPath,
		enumRefStringPath: enumRefStringPath,
	}
}

// Execute executes the request
//  @return string
func (a *PathAPIService) TestsPathStringpathStringIntegerPathIntegerEnumNonrefStringPathEnumRefStringPathExecute(r ApiTestsPathStringpathStringIntegerPathIntegerEnumNonrefStringPathEnumRefStringPathRequest) (string, *http.Response, error) {
	var (
		localVarHTTPMethod   = http.MethodGet
		localVarPostBody     interface{}
		formFiles            []formFile
		localVarReturnValue  string
	)

	localBasePath, err := a.client.cfg.ServerURLWithContext(r.ctx, "PathAPIService.TestsPathStringpathStringIntegerPathIntegerEnumNonrefStringPathEnumRefStringPath")
	if err != nil {
		return localVarReturnValue, nil, &GenericOpenAPIError{error: err.Error()}
	}

	localVarPath := localBasePath + "/path/string/{path_string}/integer/{path_integer}/{enum_nonref_string_path}/{enum_ref_string_path}"
	localVarPath = strings.Replace(localVarPath, "{"+"path_string"+"}", url.PathEscape(parameterValueToString(r.pathString, "pathString")), -1)
	localVarPath = strings.Replace(localVarPath, "{"+"path_integer"+"}", url.PathEscape(parameterValueToString(r.pathInteger, "pathInteger")), -1)
	localVarPath = strings.Replace(localVarPath, "{"+"enum_nonref_string_path"+"}", url.PathEscape(parameterValueToString(r.enumNonrefStringPath, "enumNonrefStringPath")), -1)
	localVarPath = strings.Replace(localVarPath, "{"+"enum_ref_string_path"+"}", url.PathEscape(parameterValueToString(r.enumRefStringPath, "enumRefStringPath")), -1)

	localVarHeaderParams := make(map[string]string)
	localVarQueryParams := url.Values{}
	localVarFormParams := url.Values{}

	// to determine the Content-Type header
	localVarHTTPContentTypes := []string{}

	// set Content-Type header
	localVarHTTPContentType := selectHeaderContentType(localVarHTTPContentTypes)
	if localVarHTTPContentType != "" {
		localVarHeaderParams["Content-Type"] = localVarHTTPContentType
	}

	// to determine the Accept header
	localVarHTTPHeaderAccepts := []string{"text/plain"}

	// set Accept header
	localVarHTTPHeaderAccept := selectHeaderAccept(localVarHTTPHeaderAccepts)
	if localVarHTTPHeaderAccept != "" {
		localVarHeaderParams["Accept"] = localVarHTTPHeaderAccept
	}
	req, err := a.client.prepareRequest(r.ctx, localVarPath, localVarHTTPMethod, localVarPostBody, localVarHeaderParams, localVarQueryParams, localVarFormParams, formFiles)
	if err != nil {
		return localVarReturnValue, nil, err
	}

	localVarHTTPResponse, err := a.client.callAPI(req)
	if err != nil || localVarHTTPResponse == nil {
		return localVarReturnValue, localVarHTTPResponse, err
	}

	localVarBody, err := io.ReadAll(localVarHTTPResponse.Body)
	localVarHTTPResponse.Body.Close()
	localVarHTTPResponse.Body = io.NopCloser(bytes.NewBuffer(localVarBody))
	if err != nil {
		return localVarReturnValue, localVarHTTPResponse, err
	}

	if localVarHTTPResponse.StatusCode >= 300 {
		newErr := &GenericOpenAPIError{
			body:  localVarBody,
			error: localVarHTTPResponse.Status,
		}
		return localVarReturnValue, localVarHTTPResponse, newErr
	}

	err = a.client.decode(&localVarReturnValue, localVarBody, localVarHTTPResponse.Header.Get("Content-Type"))
	if err != nil {
		newErr := &GenericOpenAPIError{
			body:  localVarBody,
			error: err.Error(),
		}
		return localVarReturnValue, localVarHTTPResponse, newErr
	}

	return localVarReturnValue, localVarHTTPResponse, nil
}
