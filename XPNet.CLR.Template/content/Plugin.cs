
using System;
using XPNet;

namespace XPNet.CLR.Template
{
    [XPlanePlugin(
        name: "My Plugin",
        signature: "you.plugins.name",
        description: "Describe your plugin here."
    )]
    public class Plugin : IXPlanePlugin
    {
        private readonly IXPlaneApi m_api;

        public Plugin(IXPlaneApi api)
        {
            m_api = api ?? throw new ArgumentNullException(nameof(api));
        }

        public void Dispose()
        {
            // Clean up whatever we attached / registered for / etc.
        }

        public void Enable()
        {
            // Called when the plugin is enabled in X-Plane.

            // Replace this with your own initialization code.
            m_api.Log.Log("Hello world");
        }

        public void Disable()
        {
            // Called when the plugin is disabled in X-Plane.
        }        
    }
}
