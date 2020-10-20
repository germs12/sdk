# coding: utf-8

"""
    Ory Kratos

    Welcome to the ORY Kratos HTTP API documentation!  # noqa: E501

    The version of the OpenAPI document: v0.5.0-alpha.1
    Generated by: https://openapi-generator.tech
"""


from __future__ import absolute_import

import unittest
import datetime

import ory_kratos_client
from ory_kratos_client.models.create_recovery_link import CreateRecoveryLink  # noqa: E501
from ory_kratos_client.rest import ApiException

class TestCreateRecoveryLink(unittest.TestCase):
    """CreateRecoveryLink unit test stubs"""

    def setUp(self):
        pass

    def tearDown(self):
        pass

    def make_instance(self, include_optional):
        """Test CreateRecoveryLink
            include_option is a boolean, when False only required
            params are included, when True both required and
            optional params are included """
        # model = ory_kratos_client.models.create_recovery_link.CreateRecoveryLink()  # noqa: E501
        if include_optional :
            return CreateRecoveryLink(
                expires_in = 'a', 
                identity_id = '0'
            )
        else :
            return CreateRecoveryLink(
                identity_id = '0',
        )

    def testCreateRecoveryLink(self):
        """Test CreateRecoveryLink"""
        inst_req_only = self.make_instance(include_optional=False)
        inst_req_and_optional = self.make_instance(include_optional=True)


if __name__ == '__main__':
    unittest.main()