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
    /// Container for the parameters to the SetPermission operation.
    /// Specifies a user's permissions.  For more information, see  <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/workingsecurity.html">Security
    /// and Permissions</a>.
    /// 
    ///     
    /// <para>
    /// <b>Required Permissions</b>: To use this action, an IAM user must have a Manage permissions
    /// level for the stack, or an attached       policy that explicitly grants permissions.
    /// For more information on user permissions, see      <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/opsworks-security-users.html">Managing
    /// User Permissions</a>.
    /// </para>
    /// </summary>
    public partial class SetPermissionRequest : AmazonWebServiceRequest
    {
        private bool? _allowSsh;
        private bool? _allowSudo;
        private string _iamUserArn;
        private string _level;
        private string _stackId;


        /// <summary>
        /// Gets and sets the property AllowSsh. 
        /// <para>
        /// The user is allowed to use SSH to communicate with the instance.
        /// </para>
        /// </summary>
        public bool AllowSsh
        {
            get { return this._allowSsh.GetValueOrDefault(); }
            set { this._allowSsh = value; }
        }


        /// <summary>
        /// Sets the AllowSsh property
        /// </summary>
        /// <param name="allowSsh">The value to set for the AllowSsh property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public SetPermissionRequest WithAllowSsh(bool allowSsh)
        {
            this._allowSsh = allowSsh;
            return this;
        }

        // Check to see if AllowSsh property is set
        internal bool IsSetAllowSsh()
        {
            return this._allowSsh.HasValue; 
        }


        /// <summary>
        /// Gets and sets the property AllowSudo. 
        /// <para>
        /// The user is allowed to use <b>sudo</b> to elevate privileges.
        /// </para>
        /// </summary>
        public bool AllowSudo
        {
            get { return this._allowSudo.GetValueOrDefault(); }
            set { this._allowSudo = value; }
        }


        /// <summary>
        /// Sets the AllowSudo property
        /// </summary>
        /// <param name="allowSudo">The value to set for the AllowSudo property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public SetPermissionRequest WithAllowSudo(bool allowSudo)
        {
            this._allowSudo = allowSudo;
            return this;
        }

        // Check to see if AllowSudo property is set
        internal bool IsSetAllowSudo()
        {
            return this._allowSudo.HasValue; 
        }


        /// <summary>
        /// Gets and sets the property IamUserArn. 
        /// <para>
        /// The user's IAM ARN.
        /// </para>
        /// </summary>
        public string IamUserArn
        {
            get { return this._iamUserArn; }
            set { this._iamUserArn = value; }
        }


        /// <summary>
        /// Sets the IamUserArn property
        /// </summary>
        /// <param name="iamUserArn">The value to set for the IamUserArn property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public SetPermissionRequest WithIamUserArn(string iamUserArn)
        {
            this._iamUserArn = iamUserArn;
            return this;
        }

        // Check to see if IamUserArn property is set
        internal bool IsSetIamUserArn()
        {
            return this._iamUserArn != null;
        }


        /// <summary>
        /// Gets and sets the property Level. 
        /// <para>
        /// The user's permission level, which must be set to one of the following strings. You
        /// cannot set your own permissions level.
        /// </para>
        ///   <ul>    <li><code>deny</code></li>    <li><code>show</code></li>    <li><code>deploy</code></li>
        ///    <li><code>manage</code></li>    <li><code>iam_only</code></li>  </ul>  
        /// <para>
        /// For more information on the permissions associated with these levels, see    <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/opsworks-security-users.html">Managing
        /// User Permissions</a>
        /// </para>
        /// </summary>
        public string Level
        {
            get { return this._level; }
            set { this._level = value; }
        }


        /// <summary>
        /// Sets the Level property
        /// </summary>
        /// <param name="level">The value to set for the Level property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public SetPermissionRequest WithLevel(string level)
        {
            this._level = level;
            return this;
        }

        // Check to see if Level property is set
        internal bool IsSetLevel()
        {
            return this._level != null;
        }


        /// <summary>
        /// Gets and sets the property StackId. 
        /// <para>
        /// The stack ID.
        /// </para>
        /// </summary>
        public string StackId
        {
            get { return this._stackId; }
            set { this._stackId = value; }
        }


        /// <summary>
        /// Sets the StackId property
        /// </summary>
        /// <param name="stackId">The value to set for the StackId property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public SetPermissionRequest WithStackId(string stackId)
        {
            this._stackId = stackId;
            return this;
        }

        // Check to see if StackId property is set
        internal bool IsSetStackId()
        {
            return this._stackId != null;
        }

    }
}