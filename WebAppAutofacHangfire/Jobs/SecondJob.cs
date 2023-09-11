using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using WebAppAutofacHangfire.Services;

namespace WebAppAutofacHangfire.Jobs
{
    public class SecondJob : IJob
    {
        private readonly JobService _jobService;

        public SecondJob(JobService jobService)
        {
            _jobService = jobService;
        }

        public void Execute()
        {
            Debug.WriteLine("Hello world from SecondJob!");
            Debug.WriteLine($"From injected object {_jobService.JobTest()}");
        }
    }
}