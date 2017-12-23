
using System;
using System.Collections.Generic;

namespace XPNet
{
    /// <summary>
    /// Provides access to X-Plane commands.
    /// </summary>
    public interface IXPlaneCommands
    {
        // TODO: Support for publishing our own commands.

        IXPCommand GetCommand(string commandName);
    }

    internal class XPlaneCommands : IXPlaneCommands
    {
        private readonly Dictionary<string, IXPCommand> m_commands
            = new Dictionary<string, IXPCommand>();

        private unsafe delegate IXPCommand CommandFactory(string commandName, void* cmdref);

        public unsafe IXPCommand GetCommand(string commandName) =>
            GetCommand(commandName, m_commands, CreateCommandRef) ?? throw InvalidCommandException(commandName);

        private unsafe IXPCommand GetCommand(
            string commandName,
            IDictionary<string, IXPCommand> cache, CommandFactory factory)
        {
            if (!cache.TryGetValue(commandName, out var dr))
            {
                void* cmdref = PluginBridge.ApiFunctions.XPLMFindCommand(commandName);
                if (cmdref == null)
                    return null;

                dr = factory(commandName, cmdref);
                cache[commandName] = dr;
            }

            return dr;
        }

        private unsafe IXPCommand CreateCommandRef(string commandName, void* cmdref) => new XPCommandRef(commandName, cmdref);

        private InvalidOperationException InvalidCommandException(string commandName)
            => new InvalidOperationException($"The current X-Plane instance does not respond to the command ({commandName}).");
    }
}
