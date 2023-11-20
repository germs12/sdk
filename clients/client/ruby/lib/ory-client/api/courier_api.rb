=begin
#Ory APIs

#Documentation for all public and administrative Ory APIs. Administrative APIs can only be accessed with a valid Personal Access Token. Public APIs are mostly used in browsers. 

The version of the OpenAPI document: v1.4.2
Contact: support@ory.sh
Generated by: https://openapi-generator.tech
OpenAPI Generator version: 6.0.1

=end

require 'cgi'

module OryClient
  class CourierApi
    attr_accessor :api_client

    def initialize(api_client = ApiClient.default)
      @api_client = api_client
    end
    # Get a Message
    # Gets a specific messages by the given ID.
    # @param id [String] MessageID is the ID of the message.
    # @param [Hash] opts the optional parameters
    # @return [Message]
    def get_courier_message(id, opts = {})
      data, _status_code, _headers = get_courier_message_with_http_info(id, opts)
      data
    end

    # Get a Message
    # Gets a specific messages by the given ID.
    # @param id [String] MessageID is the ID of the message.
    # @param [Hash] opts the optional parameters
    # @return [Array<(Message, Integer, Hash)>] Message data, response status code and response headers
    def get_courier_message_with_http_info(id, opts = {})
      if @api_client.config.debugging
        @api_client.config.logger.debug 'Calling API: CourierApi.get_courier_message ...'
      end
      # verify the required parameter 'id' is set
      if @api_client.config.client_side_validation && id.nil?
        fail ArgumentError, "Missing the required parameter 'id' when calling CourierApi.get_courier_message"
      end
      # resource path
      local_var_path = '/admin/courier/messages/{id}'.sub('{' + 'id' + '}', CGI.escape(id.to_s))

      # query parameters
      query_params = opts[:query_params] || {}

      # header parameters
      header_params = opts[:header_params] || {}
      # HTTP header 'Accept' (if needed)
      header_params['Accept'] = @api_client.select_header_accept(['application/json'])

      # form parameters
      form_params = opts[:form_params] || {}

      # http body (model)
      post_body = opts[:debug_body]

      # return_type
      return_type = opts[:debug_return_type] || 'Message'

      # auth_names
      auth_names = opts[:debug_auth_names] || ['oryAccessToken']

      new_options = opts.merge(
        :operation => :"CourierApi.get_courier_message",
        :header_params => header_params,
        :query_params => query_params,
        :form_params => form_params,
        :body => post_body,
        :auth_names => auth_names,
        :return_type => return_type
      )

      data, status_code, headers = @api_client.call_api(:GET, local_var_path, new_options)
      if @api_client.config.debugging
        @api_client.config.logger.debug "API called: CourierApi#get_courier_message\nData: #{data.inspect}\nStatus code: #{status_code}\nHeaders: #{headers}"
      end
      return data, status_code, headers
    end

    # List Messages
    # Lists all messages by given status and recipient.
    # @param [Hash] opts the optional parameters
    # @option opts [Integer] :page_size Items per Page  This is the number of items per page to return. For details on pagination please head over to the [pagination documentation](https://www.ory.sh/docs/ecosystem/api-design#pagination). (default to 250)
    # @option opts [String] :page_token Next Page Token  The next page token. For details on pagination please head over to the [pagination documentation](https://www.ory.sh/docs/ecosystem/api-design#pagination).
    # @option opts [CourierMessageStatus] :status Status filters out messages based on status. If no value is provided, it doesn&#39;t take effect on filter.
    # @option opts [String] :recipient Recipient filters out messages based on recipient. If no value is provided, it doesn&#39;t take effect on filter.
    # @return [Array<Message>]
    def list_courier_messages(opts = {})
      data, _status_code, _headers = list_courier_messages_with_http_info(opts)
      data
    end

    # List Messages
    # Lists all messages by given status and recipient.
    # @param [Hash] opts the optional parameters
    # @option opts [Integer] :page_size Items per Page  This is the number of items per page to return. For details on pagination please head over to the [pagination documentation](https://www.ory.sh/docs/ecosystem/api-design#pagination). (default to 250)
    # @option opts [String] :page_token Next Page Token  The next page token. For details on pagination please head over to the [pagination documentation](https://www.ory.sh/docs/ecosystem/api-design#pagination).
    # @option opts [CourierMessageStatus] :status Status filters out messages based on status. If no value is provided, it doesn&#39;t take effect on filter.
    # @option opts [String] :recipient Recipient filters out messages based on recipient. If no value is provided, it doesn&#39;t take effect on filter.
    # @return [Array<(Array<Message>, Integer, Hash)>] Array<Message> data, response status code and response headers
    def list_courier_messages_with_http_info(opts = {})
      if @api_client.config.debugging
        @api_client.config.logger.debug 'Calling API: CourierApi.list_courier_messages ...'
      end
      if @api_client.config.client_side_validation && !opts[:'page_size'].nil? && opts[:'page_size'] > 1000
        fail ArgumentError, 'invalid value for "opts[:"page_size"]" when calling CourierApi.list_courier_messages, must be smaller than or equal to 1000.'
      end

      if @api_client.config.client_side_validation && !opts[:'page_size'].nil? && opts[:'page_size'] < 1
        fail ArgumentError, 'invalid value for "opts[:"page_size"]" when calling CourierApi.list_courier_messages, must be greater than or equal to 1.'
      end

      # resource path
      local_var_path = '/admin/courier/messages'

      # query parameters
      query_params = opts[:query_params] || {}
      query_params[:'page_size'] = opts[:'page_size'] if !opts[:'page_size'].nil?
      query_params[:'page_token'] = opts[:'page_token'] if !opts[:'page_token'].nil?
      query_params[:'status'] = opts[:'status'] if !opts[:'status'].nil?
      query_params[:'recipient'] = opts[:'recipient'] if !opts[:'recipient'].nil?

      # header parameters
      header_params = opts[:header_params] || {}
      # HTTP header 'Accept' (if needed)
      header_params['Accept'] = @api_client.select_header_accept(['application/json'])

      # form parameters
      form_params = opts[:form_params] || {}

      # http body (model)
      post_body = opts[:debug_body]

      # return_type
      return_type = opts[:debug_return_type] || 'Array<Message>'

      # auth_names
      auth_names = opts[:debug_auth_names] || ['oryAccessToken']

      new_options = opts.merge(
        :operation => :"CourierApi.list_courier_messages",
        :header_params => header_params,
        :query_params => query_params,
        :form_params => form_params,
        :body => post_body,
        :auth_names => auth_names,
        :return_type => return_type
      )

      data, status_code, headers = @api_client.call_api(:GET, local_var_path, new_options)
      if @api_client.config.debugging
        @api_client.config.logger.debug "API called: CourierApi#list_courier_messages\nData: #{data.inspect}\nStatus code: #{status_code}\nHeaders: #{headers}"
      end
      return data, status_code, headers
    end
  end
end
