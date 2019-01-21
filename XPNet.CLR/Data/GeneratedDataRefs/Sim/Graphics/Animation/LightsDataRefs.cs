using System;
using System.Collections.Generic;
using System.Text;

namespace XPNet.Data
{
    public class sim_graphics_animation_lightsDataRefs
    {
        private readonly IXPlaneData m_data;

        internal sim_graphics_animation_lightsDataRefs(IXPlaneData data)
        {
            m_data = data;
        }

        /// <summary>
        ///  A flashing light, on only at night, matches v7. Units:light
        ///  Raw path: sim/graphics/animation/lights/flasher
        /// </summary>
        public IXPDataRef<float[]> flasher { get { return m_data.GetFloatArray("sim/graphics/animation/lights/flasher");} }

        /// <summary>
        ///  A red pulsing light, on only at night, matches v7. Units:light
        ///  Raw path: sim/graphics/animation/lights/pulse
        /// </summary>
        public IXPDataRef<float[]> pulse { get { return m_data.GetFloatArray("sim/graphics/animation/lights/pulse");} }

        /// <summary>
        ///  A white strobe light, on only at night, matches v7. Units:light
        ///  Raw path: sim/graphics/animation/lights/strobe_v7
        /// </summary>
        public IXPDataRef<float[]> strobe_v7 { get { return m_data.GetFloatArray("sim/graphics/animation/lights/strobe_v7");} }

        /// <summary>
        ///  A 3-color traffic light, matches v7. Units:light
        ///  Raw path: sim/graphics/animation/lights/traffic_light
        /// </summary>
        public IXPDataRef<float[]> traffic_light { get { return m_data.GetFloatArray("sim/graphics/animation/lights/traffic_light");} }

        /// <summary>
        ///  A normal on-at-night light, matches v7. Units:light
        ///  Raw path: sim/graphics/animation/lights/normal
        /// </summary>
        public IXPDataRef<float[]> normal { get { return m_data.GetFloatArray("sim/graphics/animation/lights/normal");} }

        /// <summary>
        ///  An airport beacon light, RGBA is a homogenous normal vector. Units:light
        ///  Raw path: sim/graphics/animation/lights/airport_beacon
        /// </summary>
        public IXPDataRef<float[]> airport_beacon { get { return m_data.GetFloatArray("sim/graphics/animation/lights/airport_beacon");} }

        /// <summary>
        ///  An airport beacon light, RGBA is a homogenous normal vector. Units:light
        ///  Raw path: sim/graphics/animation/lights/airport_beacon_flash
        /// </summary>
        public IXPDataRef<float[]> airport_beacon_flash { get { return m_data.GetFloatArray("sim/graphics/animation/lights/airport_beacon_flash");} }

        /// <summary>
        ///  VASI light, RG = rescaling of brightness. Units:light
        ///  Raw path: sim/graphics/animation/lights/vasi_papi
        /// </summary>
        public IXPDataRef<float[]> vasi_papi { get { return m_data.GetFloatArray("sim/graphics/animation/lights/vasi_papi");} }

        /// <summary>
        ///  VASI light, RG = rescaling of brightness. Units:light
        ///  Raw path: sim/graphics/animation/lights/vasi_papi_tint
        /// </summary>
        public IXPDataRef<float[]> vasi_papi_tint { get { return m_data.GetFloatArray("sim/graphics/animation/lights/vasi_papi_tint");} }

        /// <summary>
        ///  VASI light, RG = rescaling of brightness, B= beam+, A=beam-. Units:light
        ///  Raw path: sim/graphics/animation/lights/vasi3
        /// </summary>
        public IXPDataRef<float[]> vasi3 { get { return m_data.GetFloatArray("sim/graphics/animation/lights/vasi3");} }

        /// <summary>
        ///  RG = rescaling, B = flash frequency. Units:light
        ///  Raw path: sim/graphics/animation/lights/rabbit
        /// </summary>
        public IXPDataRef<float[]> rabbit { get { return m_data.GetFloatArray("sim/graphics/animation/lights/rabbit");} }

