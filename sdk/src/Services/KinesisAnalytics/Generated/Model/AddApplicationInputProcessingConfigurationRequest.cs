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

/*
 * Do not modify this file. This file is generated from the kinesisanalytics-2015-08-14.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.KinesisAnalytics.Model
{
    /// <summary>
    /// Container for the parameters to the AddApplicationInputProcessingConfiguration operation.
    /// Adds an <a>InputProcessingConfiguration</a> to an application. An input processor
    /// preprocesses records on the input stream before the application's SQL code executes.
    /// Currently, the only input processor available is <a href="https://aws.amazon.com/documentation/lambda/">AWS
    /// Lambda</a>.
    /// </summary>
    public partial class AddApplicationInputProcessingConfigurationRequest : AmazonKinesisAnalyticsRequest
    {
        private string _applicationName;
        private long? _currentApplicationVersionId;
        private string _inputId;
        private InputProcessingConfiguration _inputProcessingConfiguration;

        /// <summary>
        /// Gets and sets the property ApplicationName. 
        /// <para>
        /// Name of the application to which you want to add the input processing configuration.
        /// </para>
        /// </summary>
        public string ApplicationName
        {
            get { return this._applicationName; }
            set { this._applicationName = value; }
        }

        // Check to see if ApplicationName property is set
        internal bool IsSetApplicationName()
        {
            return this._applicationName != null;
        }

        /// <summary>
        /// Gets and sets the property CurrentApplicationVersionId. 
        /// <para>
        /// Version of the application to which you want to add the input processing configuration.
        /// You can use the <a>DescribeApplication</a> operation to get the current application
        /// version. If the version specified is not the current version, the <code>ConcurrentModificationException</code>
        /// is returned.
        /// </para>
        /// </summary>
        public long CurrentApplicationVersionId
        {
            get { return this._currentApplicationVersionId.GetValueOrDefault(); }
            set { this._currentApplicationVersionId = value; }
        }

        // Check to see if CurrentApplicationVersionId property is set
        internal bool IsSetCurrentApplicationVersionId()
        {
            return this._currentApplicationVersionId.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property InputId. 
        /// <para>
        /// The ID of the input configuration to add the input processing configuration to. You
        /// can get a list of the input IDs for an application using the <a>DescribeApplication</a>
        /// operation.
        /// </para>
        /// </summary>
        public string InputId
        {
            get { return this._inputId; }
            set { this._inputId = value; }
        }

        // Check to see if InputId property is set
        internal bool IsSetInputId()
        {
            return this._inputId != null;
        }

        /// <summary>
        /// Gets and sets the property InputProcessingConfiguration. 
        /// <para>
        /// The <a>InputProcessingConfiguration</a> to add to the application.
        /// </para>
        /// </summary>
        public InputProcessingConfiguration InputProcessingConfiguration
        {
            get { return this._inputProcessingConfiguration; }
            set { this._inputProcessingConfiguration = value; }
        }

        // Check to see if InputProcessingConfiguration property is set
        internal bool IsSetInputProcessingConfiguration()
        {
            return this._inputProcessingConfiguration != null;
        }

    }
}