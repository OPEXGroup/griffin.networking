﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;

namespace Griffin.Networking.Messages
{
    /// <summary>
    /// bind socket for a server channel
    /// </summary>
    public class BindSocket : IPipelineMessage
    {
        private readonly IPEndPoint _endPoint;

        /// <summary>
        /// Initializes a new instance of the <see cref="BindSocket"/> class.
        /// </summary>
        /// <param name="endPoint">The end point.</param>
        public BindSocket(IPEndPoint endPoint)
        {
            _endPoint = endPoint;
        }

        /// <summary>
        /// Gets enpoint to bind
        /// </summary>
        public IPEndPoint EndPoint
        {
            get {
                return _endPoint;
            }
        }
    }
}
