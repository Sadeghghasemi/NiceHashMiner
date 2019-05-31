﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NiceHashMiner.Miners.IntegratedPlugins
{
    public interface IMinerBinsSource
    {
        /// <summary>
        /// Return ordered urls where we can download miner binary files
        /// </summary>
        /// <returns></returns>
        IEnumerable<string> GetMinerBinsUrls();
    }
}
