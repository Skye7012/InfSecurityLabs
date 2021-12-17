using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Labs.Service
{
	public class MyTimer : IDisposable
	{
		public DateTime BeginTime { get; }
		//public TimeSpan Past { get; set; }
		//public DateTime EndTime { get; set; }
		public MyTimer()
		{
			BeginTime = DateTime.Now;
		}
		public void Dispose()
		{
			var past = DateTime.Now - BeginTime;
			Debug.WriteLine($"Executing Time =  {past}");
		}

		public TimeSpan GetPast()
			=> DateTime.Now - BeginTime;
	}
}
