using System;
using System.Collections.Generic;
using System.Text;

namespace XPNet.Data
{
    public class Sim_Flightmodel2_Engines_Prop_discDatarefs
    {
        private readonly IXPlaneData m_data;

        internal Sim_Flightmodel2_Engines_Prop_discDatarefs(IXPlaneData data)
        {
            m_data = data;
        }

        /// <summary>
        ///  If larger than zero, the prop disc is actually two discs, with this separation at the root and no separation at the tip.. Units:meters
        /// </summary>
        public IXPDataRef<float[]> Disc_width => m_data.GetFloatArray("sim/flightmodel2/engines/prop_disc/disc_width");

        /// <summary>
        ///  Offset from left (in "slots") for the prop disc texture.  Fractions blend horizontal images.. Units:offset
        /// </summary>
        public IXPDataRef<float[]> Disc_s => m_data.GetFloatArray("sim/flightmodel2/engines/prop_disc/disc_s");

        /// <summary>
        ///  Alpha of prop disc when viewed from front.  X-Plane interpolates as the view angle moves.. Units:ratio
        /// </summary>
        public IXPDataRef<float[]> Disc_alpha_front => m_data.GetFloatArray("sim/flightmodel2/engines/prop_disc/disc_alpha_front");

        /// <summary>
        ///  Alpha of prop disc when viewed of side.. Units:ratio
        /// </summary>
        public IXPDataRef<float[]> Disc_alpha_side => m_data.GetFloatArray("sim/flightmodel2/engines/prop_disc/disc_alpha_side");

        /// <summary>
        ///  Ratio to multiply disc alpha when view is inside the airplane.. Units:ratio
        /// </summary>
        public IXPDataRef<float[]> Disc_alpha_inside => m_data.GetFloatArray("sim/flightmodel2/engines/prop_disc/disc_alpha_inside");

        /// <summary>
        ///  Width of prop side image in meters.  Height comes from prop radius.. Units:meters
        /// </summary>
        public IXPDataRef<float[]> Side_width => m_data.GetFloatArray("sim/flightmodel2/engines/prop_disc/side_width");

        /// <summary>
        ///  Ratio to scale the length of the side image.  1.0 = the real length of the prop.. Units:ratio
        /// </summary>
        public IXPDataRef<float[]> Side_length_ratio => m_data.GetFloatArray("sim/flightmodel2/engines/prop_disc/side_length_ratio");

        /// <summary>
        ///  Rotation angle of the side images now - allows side to rotate independently of disc, perhaps faster.. Units:degrees
        /// </summary>
        public IXPDataRef<float[]> Side_angle => m_data.GetFloatArray("sim/flightmodel2/engines/prop_disc/side_angle");

        /// <summary>
        ///  Offset from left (in "slots") for the prop disc texture.  Fractions blend horizontal images.. Units:offset
        /// </summary>
        public IXPDataRef<float[]> Side_s => m_data.GetFloatArray("sim/flightmodel2/engines/prop_disc/side_s");

        /// <summary>
        ///  Alpha of prop side when viewed from front.  X-Plane interpolates as the view angle moves.. Units:ratio
        /// </summary>
        public IXPDataRef<float[]> Side_alpha_front => m_data.GetFloatArray("sim/flightmodel2/engines/prop_disc/side_alpha_front");

        /// <summary>
        ///  Alpha of prop side when viewed of side.. Units:ratio
        /// </summary>
        public IXPDataRef<float[]> Side_alpha_side => m_data.GetFloatArray("sim/flightmodel2/engines/prop_disc/side_alpha_side");

        /// <summary>
        ///  Ratio to multiply side alpha when view is inside the airplane.. Units:ratio
        /// </summary>
        public IXPDataRef<float[]> Side_alpha_inside => m_data.GetFloatArray("sim/flightmodel2/engines/prop_disc/side_alpha_inside");

        /// <summary>
        ///  A ratio to multiply side alpha when the rotor is extending toward the camera.. Units:ratio
        /// </summary>
        public IXPDataRef<float[]> Side_alpha_to_camera => m_data.GetFloatArray("sim/flightmodel2/engines/prop_disc/side_alpha_to_camera");
    }
}