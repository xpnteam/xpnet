
using System;

namespace XPNet
{
    public interface IXPlanePlugin : IDisposable
    {
        void Enable();
        void Disable();
    }

    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
    public sealed class XPlanePluginAttribute : Attribute
    {
        public XPlanePluginAttribute(string name, string signature, string description)
        {
            Name = name;
            Signature = signature;
            Description = description;
        }

        public string Name { get; }
        public string Signature { get; }
        public string Description { get; }
    }
}