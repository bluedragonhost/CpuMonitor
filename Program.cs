using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Threading;

namespace CPUMonitor
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			#region GrabCpuCounters
			//Pull the current cpu usage in percentage
			PerformanceCounter perfCpuCount = new PerformanceCounter("Processor Information", "% Processor Time", "_Total");       
			perfCpuCount.NextValue();
			#endregion
			//infinite while loop
			while (true) {
				// Get the current preformance counter values
				int currentCpuPercentage = (int)perfCpuCount.NextValue ();

				// Every 1 second print the cpu usage in a percentage to the screen
				Console.WriteLine ("CPU Load : {0}%", currentCpuPercentage);
				Thread.Sleep (1000); 

			}
		}
	}
}
