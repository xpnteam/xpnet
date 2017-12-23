using System;
using System.Collections.Generic;
using System.Text;

namespace XPNet
{
    public interface IXPCommand
    {
        string Name { get; }

        void Begin();
        void End();
        void InvokeOnce();
    }

    internal sealed class XPCommandRef : IXPCommand
    {
        internal unsafe XPCommandRef(string name, void* cmdref)
        {
            Name = name;
            CommandRef = cmdref;
        }

        public string Name
        {
            get;
        }

        internal unsafe void* CommandRef;

        public unsafe void Begin()
        {
            PluginBridge.ApiFunctions.XPLMCommandBegin(CommandRef);
        }

        public unsafe void End()
        {
            PluginBridge.ApiFunctions.XPLMCommandEnd(CommandRef);
        }

        public unsafe void InvokeOnce()
        {
            PluginBridge.ApiFunctions.XPLMCommandOnce(CommandRef);
        }
    }
}
