using System;
using System.Collections.Generic;
using System.Text;

namespace XPNet.Data
{
    public class Sim_Graphics_Animation_LightsDatarefs
    {
        private readonly IXPlaneData m_data;

        internal Sim_Graphics_Animation_LightsDatarefs(IXPlaneData data)
        {
            m_data = data;
        }

        /// <summary>
        ///  A flashing light, on only at night, matches v7. Units:light
        /// </summary>
        public IXPDataRef<float[]> Flasher => m_data.GetFloatArray("sim/graphics/animation/lights/flasher");

        /// <summary>
        ///  A red pulsing light, on only at night, matches v7. Units:light
        /// </summary>
        public IXPDataRef<float[]> Pulse => m_data.GetFloatArray("sim/graphics/animation/lights/pulse");

        /// <summary>
        ///  A white strobe light, on only at night, matches v7. Units:light
        /// </summary>
        public IXPDataRef<float[]> Strobe_v7 => m_data.GetFloatArray("sim/graphics/animation/lights/strobe_v7");

        /// <summary>
        ///  A 3-color traffic light, matches v7. Units:light
        /// </summary>
        public IXPDataRef<float[]> Traffic_light => m_data.GetFloatArray("sim/graphics/animation/lights/traffic_light");

        /// <summary>
        ///  A normal on-at-night light, matches v7. Units:light
        /// </summary>
        public IXPDataRef<float[]> Normal => m_data.GetFloatArray("sim/graphics/animation/lights/normal");

        /// <summary>
        ///  An airport beacon light, RGBA is a homogenous normal vector. Units:light
        /// </summary>
        public IXPDataRef<float[]> Airport_beacon => m_data.GetFloatArray("sim/graphics/animation/lights/airport_beacon");

        /// <summary>
        ///  An airport beacon light, RGBA is a homogenous normal vector. Units:light
        /// </summary>
        public IXPDataRef<float[]> Airport_beacon_flash => m_data.GetFloatArray("sim/graphics/animation/lights/airport_beacon_flash");

        /// <summary>
        ///  VASI light, RG = rescaling of brightness. Units:light
        /// </summary>
        public IXPDataRef<float[]> Vasi_papi => m_data.GetFloatArray("sim/graphics/animation/lights/vasi_papi");

        /// <summary>
        ///  VASI light, RG = rescaling of brightness. Units:light
        /// </summary>
        public IXPDataRef<float[]> Vasi_papi_tint => m_data.GetFloatArray("sim/graphics/animation/lights/vasi_papi_tint");

        /// <summary>
        ///  VASI light, RG = rescaling of brightness, B= beam+, A=beam-. Units:light
        /// </summary>
        public IXPDataRef<float[]> Vasi3 => m_data.GetFloatArray("sim/graphics/animation/lights/vasi3");

        /// <summary>
        ///  RG = rescaling, B = flash frequency. Units:light
        /// </summary>
        public IXPDataRef<float[]> Rabbit => m_data.GetFloatArray("sim/graphics/animation/lights/rabbit");

        /// <summary>
        ///  RGB = ignored, A = frequency. Units:light
        /// </summary>
        public IXPDataRef<float[]> Rabbit_sp => m_data.GetFloatArray("sim/graphics/animation/lights/rabbit_sp");

        /// <summary>
        ///  RG = rescaling, B = flash frequency, A= phase. Units:light
        /// </summary>
        public IXPDataRef<float[]> Strobe => m_data.GetFloatArray("sim/graphics/animation/lights/strobe");

        /// <summary>
        ///  RGB = ignored, A = frequency. Units:light
        /// </summary>
        public IXPDataRef<float[]> Strobe_sp => m_data.GetFloatArray("sim/graphics/animation/lights/strobe_sp");

        /// <summary>
        ///  RG = rescaling, B = flash frequency, A= phase. Units:light
        /// </summary>
        public IXPDataRef<float[]> Wigwag => m_data.GetFloatArray("sim/graphics/animation/lights/wigwag");

