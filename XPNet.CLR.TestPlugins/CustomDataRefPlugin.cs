using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace XPNet.CLR.TestPlugins
{
	[XPlanePlugin(nameof(CustomDataRefPlugin), "xpnet.plugins.test." + nameof(CustomDataRefPlugin), description: "custom dataref test plugin")]
	public class CustomDataRefPlugin : TestPluginBase
	{
		public CustomDataRefPlugin(IXPlaneApi api) : base(api) { }

		public override void Enable()
		{
			var dr2 = Api.Data.GetInt(TestData.Name("cdr/test2"));

			Api.Data.RegisterDataAccessor(TestData.Name("cdr/test1"),
				getDatai: () => 3, setDatai: (value) => dr2.Value = value + 4 );

			var dr1 = Api.Data.GetInt(TestData.Name("cdr/test1"));
		}
	}
}