        /// <summary>
        ///  RGB = ignored, A = frequency. Units:light
        ///  Raw path: sim/graphics/animation/lights/rabbit_sp
        /// </summary>
        public IXPDataRef<float[]> rabbit_sp { get { return m_data.GetFloatArray("sim/graphics/animation/lights/rabbit_sp");} }

        /// <summary>
        ///  RG = rescaling, B = flash frequency, A= phase. Units:light
        ///  Raw path: sim/graphics/animation/lights/strobe
        /// </summary>
        public IXPDataRef<float[]> strobe { get { return m_data.GetFloatArray("sim/graphics/animation/lights/strobe");} }

        /// <summary>
        ///  RGB = ignored, A = frequency. Units:light
        ///  Raw path: sim/graphics/animation/lights/strobe_sp
        /// </summary>
        public IXPDataRef<float[]> strobe_sp { get { return m_data.GetFloatArray("sim/graphics/animation/lights/strobe_sp");} }

        /// <summary>
        ///  RG = rescaling, B = flash frequency, A= phase. Units:light
        ///  Raw path: sim/graphics/animation/lights/wigwag
        /// </summary>
        public IXPDataRef<float[]> wigwag { get { return m_data.GetFloatArray("sim/graphics/animation/lights/wigwag");} }

        /// <summary>
        ///  RGB = ignored, A = phase, dx = frequency. Units:light
        ///  Raw path: sim/graphics/animation/lights/wigwag_sp
        /// </summary>
        public IXPDataRef<float[]> wigwag_sp { get { return m_data.GetFloatArray("sim/graphics/animation/lights/wigwag_sp");} }

        /// <summary>
        ///  A light that turns on when the carrier app is waved off. Units:light
        ///  Raw path: sim/graphics/animation/lights/carrier_waveoff
        /// </summary>
        public IXPDataRef<float[]> carrier_waveoff { get { return m_data.GetFloatArray("sim/graphics/animation/lights/carrier_waveoff");} }

        /// <summary>
        ///  A vertical fresnel.  RG = long range, BA = vert range. Units:light
        ///  Raw path: sim/graphics/animation/lights/fresnel_vertical
        /// </summary>
        public IXPDataRef<float[]> fresnel_vertical { get { return m_data.GetFloatArray("sim/graphics/animation/lights/fresnel_vertical");} }

        /// <summary>
        ///  A horizontal fresnel.  RG = long range, BA = vert range. Units:light
        ///  Raw path: sim/graphics/animation/lights/fresnel_horizontal
        /// </summary>
        public IXPDataRef<float[]> fresnel_horizontal { get { return m_data.GetFloatArray("sim/graphics/animation/lights/fresnel_horizontal");} }

        /// <summary>
        ///  Airplane landing light.   RGB = dir, A = light number. Units:light
        ///  Raw path: sim/graphics/animation/lights/airplane_landing_light
        /// </summary>
        public IXPDataRef<float[]> airplane_landing_light { get { return m_data.GetFloatArray("sim/graphics/animation/lights/airplane_landing_light");} }

        /// <summary>
        ///  Airplane landing light.   RGB = dir, A = light number. Units:light
        ///  Raw path: sim/graphics/animation/lights/airplane_landing_light_flash
        /// </summary>
        public IXPDataRef<float[]> airplane_landing_light_flash { get { return m_data.GetFloatArray("sim/graphics/animation/lights/airplane_landing_light_flash");} }

        /// <summary>
        ///  Airplane landing light.   RGB = dir, A = light number. Units:light
        ///  Raw path: sim/graphics/animation/lights/airplane_landing_light_spill
        /// </summary>
        public IXPDataRef<float[]> airplane_landing_light_spill { get { return m_data.GetFloatArray("sim/graphics/animation/lights/airplane_landing_light_spill");} }

        /// <summary>
        ///  Airplane generic light.   RGB = dir, A = light number. Units:light
        ///  Raw path: sim/graphics/animation/lights/airplane_generic_light
        /// </summary>
        public IXPDataRef<float[]> airplane_generic_light { get { return m_data.GetFloatArray("sim/graphics/animation/lights/airplane_generic_light");} }

