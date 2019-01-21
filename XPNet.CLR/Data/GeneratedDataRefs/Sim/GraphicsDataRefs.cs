using System;
using System.Collections.Generic;
using System.Text;

namespace XPNet.Data
{
    public class sim_graphicsDataRefs
    {
        private readonly IXPlaneData m_data;

        internal sim_graphicsDataRefs(IXPlaneData data)
        {
            m_data = data;
            animation = new sim_graphics_animationDataRefs(data);
            colors = new sim_graphics_colorsDataRefs(data);
            misc = new sim_graphics_miscDataRefs(data);
            scenery = new sim_graphics_sceneryDataRefs(data);
            settings = new sim_graphics_settingsDataRefs(data);
            view = new sim_graphics_viewDataRefs(data);
        }
        public sim_graphics_animationDataRefs animation { get; }
        public sim_graphics_colorsDataRefs colors { get; }
        public sim_graphics_miscDataRefs misc { get; }
        public sim_graphics_sceneryDataRefs scenery { get; }
        public sim_graphics_settingsDataRefs settings { get; }
        public sim_graphics_viewDataRefs view { get; }
    }
}