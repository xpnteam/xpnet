
namespace XPNet
{
    // The automatic DataRef generation creates a companion to this partial class where you can access the
    // generated DataRefs.  If you don't run that generation, this class provides a stub that allows the
    // rest of the project to still compile.
    public partial class SimDataRefs
    {
        private readonly XPlaneData m_data;

        internal SimDataRefs(XPlaneData data)
        {
            m_data = data;

            Init();
        }

        partial void Init();
    }
}
