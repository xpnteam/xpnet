using System;
using System.Collections.Generic;
using System.Text;

namespace XPNet.Data
{
    public class sim_flightmodel2_engines_prop_discDataRefs
    {
        private readonly IXPlaneData m_data;

        internal sim_flightmodel2_engines_prop_discDataRefs(IXPlaneData data)
        {
            m_data = data;
        }

        /// <summary>
        ///  Set to 1 to control the prop disc from a plugin.  Overrides all other variables in this section.. Units:boolean
        ///  Raw path: sim/flightmodel2/engines/prop_disc/override
        /// </summary>
        public IXPDataRef<bool[]> override_ { get { return m_data.GetBoolArray("sim/flightmodel2/engines/prop_disc/override");} }

        /// <summary>
        ///  If larger than zero, the prop disc is actually two discs, with this separation at the root and no separation at the tip.. Units:meters
        ///  Raw path: sim/flightmodel2/engines/prop_disc/disc_width
        /// </summary>
        public IXPDataRef<float[]> disc_width { get { return m_data.GetFloatArray("sim/flightmodel2/engines/prop_disc/disc_width");} }

        /// <summary>
        ///  Offset from left (in "slots") for the prop disc texture.  Fractions blend horizontal images.. Units:offset
        ///  Raw path: sim/flightmodel2/engines/prop_disc/disc_s
        /// </summary>
        public IXPDataRef<float[]> disc_s { get { return m_data.GetFloatArray("sim/flightmodel2/engines/prop_disc/disc_s");} }

        /// <summary>
        ///  Offset from bottom (in "slots") for the prop disc texture. Units:offset
        ///  Raw path: sim/flightmodel2/engines/prop_disc/disc_t
        /// </summary>
        public IXPDataRef<int[]> disc_t { get { return m_data.GetIntArray("sim/flightmodel2/engines/prop_disc/disc_t");} }

        /// <summary>
        ///  Number of horizontal slots for the prop disc in the prop disc texture. Units:count
        ///  Raw path: sim/flightmodel2/engines/prop_disc/disc_s_dim
        /// </summary>
        public IXPDataRef<int[]> disc_s_dim { get { return m_data.GetIntArray("sim/flightmodel2/engines/prop_disc/disc_s_dim");} }

        /// <summary>
        ///  Number of vertical slots for the prop disc in the prop disc texture. Units:count
        ///  Raw path: sim/flightmodel2/engines/prop_disc/disc_t_dim
        /// </summary>
        public IXPDataRef<int[]> disc_t_dim { get { return m_data.GetIntArray("sim/flightmodel2/engines/prop_disc/disc_t_dim");} }

        /// <summary>
        ///  Alpha of prop disc when viewed from front.  X-Plane interpolates as the view angle moves.. Units:ratio
        ///  Raw path: sim/flightmodel2/engines/prop_disc/disc_alpha_front
        /// </summary>
        public IXPDataRef<float[]> disc_alpha_front { get { return m_data.GetFloatArray("sim/flightmodel2/engines/prop_disc/disc_alpha_front");} }

        /// <summary>
        ///  Alpha of prop disc when viewed of side.. Units:ratio
        ///  Raw path: sim/flightmodel2/engines/prop_disc/disc_alpha_side
        /// </summary>
        public IXPDataRef<float[]> disc_alpha_side { get { return m_data.GetFloatArray("sim/flightmodel2/engines/prop_disc/disc_alpha_side");} }

        /// <summary>
        ///  Ratio to multiply disc alpha when view is inside the airplane.. Units:ratio
        ///  Raw path: sim/flightmodel2/engines/prop_disc/disc_alpha_inside
        /// </summary>
        public IXPDataRef<float[]> disc_alpha_inside { get { return m_data.GetFloatArray("sim/flightmodel2/engines/prop_disc/disc_alpha_inside");} }

        /// <summary>
        ///  Width of prop side image in meters.  Height comes from prop radius.. Units:meters
        ///  Raw path: sim/flightmodel2/engines/prop_disc/side_width
        /// </summary>
        public IXPDataRef<float[]> side_width { get { return m_data.GetFloatArray("sim/flightmodel2/engines/prop_disc/side_width");} }

        /// <summary>
        ///  Ratio to scale the length of the side image.  1.0 = the real length of the prop.. Units:ratio
        ///  Raw path: sim/flightmodel2/engines/prop_disc/side_length_ratio
        /// </summary>
        public IXPDataRef<float[]> side_length_ratio { get { return m_data.GetFloatArray("sim/flightmodel2/engines/prop_disc/side_length_ratio");} }

