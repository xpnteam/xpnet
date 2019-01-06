using System;
using System.Collections.Generic;
using System.Text;

namespace XPNet.Data
{
    public class sim_flightmodel2_engines_prop_discDatarefs
    {
        private readonly IXPlaneData m_data;

        internal sim_flightmodel2_engines_prop_discDatarefs(IXPlaneData data)
        {
            m_data = data;
        }

        /// <summary>
        ///  Set to 1 to control the prop disc from a plugin.  Overrides all other variables in this section.
        /// </summary>
        public IXPDataRef<bool[]> override_ { get { return m_data.GetBoolArray("sim/flightmodel2/engines/prop_disc/override");} }

        /// <summary>
        ///  If larger than zero, the prop disc is actually two discs, with this separation at the root and no separation at the tip.
        /// </summary>
        public IXPDataRef<float[]> disc_width { get { return m_data.GetFloatArray("sim/flightmodel2/engines/prop_disc/disc_width");} }

        /// <summary>
        ///  Offset from left (in "slots") for the prop disc texture.  Fractions blend horizontal images.
        /// </summary>
        public IXPDataRef<float[]> disc_s { get { return m_data.GetFloatArray("sim/flightmodel2/engines/prop_disc/disc_s");} }

        /// <summary>
        ///  Alpha of prop disc when viewed from front.  X-Plane interpolates as the view angle moves.
        /// </summary>
        public IXPDataRef<float[]> disc_alpha_front { get { return m_data.GetFloatArray("sim/flightmodel2/engines/prop_disc/disc_alpha_front");} }

        /// <summary>
        ///  Alpha of prop disc when viewed of side.
        /// </summary>
        public IXPDataRef<float[]> disc_alpha_side { get { return m_data.GetFloatArray("sim/flightmodel2/engines/prop_disc/disc_alpha_side");} }

        /// <summary>
        ///  Ratio to multiply disc alpha when view is inside the airplane.
        /// </summary>
        public IXPDataRef<float[]> disc_alpha_inside { get { return m_data.GetFloatArray("sim/flightmodel2/engines/prop_disc/disc_alpha_inside");} }

        /// <summary>
        ///  Width of prop side image in meters.  Height comes from prop radius.
        /// </summary>
        public IXPDataRef<float[]> side_width { get { return m_data.GetFloatArray("sim/flightmodel2/engines/prop_disc/side_width");} }

        /// <summary>
        ///  Ratio to scale the length of the side image.  1.0 = the real length of the prop.
        /// </summary>
        public IXPDataRef<float[]> side_length_ratio { get { return m_data.GetFloatArray("sim/flightmodel2/engines/prop_disc/side_length_ratio");} }

        /// <summary>
        ///  Rotation angle of the side images now - allows side to rotate independently of disc, perhaps faster.
        /// </summary>
        public IXPDataRef<float[]> side_angle { get { return m_data.GetFloatArray("sim/flightmodel2/engines/prop_disc/side_angle");} }

        /// <summary>
        ///  If true, prop side angle comes from billboarding logic - if false, it comes from side_angle dataref.
        /// </summary>
        public IXPDataRef<bool[]> side_is_billboard { get { return m_data.GetBoolArray("sim/flightmodel2/engines/prop_disc/side_is_billboard");} }

        /// <summary>
        ///  Offset from left (in "slots") for the prop disc texture.  Fractions blend horizontal images.
        /// </summary>
        public IXPDataRef<float[]> side_s { get { return m_data.GetFloatArray("sim/flightmodel2/engines/prop_disc/side_s");} }

        /// <summary>
        ///  Alpha of prop side when viewed from front.  X-Plane interpolates as the view angle moves.
        /// </summary>
        public IXPDataRef<float[]> side_alpha_front { get { return m_data.GetFloatArray("sim/flightmodel2/engines/prop_disc/side_alpha_front");} }

        /// <summary>
        ///  Alpha of prop side when viewed of side.
        /// </summary>
        public IXPDataRef<float[]> side_alpha_side { get { return m_data.GetFloatArray("sim/flightmodel2/engines/prop_disc/side_alpha_side");} }

        /// <summary>
        ///  Ratio to multiply side alpha when view is inside the airplane.
        /// </summary>
        public IXPDataRef<float[]> side_alpha_inside { get { return m_data.GetFloatArray("sim/flightmodel2/engines/prop_disc/side_alpha_inside");} }

        /// <summary>
        ///  A ratio to multiply side alpha when the rotor is extending toward the camera.
        /// </summary>
        public IXPDataRef<float[]> side_alpha_to_camera { get { return m_data.GetFloatArray("sim/flightmodel2/engines/prop_disc/side_alpha_to_camera");} }
    }
}