Feature: Default Creation
	In order to access RestSharp's injection services in the normal way
	As a RESTful API consumer
	I want to be able to create default instances of RestSharp's services

Background:
	Given I have a default RestSharp service factory

Scenario: Create Default Client
	When I create a client with the URL "http://test.com/api"
	Then my client should be the default client type
	And my client's URL should be "http://test.com/api"

Scenario Outline: Create Default Request
	When I create a request with a specific <method> and <resource>
	Then my request should be the default request type
	And my request's method should be <method>
	And my request's resource should be <resource>
Examples:
	| method | resource |
	| GET    | data     |
	| PUT    | data     |
	| POST   | data     |
	| DELETE | data     |