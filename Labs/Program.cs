using Labs.GcdLab;
using Labs.MillerRabinLab;
using Labs.PowLab;
using Labs.RsaBreakingLab;
using Labs.RsaLab;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Labs
{
	internal static class Program
	{
		/// <summary>
		///  The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.SetHighDpiMode(HighDpiMode.SystemAware);
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);

			Application.Run(new RsaBreakingForm());
			//Application.Run(new RsaForm());
			//Application.Run(new PowForm());
			//Application.Run(new GcdForm());
			//Application.Run(new MillerRabinForm());
		}
	}
}
