using System;
using System.Collections.Generic;
using System.Text;

namespace XPNet.Data
{
    public class Sim_GraphicsDatarefs
    {
        private readonly IXPlaneData m_data;

        internal Sim_GraphicsDatarefs(IXPlaneData data)
        {
            m_data = data;
            Animation = new Sim_Graphics_AnimationDatarefs(data);
            Colors = new Sim_Graphics_ColorsDatarefs(data);
            Misc = new Sim_Graphics_MiscDatarefs(data);
            Scenery = new Sim_Graphics_SceneryDatarefs(data);
            Settings = new Sim_Graphics_SettingsDatarefs(data);
            View = new Sim_Graphics_ViewDatarefs(data);
        }
        public Sim_Graphics_AnimationDatarefs Animation { get; }
        public Sim_Graphics_ColorsDatarefs Colors { get; }
        public Sim_Graphics_MiscDatarefs Misc { get; }
        public Sim_Graphics_SceneryDatarefs Scenery { get; }
        public Sim_Graphics_SettingsDatarefs Settings { get; }
        public Sim_Graphics_ViewDatarefs View { get; }
    }
}