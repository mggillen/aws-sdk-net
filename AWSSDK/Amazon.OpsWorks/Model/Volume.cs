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
    /// Describes an instance's Amazon EBS volume.
    /// </summary>
    public partial class Volume
    {
        private string _availabilityZone;
        private string _device;
        private string _ec2VolumeId;
        private string _instanceId;
        private int? _iops;
        private string _mountPoint;
        private string _name;
        private string _raidArrayId;
        private string _region;
        private int? _size;
        private string _status;
        private string _volumeId;
        private string _volumeType;


        /// <summary>
        /// Gets and sets the property AvailabilityZone. 
        /// <para>
        /// The volume Availability Zone. For more information, see  <a href="http://docs.aws.amazon.com/general/latest/gr/rande.html">Regions
        /// and Endpoints</a>.
        /// </para>
        /// </summary>
        public string AvailabilityZone
        {
            get { return this._availabilityZone; }
            set { this._availabilityZone = value; }
        }


        /// <summary>
        /// Sets the AvailabilityZone property
        /// </summary>
        /// <param name="availabilityZone">The value to set for the AvailabilityZone property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Volume WithAvailabilityZone(string availabilityZone)
        {
            this._availabilityZone = availabilityZone;
            return this;
        }

        // Check to see if AvailabilityZone property is set
        internal bool IsSetAvailabilityZone()
        {
            return this._availabilityZone != null;
        }


        /// <summary>
        /// Gets and sets the property Device. 
        /// <para>
        /// The device name.
        /// </para>
        /// </summary>
        public string Device
        {
            get { return this._device; }
            set { this._device = value; }
        }


        /// <summary>
        /// Sets the Device property
        /// </summary>
        /// <param name="device">The value to set for the Device property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Volume WithDevice(string device)
        {
            this._device = device;
            return this;
        }

        // Check to see if Device property is set
        internal bool IsSetDevice()
        {
            return this._device != null;
        }


        /// <summary>
        /// Gets and sets the property Ec2VolumeId. 
        /// <para>
        /// The Amazon EC2 volume ID.
        /// </para>
        /// </summary>
        public string Ec2VolumeId
        {
            get { return this._ec2VolumeId; }
            set { this._ec2VolumeId = value; }
        }


        /// <summary>
        /// Sets the Ec2VolumeId property
        /// </summary>
        /// <param name="ec2VolumeId">The value to set for the Ec2VolumeId property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Volume WithEc2VolumeId(string ec2VolumeId)
        {
            this._ec2VolumeId = ec2VolumeId;
            return this;
        }

        // Check to see if Ec2VolumeId property is set
        internal bool IsSetEc2VolumeId()
        {
            return this._ec2VolumeId != null;
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
        public Volume WithInstanceId(string instanceId)
        {
            this._instanceId = instanceId;
            return this;
        }

        // Check to see if InstanceId property is set
        internal bool IsSetInstanceId()
        {
            return this._instanceId != null;
        }


        /// <summary>
        /// Gets and sets the property Iops. 
        /// <para>
        /// For PIOPS volumes, the IOPS per disk.
        /// </para>
        /// </summary>
        public int Iops
        {
            get { return this._iops.GetValueOrDefault(); }
            set { this._iops = value; }
        }


        /// <summary>
        /// Sets the Iops property
        /// </summary>
        /// <param name="iops">The value to set for the Iops property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Volume WithIops(int iops)
        {
            this._iops = iops;
            return this;
        }

        // Check to see if Iops property is set
        internal bool IsSetIops()
        {
            return this._iops.HasValue; 
        }


        /// <summary>
        /// Gets and sets the property MountPoint. 
        /// <para>
        /// The volume mount point. For example "/dev/sdh".
        /// </para>
        /// </summary>
        public string MountPoint
        {
            get { return this._mountPoint; }
            set { this._mountPoint = value; }
        }


        /// <summary>
        /// Sets the MountPoint property
        /// </summary>
        /// <param name="mountPoint">The value to set for the MountPoint property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Volume WithMountPoint(string mountPoint)
        {
            this._mountPoint = mountPoint;
            return this;
        }

        // Check to see if MountPoint property is set
        internal bool IsSetMountPoint()
        {
            return this._mountPoint != null;
        }


        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The volume name.
        /// </para>
        /// </summary>
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }


        /// <summary>
        /// Sets the Name property
        /// </summary>
        /// <param name="name">The value to set for the Name property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Volume WithName(string name)
        {
            this._name = name;
            return this;
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }


        /// <summary>
        /// Gets and sets the property RaidArrayId. 
        /// <para>
        /// The RAID array ID.
        /// </para>
        /// </summary>
        public string RaidArrayId
        {
            get { return this._raidArrayId; }
            set { this._raidArrayId = value; }
        }


        /// <summary>
        /// Sets the RaidArrayId property
        /// </summary>
        /// <param name="raidArrayId">The value to set for the RaidArrayId property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Volume WithRaidArrayId(string raidArrayId)
        {
            this._raidArrayId = raidArrayId;
            return this;
        }

        // Check to see if RaidArrayId property is set
        internal bool IsSetRaidArrayId()
        {
            return this._raidArrayId != null;
        }


        /// <summary>
        /// Gets and sets the property Region. 
        /// <para>
        /// The AWS region. For more information about AWS regions, see  <a href="http://docs.aws.amazon.com/general/latest/gr/rande.html">Regions
        /// and Endpoints</a>.
        /// </para>
        /// </summary>
        public string Region
        {
            get { return this._region; }
            set { this._region = value; }
        }


        /// <summary>
        /// Sets the Region property
        /// </summary>
        /// <param name="region">The value to set for the Region property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Volume WithRegion(string region)
        {
            this._region = region;
            return this;
        }

        // Check to see if Region property is set
        internal bool IsSetRegion()
        {
            return this._region != null;
        }


        /// <summary>
        /// Gets and sets the property Size. 
        /// <para>
        /// The volume size.
        /// </para>
        /// </summary>
        public int Size
        {
            get { return this._size.GetValueOrDefault(); }
            set { this._size = value; }
        }


        /// <summary>
        /// Sets the Size property
        /// </summary>
        /// <param name="size">The value to set for the Size property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Volume WithSize(int size)
        {
            this._size = size;
            return this;
        }

        // Check to see if Size property is set
        internal bool IsSetSize()
        {
            return this._size.HasValue; 
        }


        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The value returned by  <a href="http://docs.aws.amazon.com/AWSEC2/latest/APIReference/ApiReference-query-DescribeVolumes.html">DescribeVolumes</a>.
        /// </para>
        /// </summary>
        public string Status
        {
            get { return this._status; }
            set { this._status = value; }
        }


        /// <summary>
        /// Sets the Status property
        /// </summary>
        /// <param name="status">The value to set for the Status property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Volume WithStatus(string status)
        {
            this._status = status;
            return this;
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }


        /// <summary>
        /// Gets and sets the property VolumeId. 
        /// <para>
        /// The volume ID.
        /// </para>
        /// </summary>
        public string VolumeId
        {
            get { return this._volumeId; }
            set { this._volumeId = value; }
        }


        /// <summary>
        /// Sets the VolumeId property
        /// </summary>
        /// <param name="volumeId">The value to set for the VolumeId property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Volume WithVolumeId(string volumeId)
        {
            this._volumeId = volumeId;
            return this;
        }

        // Check to see if VolumeId property is set
        internal bool IsSetVolumeId()
        {
            return this._volumeId != null;
        }


        /// <summary>
        /// Gets and sets the property VolumeType. 
        /// <para>
        /// The volume type, standard or PIOPS.
        /// </para>
        /// </summary>
        public string VolumeType
        {
            get { return this._volumeType; }
            set { this._volumeType = value; }
        }


        /// <summary>
        /// Sets the VolumeType property
        /// </summary>
        /// <param name="volumeType">The value to set for the VolumeType property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Volume WithVolumeType(string volumeType)
        {
            this._volumeType = volumeType;
            return this;
        }

        // Check to see if VolumeType property is set
        internal bool IsSetVolumeType()
        {
            return this._volumeType != null;
        }

    }
}