using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;

namespace WebAppAutofacHangfire.Jobs
{
    public class SimpleJob : IJob
    {
        public void Execute()
        {
            Debug.WriteLine("Hello world from Hangfire!");
        }
    }
}