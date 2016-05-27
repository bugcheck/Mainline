/*
 *  Licensed to the Apache Software Foundation (ASF) under one or more
 *  contributor license agreements.  See the NOTICE file distributed with
 *  this work for additional information regarding copyright ownership.
 *  The ASF licenses this file to You under the Apache License, Version 2.0
 *  (the "License"); you may not use this file except in compliance with
 *  the License.  You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 *  Unless required by applicable law or agreed to in writing, software
 *  distributed under the License is distributed on an "AS IS" BASIS,
 *  WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 *  See the License for the specific language governing permissions and
 *  limitations under the License.
 *
 */
﻿namespace ZooKeeperNet
{
    public enum OpCode
    {
        Notification = 0,
        Create = 1,
        Delete = 2,
        Exists = 3,
        GetData = 4,
        SetData = 5,
        GetACL = 6,
        SetACL = 7,
        GetChildren = 8,
        Sync = 9,
        Ping = 11,
        GetChildren2 = 12,
        //added by Yang Li at Feb.29th, 2016
        GetRemark = 13,
        //added by Yang Li at Feb.29th, 2016
        SetRemark = 14,
        Auth = 100,
        SetWatches = 101,
        CreateSession = -10,
        CloseSession = -11,
        Error = -1,    
    }
}
