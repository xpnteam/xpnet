
using System.Linq;

namespace XPNet.CLR.TestPlugins
{
    [XPlanePlugin(nameof(StringAdderPlugin), "xpnet.plugins.test." + nameof(StringAdderPlugin), description: "unit test plugin")]
    public class StringAdderPlugin : TestPluginBase
    {
        public StringAdderPlugin(IXPlaneApi api) : base(api) { }

        public override void Enable()
        {
			System.Diagnostics.Debugger.Launch();
            var dr1 = Api.Data.GetString(TestData.Name("dr/addstring/lhs"));
            var dr2 = Api.Data.GetString(TestData.Name("dr/addstring/rhs"));
            var ans = Api.Data.GetString(TestData.Name("dr/addstring/res"));

            ans.Value = dr1.Value + dr2.Value;
        }
    }

    [XPlanePlugin(nameof(IntAdderPlugin), "xpnet.plugins.test." + nameof(IntAdderPlugin), description: "unit test plugin")]
    public class IntAdderPlugin : TestPluginBase
    {
        public IntAdderPlugin(IXPlaneApi api) : base(api) { }

        public override void Enable()
        {
			var dr1 = Api.Data.GetInt(TestData.Name("dr/addint/lhs"));
            var dr2 = Api.Data.GetInt(TestData.Name("dr/addint/rhs"));
            var ans = Api.Data.GetInt(TestData.Name("dr/addint/res"));

            ans.Value = dr1.Value + dr2.Value;
        }
    }

    [XPlanePlugin(nameof(IntArrayAdderPlugin), "xpnet.plugins.test." + nameof(IntArrayAdderPlugin), description: "unit test plugin")]
    public class IntArrayAdderPlugin : TestPluginBase
    {
        public IntArrayAdderPlugin(IXPlaneApi api) : base(api) { }

        public override void Enable()
        {
			//using (var f = System.IO.File.OpenWrite(@"d:\test.txt",))
            var dr1 = Api.Data.GetIntArray(TestData.Name("dr/addintarr/lhs"));
            var dr2 = Api.Data.GetIntArray(TestData.Name("dr/addintarr/rhs"));
            var ans = Api.Data.GetIntArray(TestData.Name("dr/addintarr/res"));
            
            ans.Value = dr1.Value.Zip(dr2.Value, (lhs, rhs) => lhs + rhs).ToArray();
        }
    }

    [XPlanePlugin(nameof(BoolXorPlugin), "xpnet.plugins.test." + nameof(BoolXorPlugin), description: "unit test plugin")]
    public class BoolXorPlugin : TestPluginBase
    {
        public BoolXorPlugin(IXPlaneApi api) : base(api) { }

        public override void Enable()
        {
            var dr1 = Api.Data.GetBool(TestData.Name("dr/xorbool/lhs"));
            var dr2 = Api.Data.GetBool(TestData.Name("dr/xorbool/rhs"));
            var ans = Api.Data.GetBool(TestData.Name("dr/xorbool/res"));

            ans.Value = dr1.Value ^ dr2.Value;
        }
    }

    [XPlanePlugin(nameof(BoolArrayXorPlugin), "xpnet.plugins.test." + nameof(BoolArrayXorPlugin), description: "unit test plugin")]
    public class BoolArrayXorPlugin : TestPluginBase
    {
        public BoolArrayXorPlugin(IXPlaneApi api) : base(api) { }

        public override void Enable()
        {
            var dr1 = Api.Data.GetBoolArray(TestData.Name("dr/xorboolarr/lhs"));
            var dr2 = Api.Data.GetBoolArray(TestData.Name("dr/xorboolarr/rhs"));
            var ans = Api.Data.GetBoolArray(TestData.Name("dr/xorboolarr/res"));

            ans.Value = dr1.Value.Zip(dr2.Value, (lhs, rhs) => new XPBoolean(lhs.Value ^ rhs.Value)).ToArray();
        }
    }

    [XPlanePlugin(nameof(FloatAdderPlugin), "xpnet.plugins.test." + nameof(FloatAdderPlugin), description: "unit test plugin")]
    public class FloatAdderPlugin : TestPluginBase
    {
        public FloatAdderPlugin(IXPlaneApi api) : base(api) { }

        public override void Enable()
        {
            var dr1 = Api.Data.GetFloat(TestData.Name("dr/addfloat/lhs"));
            var dr2 = Api.Data.GetFloat(TestData.Name("dr/addfloat/rhs"));
            var ans = Api.Data.GetFloat(TestData.Name("dr/addfloat/res"));

            ans.Value = dr1.Value + dr2.Value;
        }
    }

    [XPlanePlugin(nameof(FloatArrayAdderPlugin), "xpnet.plugins.test." + nameof(FloatArrayAdderPlugin), description: "unit test plugin")]
    public class FloatArrayAdderPlugin : TestPluginBase
    {
        public FloatArrayAdderPlugin(IXPlaneApi api) : base(api) { }

        public override void Enable()
        {
            var dr1 = Api.Data.GetFloatArray(TestData.Name("dr/addfloatarr/lhs"));
            var dr2 = Api.Data.GetFloatArray(TestData.Name("dr/addfloatarr/rhs"));
            var ans = Api.Data.GetFloatArray(TestData.Name("dr/addfloatarr/res"));

            ans.Value = dr1.Value.Zip(dr2.Value, (lhs, rhs) => lhs + rhs).ToArray();
        }
    }

    [XPlanePlugin(nameof(ByteArrayAdderPlugin), "xpnet.plugins.test." + nameof(ByteArrayAdderPlugin), description: "unit test plugin")]
    public class ByteArrayAdderPlugin : TestPluginBase
    {
        public ByteArrayAdderPlugin(IXPlaneApi api) : base(api) { }

        public override void Enable()
        {
            var dr1 = Api.Data.GetByteArray(TestData.Name("dr/addbytearr/lhs"));
            var dr2 = Api.Data.GetByteArray(TestData.Name("dr/addbytearr/rhs"));
            var ans = Api.Data.GetByteArray(TestData.Name("dr/addbytearr/res"));

            ans.Value = dr1.Value.Zip(dr2.Value, (lhs, rhs) => (byte) (lhs + rhs)).ToArray();
        }
    }
}
