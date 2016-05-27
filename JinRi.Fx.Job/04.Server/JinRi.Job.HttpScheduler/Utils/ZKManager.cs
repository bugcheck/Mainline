﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JinRi.Job.HttpScheduler.Utils
{
    public class ZKManager
    {
        private static MasterElectionClient client;

        public static MasterElectionClient Client
        {
            get
            {
                if (client == null)
                {
                    client = new MasterElectionClient();
                }
                return ZKManager.client;
            }
        }
    }
}
