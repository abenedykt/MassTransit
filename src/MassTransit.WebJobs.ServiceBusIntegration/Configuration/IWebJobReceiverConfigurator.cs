﻿// Copyright 2007-2018 Chris Patterson, Dru Sellers, Travis Smith, et. al.
//  
// Licensed under the Apache License, Version 2.0 (the "License"); you may not use
// this file except in compliance with the License. You may obtain a copy of the 
// License at 
// 
//     http://www.apache.org/licenses/LICENSE-2.0 
// 
// Unless required by applicable law or agreed to in writing, software distributed
// under the License is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR 
// CONDITIONS OF ANY KIND, either express or implied. See the License for the 
// specific language governing permissions and limitations under the License.
namespace MassTransit.WebJobs.ServiceBusIntegration.Configuration
{
    using System.Threading;
    using AzureServiceBusTransport.Configurators;
    using GreenPipes;
    using Microsoft.Azure.WebJobs.Host;


    public interface IWebJobReceiverConfigurator :
        IReceiverConfigurator
    {
        CancellationToken CancellationToken { set; }

        /// <summary>
        /// Set the log for the receiver
        /// </summary>
        /// <param name="traceWriter"></param>
        void SetLog(TraceWriter traceWriter);
    }


    public interface IWebJobHandlerFactory :
        ISpecification
    {
    }
}