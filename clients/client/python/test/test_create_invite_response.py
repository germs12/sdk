"""
    Ory APIs

    Documentation for all public and administrative Ory APIs. Administrative APIs can only be accessed with a valid Personal Access Token. Public APIs are mostly used in browsers.   # noqa: E501

    The version of the OpenAPI document: v1.4.2
    Contact: support@ory.sh
    Generated by: https://openapi-generator.tech
"""


import sys
import unittest

import ory_client
from ory_client.model.member_invite import MemberInvite
globals()['MemberInvite'] = MemberInvite
from ory_client.model.create_invite_response import CreateInviteResponse


class TestCreateInviteResponse(unittest.TestCase):
    """CreateInviteResponse unit test stubs"""

    def setUp(self):
        pass

    def tearDown(self):
        pass

    def testCreateInviteResponse(self):
        """Test CreateInviteResponse"""
        # FIXME: construct object with mandatory attributes with example values
        # model = CreateInviteResponse()  # noqa: E501
        pass


if __name__ == '__main__':
    unittest.main()
