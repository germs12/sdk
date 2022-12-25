"""
    Ory APIs

    Documentation for all public and administrative Ory APIs. Administrative APIs can only be accessed with a valid Personal Access Token. Public APIs are mostly used in browsers.   # noqa: E501

    The version of the OpenAPI document: v1.1.4
    Contact: support@ory.sh
    Generated by: https://openapi-generator.tech
"""


import sys
import unittest

import ory_client
from ory_client.model.o_auth2_client import OAuth2Client
globals()['OAuth2Client'] = OAuth2Client
from ory_client.model.o_auth2_logout_request import OAuth2LogoutRequest


class TestOAuth2LogoutRequest(unittest.TestCase):
    """OAuth2LogoutRequest unit test stubs"""

    def setUp(self):
        pass

    def tearDown(self):
        pass

    def testOAuth2LogoutRequest(self):
        """Test OAuth2LogoutRequest"""
        # FIXME: construct object with mandatory attributes with example values
        # model = OAuth2LogoutRequest()  # noqa: E501
        pass


if __name__ == '__main__':
    unittest.main()
