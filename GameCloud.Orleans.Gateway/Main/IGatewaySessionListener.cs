﻿// Copyright (c) Cragon. All rights reserved.

namespace GameCloud.Orleans.Gateway
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using global::Orleans;

    public abstract class IGatewaySessionListener
    {
        public GatewaySession GatewaySession { get; set; }

        public abstract Task OnSessionCreate(string client_ip);

        public abstract Task OnSessionDestroy();

        public abstract Task Unity2Orleans(ushort method_id, byte[] data);

        public abstract Task Orleans2Unity(ushort method_id, byte[] data);
    }
}
