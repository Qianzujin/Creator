﻿using System;
using System.ComponentModel.DataAnnotations;

namespace Creator.JobSchedule
{
    public class CreateUpdateJobInfoDto
    {
        [Required, StringLength(128)]
        public string JobGroup { get; set; }

        [Required, StringLength(64)]
        public string JobDescription { get; set; }

        [Required, StringLength(64)]
        public string JobName { get; set; }

        [Required, StringLength(256)]
        public string JobAssemblyName { get; set; }

        [Required, StringLength(256)]
        public string JobNamespace { get; set; }

        [Required, StringLength(128)]
        public string JobClassName { get; set; }

        [Required]
        public JobStatu JobStatus { get; set; } = JobStatu.Stopped;

        [Required, StringLength(64)]
        public string CronExpress { get; set; }

        public DateTime StarTime { get; set; }

        public DateTime EndTime { get; set; }

        public DateTime NextTime { get; set; }
    }
}