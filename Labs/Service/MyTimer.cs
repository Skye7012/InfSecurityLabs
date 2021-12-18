using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Labs.Service
{
	public class MyTimer : IDisposable
	{
		public DateTime BeginTime { get; }
		public MyTimer()
		{
			BeginTime = DateTime.Now;
			Debug.WriteLine($"Begining Time:\t{BeginTime}");
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
