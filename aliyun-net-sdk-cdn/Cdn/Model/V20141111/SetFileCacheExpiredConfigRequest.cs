/*
 * Licensed to the Apache Software Foundation (ASF) under one
 * or more contributor license agreements.  See the NOTICE file
 * distributed with this work for additional information
 * regarding copyright ownership.  The ASF licenses this file
 * to you under the Apache License, Version 2.0 (the
 * "License"); you may not use this file except in compliance
 * with the License.  You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */
using Aliyun.Acs.Core;
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.Cdn.Transform;
using Aliyun.Acs.Cdn.Transform.V20141111;
using System.Collections.Generic;

namespace Aliyun.Acs.Cdn.Model.V20141111
{
    public class SetFileCacheExpiredConfigRequest : RpcAcsRequest<SetFileCacheExpiredConfigResponse>
    {
        public SetFileCacheExpiredConfigRequest()
            : base("Cdn", "2014-11-11", "SetFileCacheExpiredConfig")
        {
        }

		private string securityToken;

		private string domainName;

		private string action;

		private string weight;

		private string cacheContent;

		private long? ownerId;

		private string tTL;

		public string SecurityToken
		{
			get
			{
				return securityToken;
			}
			set	
			{
				securityToken = value;
				DictionaryUtil.Add(QueryParameters, "SecurityToken", value);
			}
		}

		public string DomainName
		{
			get
			{
				return domainName;
			}
			set	
			{
				domainName = value;
				DictionaryUtil.Add(QueryParameters, "DomainName", value);
			}
		}

		public string Action
		{
			get
			{
				return action;
			}
			set	
			{
				action = value;
				DictionaryUtil.Add(QueryParameters, "Action", value);
			}
		}

		public string Weight
		{
			get
			{
				return weight;
			}
			set	
			{
				weight = value;
				DictionaryUtil.Add(QueryParameters, "Weight", value);
			}
		}

		public string CacheContent
		{
			get
			{
				return cacheContent;
			}
			set	
			{
				cacheContent = value;
				DictionaryUtil.Add(QueryParameters, "CacheContent", value);
			}
		}

		public long? OwnerId
		{
			get
			{
				return ownerId;
			}
			set	
			{
				ownerId = value;
				DictionaryUtil.Add(QueryParameters, "OwnerId", value.ToString());
			}
		}

		public string TTL
		{
			get
			{
				return tTL;
			}
			set	
			{
				tTL = value;
				DictionaryUtil.Add(QueryParameters, "TTL", value);
			}
		}

        public override SetFileCacheExpiredConfigResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return SetFileCacheExpiredConfigResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}