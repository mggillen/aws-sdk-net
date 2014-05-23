/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.OpsWorks.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteInstance operation.
    /// Deletes a specified instance. You must stop an instance before you can delete it.
    /// For more information, see  <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/workinginstances-delete.html">Deleting
    /// Instances</a>.
    /// 
    ///     
    /// <para>
    /// <b>Required Permissions</b>: To use this action, an IAM user must have a Manage permissions
    /// level for the stack, or an attached       policy that explicitly grants permissions.
    /// For more information on user permissions, see      <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/opsworks-security-users.html">Managing
    /// User Permissions</a>.
    /// </para>
    /// </summary>
    public partial class DeleteInstanceRequest : AmazonWebServiceRequest
    {
        private bool? _deleteElasticIp;
        private bool? _deleteVolumes;
        private string _instanceId;


        /// <summary>
        /// Gets and sets the property DeleteElasticIp. 
        /// <para>
        /// Whether to delete the instance Elastic IP address.
        /// </para>
        /// </summary>
        public bool DeleteElasticIp
        {
            get { return this._deleteElasticIp.GetValueOrDefault(); }
            set { this._deleteElasticIp = value; }
        }


        /// <summary>
        /// Sets the DeleteElasticIp property
        /// </summary>
        /// <param name="deleteElasticIp">The value to set for the DeleteElasticIp property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DeleteInstanceRequest WithDeleteElasticIp(bool deleteElasticIp)
        {
            this._deleteElasticIp = deleteElasticIp;
            return this;
        }

        // Check to see if DeleteElasticIp property is set
        internal bool IsSetDeleteElasticIp()
        {
            return this._deleteElasticIp.HasValue; 
        }


        /// <summary>
        /// Gets and sets the property DeleteVolumes. 
        /// <para>
        /// Whether to delete the instance's Amazon EBS volumes.
        /// </para>
        /// </summary>
        public bool DeleteVolumes
        {
            get { return this._deleteVolumes.GetValueOrDefault(); }
            set { this._deleteVolumes = value; }
        }


        /// <summary>
        /// Sets the DeleteVolumes property
        /// </summary>
        /// <param name="deleteVolumes">The value to set for the DeleteVolumes property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DeleteInstanceRequest WithDeleteVolumes(bool deleteVolumes)
        {
            this._deleteVolumes = deleteVolumes;
            return this;
        }

        // Check to see if DeleteVolumes property is set
        internal bool IsSetDeleteVolumes()
        {
            return this._deleteVolumes.HasValue; 
        }


        /// <summary>
        /// Gets and sets the property InstanceId. 
        /// <para>
        /// The instance ID.
        /// </para>
        /// </summary>
        public string InstanceId
        {
            get { return this._instanceId; }
            set { this._instanceId = value; }
        }


        /// <summary>
        /// Sets the InstanceId property
        /// </summary>
        /// <param name="instanceId">The value to set for the InstanceId property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DeleteInstanceRequest WithInstanceId(string instanceId)
        {
            this._instanceId = instanceId;
            return this;
        }

        // Check to see if InstanceId property is set
        internal bool IsSetInstanceId()
        {
            return this._instanceId != null;
        }

    }
}