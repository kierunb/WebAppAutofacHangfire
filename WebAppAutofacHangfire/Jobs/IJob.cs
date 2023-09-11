using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAppAutofacHangfire.Jobs
{
    public interface IJob
    {
        void Execute();
    }
}