        /// <summary>
        ///  Rotation angle of the side images now - allows side to rotate independently of disc, perhaps faster.. Units:degrees
        ///  Raw path: sim/flightmodel2/engines/prop_disc/side_angle
        /// </summary>
        public IXPDataRef<float[]> side_angle { get { return m_data.GetFloatArray("sim/flightmodel2/engines/prop_disc/side_angle");} }

        /// <summary>
        ///  Number of side blades to draw.  Should be at least 2!. Units:count
        ///  Raw path: sim/flightmodel2/engines/prop_disc/side_number_of_blades
        /// </summary>
        public IXPDataRef<int[]> side_number_of_blades { get { return m_data.GetIntArray("sim/flightmodel2/engines/prop_disc/side_number_of_blades");} }

        /// <summary>
        ///  If true, prop side angle comes from billboarding logic - if false, it comes from side_angle dataref.. Units:boolean
        ///  Raw path: sim/flightmodel2/engines/prop_disc/side_is_billboard
        /// </summary>
        public IXPDataRef<bool[]> side_is_billboard { get { return m_data.GetBoolArray("sim/flightmodel2/engines/prop_disc/side_is_billboard");} }

        /// <summary>
        ///  Offset from left (in "slots") for the prop disc texture.  Fractions blend horizontal images.. Units:offset
        ///  Raw path: sim/flightmodel2/engines/prop_disc/side_s
        /// </summary>
        public IXPDataRef<float[]> side_s { get { return m_data.GetFloatArray("sim/flightmodel2/engines/prop_disc/side_s");} }

        /// <summary>
        ///  Offset from bottom (in "slots") for the prop disc texture. Units:offset
        ///  Raw path: sim/flightmodel2/engines/prop_disc/side_t
        /// </summary>
        public IXPDataRef<int[]> side_t { get { return m_data.GetIntArray("sim/flightmodel2/engines/prop_disc/side_t");} }

        /// <summary>
        ///  Number of horizontal slots for the prop side in the prop disc texture. Units:count
        ///  Raw path: sim/flightmodel2/engines/prop_disc/side_s_dim
        /// </summary>
        public IXPDataRef<int[]> side_s_dim { get { return m_data.GetIntArray("sim/flightmodel2/engines/prop_disc/side_s_dim");} }

        /// <summary>
        ///  Number of vertical slots for the prop side in the prop disc texture. Units:count
        ///  Raw path: sim/flightmodel2/engines/prop_disc/side_t_dim
        /// </summary>
        public IXPDataRef<int[]> side_t_dim { get { return m_data.GetIntArray("sim/flightmodel2/engines/prop_disc/side_t_dim");} }

        /// <summary>
        ///  Alpha of prop side when viewed from front.  X-Plane interpolates as the view angle moves.. Units:ratio
        ///  Raw path: sim/flightmodel2/engines/prop_disc/side_alpha_front
        /// </summary>
        public IXPDataRef<float[]> side_alpha_front { get { return m_data.GetFloatArray("sim/flightmodel2/engines/prop_disc/side_alpha_front");} }

        /// <summary>
        ///  Alpha of prop side when viewed of side.. Units:ratio
        ///  Raw path: sim/flightmodel2/engines/prop_disc/side_alpha_side
        /// </summary>
        public IXPDataRef<float[]> side_alpha_side { get { return m_data.GetFloatArray("sim/flightmodel2/engines/prop_disc/side_alpha_side");} }

        /// <summary>
        ///  Ratio to multiply side alpha when view is inside the airplane.. Units:ratio
        ///  Raw path: sim/flightmodel2/engines/prop_disc/side_alpha_inside
        /// </summary>
        public IXPDataRef<float[]> side_alpha_inside { get { return m_data.GetFloatArray("sim/flightmodel2/engines/prop_disc/side_alpha_inside");} }

        /// <summary>
        ///  A ratio to multiply side alpha when the rotor is extending toward the camera.. Units:ratio
        ///  Raw path: sim/flightmodel2/engines/prop_disc/side_alpha_to_camera
        /// </summary>
        public IXPDataRef<float[]> side_alpha_to_camera { get { return m_data.GetFloatArray("sim/flightmodel2/engines/prop_disc/side_alpha_to_camera");} }
    }
}