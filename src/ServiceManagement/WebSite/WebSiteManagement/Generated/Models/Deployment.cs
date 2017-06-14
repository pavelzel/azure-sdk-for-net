// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Linq;
using Microsoft.WindowsAzure.WebSitesExtensions.Models;

namespace Microsoft.WindowsAzure.WebSitesExtensions.Models
{
    /// <summary>
    /// Describes a deployment.
    /// </summary>
    public partial class Deployment
    {
        private bool _active;
        
        /// <summary>
        /// Optional. Indicates if the deployment is active.
        /// </summary>
        public bool Active
        {
            get { return this._active; }
            set { this._active = value; }
        }
        
        private string _author;
        
        /// <summary>
        /// Optional. The author.
        /// </summary>
        public string Author
        {
            get { return this._author; }
            set { this._author = value; }
        }
        
        private string _authorEmail;
        
        /// <summary>
        /// Optional. The author's email.
        /// </summary>
        public string AuthorEmail
        {
            get { return this._authorEmail; }
            set { this._authorEmail = value; }
        }
        
        private bool _complete;
        
        /// <summary>
        /// Optional. Indicates if the deployment is complete.
        /// </summary>
        public bool Complete
        {
            get { return this._complete; }
            set { this._complete = value; }
        }
        
        private string _deployer;
        
        /// <summary>
        /// Optional. The deployer.
        /// </summary>
        public string Deployer
        {
            get { return this._deployer; }
            set { this._deployer = value; }
        }
        
        private DateTime _endTime;
        
        /// <summary>
        /// Optional. The end time.
        /// </summary>
        public DateTime EndTime
        {
            get { return this._endTime; }
            set { this._endTime = value; }
        }
        
        private string _id;
        
        /// <summary>
        /// Optional. The identifier.
        /// </summary>
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }
        
        private bool _isReadOnly;
        
        /// <summary>
        /// Optional. Indicates if the deployment is read only.
        /// </summary>
        public bool IsReadOnly
        {
            get { return this._isReadOnly; }
            set { this._isReadOnly = value; }
        }
        
        private bool _isTemp;
        
        /// <summary>
        /// Optional. Indicates if the deployment is temporary.
        /// </summary>
        public bool IsTemp
        {
            get { return this._isTemp; }
            set { this._isTemp = value; }
        }
        
        private DateTime _lastSuccessEndTime;
        
        /// <summary>
        /// Optional. The last success end time.
        /// </summary>
        public DateTime LastSuccessEndTime
        {
            get { return this._lastSuccessEndTime; }
            set { this._lastSuccessEndTime = value; }
        }
        
        private Uri _logUrl;
        
        /// <summary>
        /// Optional. The deployment log URL.
        /// </summary>
        public Uri LogUrl
        {
            get { return this._logUrl; }
            set { this._logUrl = value; }
        }
        
        private string _message;
        
        /// <summary>
        /// Optional. The message.
        /// </summary>
        public string Message
        {
            get { return this._message; }
            set { this._message = value; }
        }
        
        private string _progress;
        
        /// <summary>
        /// Optional. The progress.
        /// </summary>
        public string Progress
        {
            get { return this._progress; }
            set { this._progress = value; }
        }
        
        private DateTime _receivedTime;
        
        /// <summary>
        /// Optional. The received time.
        /// </summary>
        public DateTime ReceivedTime
        {
            get { return this._receivedTime; }
            set { this._receivedTime = value; }
        }
        
        private string _siteName;
        
        /// <summary>
        /// Optional. The deployment site name.
        /// </summary>
        public string SiteName
        {
            get { return this._siteName; }
            set { this._siteName = value; }
        }
        
        private DateTime _startTime;
        
        /// <summary>
        /// Optional. The start time.
        /// </summary>
        public DateTime StartTime
        {
            get { return this._startTime; }
            set { this._startTime = value; }
        }
        
        private DeployStatus _status;
        
        /// <summary>
        /// Optional. The status.
        /// </summary>
        public DeployStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }
        
        private string _statusText;
        
        /// <summary>
        /// Optional. The status text.
        /// </summary>
        public string StatusText
        {
            get { return this._statusText; }
            set { this._statusText = value; }
        }
        
        private Uri _url;
        
        /// <summary>
        /// Optional. The deployment URL.
        /// </summary>
        public Uri Url
        {
            get { return this._url; }
            set { this._url = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the Deployment class.
        /// </summary>
        public Deployment()
        {
        }
    }
}