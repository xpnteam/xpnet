using System;
using System.Collections.Generic;
using System.Text;

namespace XPNet.Data
{
    public class sim_graphicsDatarefs
    {
        private readonly IXPlaneData m_data;

        internal sim_graphicsDatarefs(IXPlaneData data)
        {
            m_data = data;
            animation = new sim_graphics_animationDatarefs(data);
            colors = new sim_graphics_colorsDatarefs(data);
            misc = new sim_graphics_miscDatarefs(data);
            scenery = new sim_graphics_sceneryDatarefs(data);
            settings = new sim_graphics_settingsDatarefs(data);
            view = new sim_graphics_viewDatarefs(data);
        }
        public sim_graphics_animationDatarefs animation { get; }
        public sim_graphics_colorsDatarefs colors { get; }
        public sim_graphics_miscDatarefs misc { get; }
        public sim_graphics_sceneryDatarefs scenery { get; }
        public sim_graphics_settingsDatarefs settings { get; }
        public sim_graphics_viewDatarefs view { get; }
    }
}