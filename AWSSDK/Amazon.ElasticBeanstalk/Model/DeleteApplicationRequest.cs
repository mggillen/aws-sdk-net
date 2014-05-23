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

namespace Amazon.ElasticBeanstalk.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteApplication operation.
    /// Deletes the specified application along with all         associated versions
    /// and         configurations. The application versions will not be deleted from your
    /// Amazon S3 bucket.      
    /// 
    ///       <note>You cannot delete an application that has a running environment.     
    /// </note>
    /// </summary>
    public partial class DeleteApplicationRequest : AmazonWebServiceRequest
    {
        private string _applicationName;
        private bool? _terminateEnvByForce;


        /// <summary>
        /// Gets and sets the property ApplicationName. 
        /// <para>
        /// The name of the application to delete.
        /// </para>
        /// </summary>
        public string ApplicationName
        {
            get { return this._applicationName; }
            set { this._applicationName = value; }
        }


        /// <summary>
        /// Sets the ApplicationName property
        /// </summary>
        /// <param name="applicationName">The value to set for the ApplicationName property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DeleteApplicationRequest WithApplicationName(string applicationName)
        {
            this._applicationName = applicationName;
            return this;
        }

        // Check to see if ApplicationName property is set
        internal bool IsSetApplicationName()
        {
            return this._applicationName != null;
        }


        /// <summary>
        /// Gets and sets the property TerminateEnvByForce. 
        /// <para>
        /// When set to true, running environments will be terminated before deleting the application.
        /// </para>
        /// </summary>
        public bool TerminateEnvByForce
        {
            get { return this._terminateEnvByForce.GetValueOrDefault(); }
            set { this._terminateEnvByForce = value; }
        }


        /// <summary>
        /// Sets the TerminateEnvByForce property
        /// </summary>
        /// <param name="terminateEnvByForce">The value to set for the TerminateEnvByForce property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DeleteApplicationRequest WithTerminateEnvByForce(bool terminateEnvByForce)
        {
            this._terminateEnvByForce = terminateEnvByForce;
            return this;
        }

        // Check to see if TerminateEnvByForce property is set
        internal bool IsSetTerminateEnvByForce()
        {
            return this._terminateEnvByForce.HasValue; 
        }

    }
}