        /// <summary>
        ///  RGB = ignored, A = phase, dx = frequency. Units:light
        /// </summary>
        public IXPDataRef<float[]> Wigwag_sp => m_data.GetFloatArray("sim/graphics/animation/lights/wigwag_sp");

        /// <summary>
        ///  A light that turns on when the carrier app is waved off. Units:light
        /// </summary>
        public IXPDataRef<float[]> Carrier_waveoff => m_data.GetFloatArray("sim/graphics/animation/lights/carrier_waveoff");

        /// <summary>
        ///  A vertical fresnel.  RG = long range, BA = vert range. Units:light
        /// </summary>
        public IXPDataRef<float[]> Fresnel_vertical => m_data.GetFloatArray("sim/graphics/animation/lights/fresnel_vertical");

        /// <summary>
        ///  A horizontal fresnel.  RG = long range, BA = vert range. Units:light
        /// </summary>
        public IXPDataRef<float[]> Fresnel_horizontal => m_data.GetFloatArray("sim/graphics/animation/lights/fresnel_horizontal");

        /// <summary>
        ///  Airplane landing light.   RGB = dir, A = light number. Units:light
        /// </summary>
        public IXPDataRef<float[]> Airplane_landing_light => m_data.GetFloatArray("sim/graphics/animation/lights/airplane_landing_light");

        /// <summary>
        ///  Airplane landing light.   RGB = dir, A = light number. Units:light
        /// </summary>
        public IXPDataRef<float[]> Airplane_landing_light_flash => m_data.GetFloatArray("sim/graphics/animation/lights/airplane_landing_light_flash");

        /// <summary>
        ///  Airplane landing light.   RGB = dir, A = light number. Units:light
        /// </summary>
        public IXPDataRef<float[]> Airplane_landing_light_spill => m_data.GetFloatArray("sim/graphics/animation/lights/airplane_landing_light_spill");

        /// <summary>
        ///  Airplane generic light.   RGB = dir, A = light number. Units:light
        /// </summary>
        public IXPDataRef<float[]> Airplane_generic_light => m_data.GetFloatArray("sim/graphics/animation/lights/airplane_generic_light");

        /// <summary>
        ///  Airplane generic light.   RGB = dir, A = light number. Units:light
        /// </summary>
        public IXPDataRef<float[]> Airplane_generic_light_flash => m_data.GetFloatArray("sim/graphics/animation/lights/airplane_generic_light_flash");

        /// <summary>
        ///  Airplane generic light.   RGB = dir, A = light number. Units:light
        /// </summary>
        public IXPDataRef<float[]> Airplane_generic_light_spill => m_data.GetFloatArray("sim/graphics/animation/lights/airplane_generic_light_spill");

        /// <summary>
        ///  AIrplane taxi light.   RGB = dir, A = reserved, use 0. Units:light
        /// </summary>
        public IXPDataRef<float[]> Airplane_taxi_light => m_data.GetFloatArray("sim/graphics/animation/lights/airplane_taxi_light");

        /// <summary>
        ///  AIrplane taxi light.   RGB = dir, A = reserved, use 0. Units:light
        /// </summary>
        public IXPDataRef<float[]> Airplane_taxi_light_flash => m_data.GetFloatArray("sim/graphics/animation/lights/airplane_taxi_light_flash");

        /// <summary>
        ///  AIrplane taxi light.   RGB = dir, A = reserved, use 0. Units:light
        /// </summary>
        public IXPDataRef<float[]> Airplane_taxi_light_spill => m_data.GetFloatArray("sim/graphics/animation/lights/airplane_taxi_light_spill");

        /// <summary>
        ///  AIrplane spot light.   RGB = dir, A = reserved, use 0. Units:light
        /// </summary>
        public IXPDataRef<float[]> Airplane_spot_light => m_data.GetFloatArray("sim/graphics/animation/lights/airplane_spot_light");

        /// <summary>
        ///  AIrplane spot light.   RGB = dir, A = reserved, use 0. Units:light
        /// </summary>
        public IXPDataRef<float[]> Airplane_spot_light_flash => m_data.GetFloatArray("sim/graphics/animation/lights/airplane_spot_light_flash");

