﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Taskling.ExecutionContext;
using Taskling.InfrastructureContracts.TaskExecution;

namespace Taskling.InfrastructureContracts.CriticalSections
{
    public class StartCriticalSectionRequest : RequestBase
    {
        public StartCriticalSectionRequest(string applicationName, 
            string taskName,
            int taskExecutionId, 
            TaskDeathMode taskDeathMode)
            :base(applicationName, taskName, taskExecutionId)
        {
            TaskDeathMode = taskDeathMode;
        }

        public TaskDeathMode TaskDeathMode { get; set; }
        public int? SecondsOverride { get; set; }
        public int? KeepAliveElapsedSeconds { get; set; }
    }
}