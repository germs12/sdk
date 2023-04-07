=begin
#Ory Hydra API

#Documentation for all of Ory Hydra's APIs. 

The version of the OpenAPI document: v2.1.0
Contact: hi@ory.sh
Generated by: https://openapi-generator.tech
OpenAPI Generator version: 6.0.1

=end

require 'spec_helper'
require 'json'

# Unit tests for OryHydraClient::WellknownApi
# Automatically generated by openapi-generator (https://openapi-generator.tech)
# Please update as you see appropriate
describe 'WellknownApi' do
  before do
    # run before each test
    @api_instance = OryHydraClient::WellknownApi.new
  end

  after do
    # run after each test
  end

  describe 'test an instance of WellknownApi' do
    it 'should create an instance of WellknownApi' do
      expect(@api_instance).to be_instance_of(OryHydraClient::WellknownApi)
    end
  end

  # unit tests for discover_json_web_keys
  # Discover Well-Known JSON Web Keys
  # This endpoint returns JSON Web Keys required to verifying OpenID Connect ID Tokens and, if enabled, OAuth 2.0 JWT Access Tokens. This endpoint can be used with client libraries like [node-jwks-rsa](https://github.com/auth0/node-jwks-rsa) among others.
  # @param [Hash] opts the optional parameters
  # @return [JsonWebKeySet]
  describe 'discover_json_web_keys test' do
    it 'should work' do
      # assertion here. ref: https://www.relishapp.com/rspec/rspec-expectations/docs/built-in-matchers
    end
  end

end