        /// <summary>
        ///  AIrplane spot light.   RGB = dir, A = reserved, use 0. Units:light
        /// </summary>
        public IXPDataRef<float[]> Airplane_spot_light_spill => m_data.GetFloatArray("sim/graphics/animation/lights/airplane_spot_light_spill");

        /// <summary>
        ///  Airplane beacon light.   RGB = ignore, A = light number. Units:light
        /// </summary>
        public IXPDataRef<float[]> Airplane_beacon_light => m_data.GetFloatArray("sim/graphics/animation/lights/airplane_beacon_light");

        /// <summary>
        ///  Airplane navigation light.   RGB = ignore, A = reserved, use 0. Units:light
        /// </summary>
        public IXPDataRef<float[]> Airplane_navigation_light => m_data.GetFloatArray("sim/graphics/animation/lights/airplane_navigation_light");

        /// <summary>
        ///  Airplane strobe light.   RGB = ignore, A = light number. Units:light
        /// </summary>
        public IXPDataRef<float[]> Airplane_strobe_light => m_data.GetFloatArray("sim/graphics/animation/lights/airplane_strobe_light");

        /// <summary>
        ///  Airplane beacon light.   RGB = direction, A = light number. Units:light
        /// </summary>
        public IXPDataRef<float[]> Airplane_beacon_light_dir => m_data.GetFloatArray("sim/graphics/animation/lights/airplane_beacon_light_dir");

        /// <summary>
        ///  Airplane navigation light.   RGB = ignored, A = reserved, use 0. Units:light
        /// </summary>
        public IXPDataRef<float[]> Airplane_navigation_light_dir => m_data.GetFloatArray("sim/graphics/animation/lights/airplane_navigation_light_dir");

        /// <summary>
        ///  Airplane strobe light.   RGB = direction, A = light number. Units:light
        /// </summary>
        public IXPDataRef<float[]> Airplane_strobe_light_dir => m_data.GetFloatArray("sim/graphics/animation/lights/airplane_strobe_light_dir");

        /// <summary>
        ///  Airplane beacon light.   RGB = direction, A = light number. Units:light
        /// </summary>
        public IXPDataRef<float[]> Airplane_beacon_light_spill => m_data.GetFloatArray("sim/graphics/animation/lights/airplane_beacon_light_spill");

        /// <summary>
        ///  Airplane navigation light.   RGB = ignored, A = reserved, use 0. Units:light
        /// </summary>
        public IXPDataRef<float[]> Airplane_navigation_light_spill => m_data.GetFloatArray("sim/graphics/animation/lights/airplane_navigation_light_spill");

        /// <summary>
        ///  Airplane strobe light.   RGB = direction, A = light number. Units:light
        /// </summary>
        public IXPDataRef<float[]> Airplane_strobe_light_spill => m_data.GetFloatArray("sim/graphics/animation/lights/airplane_strobe_light_spill");

        /// <summary>
        ///  Internal panel floods, A = index. Units:light
        /// </summary>
        public IXPDataRef<float[]> Airplane_panel_spill => m_data.GetFloatArray("sim/graphics/animation/lights/airplane_panel_spill");

        /// <summary>
        ///  Internal instrument post lights, A = index. Units:light
        /// </summary>
        public IXPDataRef<float[]> Airplane_inst_spill => m_data.GetFloatArray("sim/graphics/animation/lights/airplane_inst_spill");

        /// <summary>
        ///  Airplane beacon light for rotating beacon billboard.. Units:light
        /// </summary>
        public IXPDataRef<float[]> Airplane_beacon_light_rotate => m_data.GetFloatArray("sim/graphics/animation/lights/airplane_beacon_light_rotate");

        /// <summary>
        ///  Airplane beacon light for rotating beacon spill.. Units:light
        /// </summary>
        public IXPDataRef<float[]> Airplane_beacon_light_rotate_spill => m_data.GetFloatArray("sim/graphics/animation/lights/airplane_beacon_light_rotate_spill");
    }
}