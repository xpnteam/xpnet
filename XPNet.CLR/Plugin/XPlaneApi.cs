
using Microsoft.Extensions.Configuration;
using System;

namespace XPNet
{
    /// <summary>
    /// Provides access to the X-Plane API from a plugin.
    /// </summary>
    public interface IXPlaneApi
    {
        /// <summary>
        /// Raised when the configuration in the xpnetcfg.json file has changed.
        /// </summary>
        event EventHandler ConfigChanged;

        /// <summary>
        /// Gets the log.
        /// </summary>
        ILog Log { get; }

        /// <summary>
        /// Gets the configuration for the plugin (from the xpnetcfg.json file).
        /// </summary>
        IConfiguration Config { get; }

        /// <summary>
        /// Gets the X-Plane messages API.  Use this API to get access
        /// to events that map closely to the X-Plane API documentation.
        /// Sometimes, there will also be a higher-level API provided by
        /// XPNet, as an alternative to the Messages API.
        /// </summary>
        IXPlaneMessages Messages { get; }

        /// <summary>
        /// Gets the data access API (i.e., DataRefs).
        /// </summary>
        IXPlaneData Data { get; }

        /// <summary>
        /// Gets the commands API.
        /// </summary>
        IXPlaneCommands Commands { get; }

        /// <summary>
        /// Gets the processing API.
        /// </summary>
        IXPlaneProcessing Processing { get; }

		/// <summary>
		/// Gets the display API.
		/// </summary>
		IXPlaneDisplay Display { get; }

		/// <summary>
		/// Gets the scenery API.
		/// </summary>
		IXPlaneScenery Scenery { get; }

		/// <summary>
		/// Gets the graphics API.
		/// </summary>
		IXPlaneGraphics Graphics { get; }


	}

	internal class XPlaneApi : IXPlaneApi, IDisposable
    {
        public event EventHandler ConfigChanged;

        public XPlaneApi(ILog log, IConfiguration config)
        {
            Log = log;
            Config = config;
            Messages = new XPlaneMessages();
            Data = new XPlaneData();
            Commands = new XPlaneCommands();
            Processing = new XPlaneProcessing();
			Display = new XPlaneDisplay();
			Scenery = new XPlaneScenery();
			Graphics = new XPlaneGraphics();
		}

        public void Dispose()
        {
            // Currently nothing to do.
        }

        public ILog Log
        {
            get;
            internal set;
        }

        public IConfiguration Config
        {
            get;
        }

        IXPlaneMessages IXPlaneApi.Messages
        {
            get { return Messages; }
        }

        public XPlaneMessages Messages
        {
            get;
        }

        IXPlaneData IXPlaneApi.Data
        {
            get { return Data; }
        }

        public XPlaneData Data
        {
            get;
        }

        IXPlaneCommands IXPlaneApi.Commands
        {
            get { return Commands; }
        }

        public XPlaneCommands Commands
        {
            get;
        }

        IXPlaneProcessing IXPlaneApi.Processing
        {
            get { return Processing; }
        }

        public XPlaneProcessing Processing
        {
            get;
        }

        internal void RaiseConfigChanged()
        {
            ConfigChanged?.Invoke(this, EventArgs.Empty);
        }

		IXPlaneDisplay IXPlaneApi.Display
		{
			get { return Display; }
		}

		public IXPlaneDisplay Display
		{
			get;
		}

		IXPlaneScenery IXPlaneApi.Scenery
		{
			get { return Scenery; }
		}

		public IXPlaneScenery Scenery
		{
			get;
		}
		IXPlaneGraphics IXPlaneApi.Graphics
		{
			get { return Graphics; }
		}

		public IXPlaneGraphics Graphics
		{
			get;
		}
	}
}
