﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternetToolsV6.Networking.Ping
{
    public interface IPing
    {
        PingDataStructure SendICMPPing(string Address, int Timeout);
        PingDataStructure SendTCPPing(string Address, int Timeout);
        PingDataStructure SendUDPPing(string Address, int Timeout);
        PingDataStructure SendARPPing(string Address, int Timeout);
    }
}
