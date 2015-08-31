using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace quartz
{
    //tutorial url
    //http://geekswithblogs.net/TarunArora/archive/2012/11/17/quartz.net-writing-your-first-hello-world-job.aspx
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
             // Infinite loop, so that the console doesn't close on you
                while (true)
                {
                    var sj = new ScheduledJob();
                    sj.Run();

                    Console.WriteLine(@"{0}Check Quartz.net\Trace\application.log.txt for Job updates{0}",
                                        Environment.NewLine);

                    Console.WriteLine("{0}Press Ctrl^C to close the window. The job will continue " +
                                        "to run via Quartz.Net windows service, " +
                                        "see job activity in the Quartz.Net Trace file...{0}",
                                        Environment.NewLine);

                    Thread.Sleep(10000 * 100000);    
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Failed: {0}", ex.Message);
                Console.ReadKey();
            }
        }
    }
}
