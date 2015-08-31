using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace quartz
{
    public interface IScheduledJob
    {
        void Run();
    }
}