        /// <summary>
        ///  Airplane generic light.   RGB = dir, A = light number. Units:light
        ///  Raw path: sim/graphics/animation/lights/airplane_generic_light_flash
        /// </summary>
        public IXPDataRef<float[]> airplane_generic_light_flash { get { return m_data.GetFloatArray("sim/graphics/animation/lights/airplane_generic_light_flash");} }

        /// <summary>
        ///  Airplane generic light.   RGB = dir, A = light number. Units:light
        ///  Raw path: sim/graphics/animation/lights/airplane_generic_light_spill
        /// </summary>
        public IXPDataRef<float[]> airplane_generic_light_spill { get { return m_data.GetFloatArray("sim/graphics/animation/lights/airplane_generic_light_spill");} }

        /// <summary>
        ///  AIrplane taxi light.   RGB = dir, A = reserved, use 0. Units:light
        ///  Raw path: sim/graphics/animation/lights/airplane_taxi_light
        /// </summary>
        public IXPDataRef<float[]> airplane_taxi_light { get { return m_data.GetFloatArray("sim/graphics/animation/lights/airplane_taxi_light");} }

        /// <summary>
        ///  AIrplane taxi light.   RGB = dir, A = reserved, use 0. Units:light
        ///  Raw path: sim/graphics/animation/lights/airplane_taxi_light_flash
        /// </summary>
        public IXPDataRef<float[]> airplane_taxi_light_flash { get { return m_data.GetFloatArray("sim/graphics/animation/lights/airplane_taxi_light_flash");} }

        /// <summary>
        ///  AIrplane taxi light.   RGB = dir, A = reserved, use 0. Units:light
        ///  Raw path: sim/graphics/animation/lights/airplane_taxi_light_spill
        /// </summary>
        public IXPDataRef<float[]> airplane_taxi_light_spill { get { return m_data.GetFloatArray("sim/graphics/animation/lights/airplane_taxi_light_spill");} }

        /// <summary>
        ///  AIrplane spot light.   RGB = dir, A = reserved, use 0. Units:light
        ///  Raw path: sim/graphics/animation/lights/airplane_spot_light
        /// </summary>
        public IXPDataRef<float[]> airplane_spot_light { get { return m_data.GetFloatArray("sim/graphics/animation/lights/airplane_spot_light");} }

        /// <summary>
        ///  AIrplane spot light.   RGB = dir, A = reserved, use 0. Units:light
        ///  Raw path: sim/graphics/animation/lights/airplane_spot_light_flash
        /// </summary>
        public IXPDataRef<float[]> airplane_spot_light_flash { get { return m_data.GetFloatArray("sim/graphics/animation/lights/airplane_spot_light_flash");} }

        /// <summary>
        ///  AIrplane spot light.   RGB = dir, A = reserved, use 0. Units:light
        ///  Raw path: sim/graphics/animation/lights/airplane_spot_light_spill
        /// </summary>
        public IXPDataRef<float[]> airplane_spot_light_spill { get { return m_data.GetFloatArray("sim/graphics/animation/lights/airplane_spot_light_spill");} }

        /// <summary>
        ///  Airplane beacon light.   RGB = ignore, A = light number. Units:light
        ///  Raw path: sim/graphics/animation/lights/airplane_beacon_light
        /// </summary>
        public IXPDataRef<float[]> airplane_beacon_light { get { return m_data.GetFloatArray("sim/graphics/animation/lights/airplane_beacon_light");} }

        /// <summary>
        ///  Airplane navigation light.   RGB = ignore, A = reserved, use 0. Units:light
        ///  Raw path: sim/graphics/animation/lights/airplane_navigation_light
        /// </summary>
        public IXPDataRef<float[]> airplane_navigation_light { get { return m_data.GetFloatArray("sim/graphics/animation/lights/airplane_navigation_light");} }

        /// <summary>
        ///  Airplane strobe light.   RGB = ignore, A = light number. Units:light
        ///  Raw path: sim/graphics/animation/lights/airplane_strobe_light
        /// </summary>
        public IXPDataRef<float[]> airplane_strobe_light { get { return m_data.GetFloatArray("sim/graphics/animation/lights/airplane_strobe_light");} }

        /// <summary>
        ///  Airplane beacon light.   RGB = direction, A = light number. Units:light
        ///  Raw path: sim/graphics/animation/lights/airplane_beacon_light_dir
        /// </summary>
        public IXPDataRef<float[]> airplane_beacon_light_dir { get { return m_data.GetFloatArray("sim/graphics/animation/lights/airplane_beacon_light_dir");} }

        /// <summary>
        ///  Airplane navigation light.   RGB = ignored, A = reserved, use 0. Units:light
        ///  Raw path: sim/graphics/animation/lights/airplane_navigation_light_dir
        /// </summary>
        public IXPDataRef<float[]> airplane_navigation_light_dir { get { return m_data.GetFloatArray("sim/graphics/animation/lights/airplane_navigation_light_dir");} }

        /// <summary>
        ///  Airplane strobe light.   RGB = direction, A = light number. Units:light
        ///  Raw path: sim/graphics/animation/lights/airplane_strobe_light_dir
        /// </summary>
        public IXPDataRef<float[]> airplane_strobe_light_dir { get { return m_data.GetFloatArray("sim/graphics/animation/lights/airplane_strobe_light_dir");} }

        /// <summary>
        ///  Airplane beacon light.   RGB = direction, A = light number. Units:light
        ///  Raw path: sim/graphics/animation/lights/airplane_beacon_light_spill
        /// </summary>
        public IXPDataRef<float[]> airplane_beacon_light_spill { get { return m_data.GetFloatArray("sim/graphics/animation/lights/airplane_beacon_light_spill");} }

        /// <summary>
        ///  Airplane navigation light.   RGB = ignored, A = reserved, use 0. Units:light
        ///  Raw path: sim/graphics/animation/lights/airplane_navigation_light_spill
        /// </summary>
        public IXPDataRef<float[]> airplane_navigation_light_spill { get { return m_data.GetFloatArray("sim/graphics/animation/lights/airplane_navigation_light_spill");} }

        /// <summary>
        ///  Airplane strobe light.   RGB = direction, A = light number. Units:light
        ///  Raw path: sim/graphics/animation/lights/airplane_strobe_light_spill
        /// </summary>
        public IXPDataRef<float[]> airplane_strobe_light_spill { get { return m_data.GetFloatArray("sim/graphics/animation/lights/airplane_strobe_light_spill");} }

        /// <summary>
        ///  Internal panel floods, A = index. Units:light
        ///  Raw path: sim/graphics/animation/lights/airplane_panel_spill
        /// </summary>
        public IXPDataRef<float[]> airplane_panel_spill { get { return m_data.GetFloatArray("sim/graphics/animation/lights/airplane_panel_spill");} }

        /// <summary>
        ///  Internal instrument post lights, A = index. Units:light
        ///  Raw path: sim/graphics/animation/lights/airplane_inst_spill
        /// </summary>
        public IXPDataRef<float[]> airplane_inst_spill { get { return m_data.GetFloatArray("sim/graphics/animation/lights/airplane_inst_spill");} }

        /// <summary>
        ///  Airplane beacon light for rotating beacon billboard.. Units:light
        ///  Raw path: sim/graphics/animation/lights/airplane_beacon_light_rotate
        /// </summary>
        public IXPDataRef<float[]> airplane_beacon_light_rotate { get { return m_data.GetFloatArray("sim/graphics/animation/lights/airplane_beacon_light_rotate");} }

        /// <summary>
        ///  Airplane beacon light for rotating beacon spill.. Units:light
        ///  Raw path: sim/graphics/animation/lights/airplane_beacon_light_rotate_spill
        /// </summary>
        public IXPDataRef<float[]> airplane_beacon_light_rotate_spill { get { return m_data.GetFloatArray("sim/graphics/animation/lights/airplane_beacon_light_rotate_spill");} }
    }
}