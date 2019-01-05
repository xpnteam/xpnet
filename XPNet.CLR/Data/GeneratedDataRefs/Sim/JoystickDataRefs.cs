using System;
using System.Collections.Generic;
using System.Text;

namespace XPNet.Data
{
    public class Sim_JoystickDatarefs
    {
        private readonly IXPlaneData m_data;

        internal Sim_JoystickDatarefs(IXPlaneData data)
        {
            m_data = data;
        }

        /// <summary>
        ///  The deflection of the joystick axis controlling pitch. Use override_joystick or override_joystick_pitch. Units:[-1..1]
        /// </summary>
        public IXPDataRef<float> Yoke_pitch_ratio => m_data.GetFloat("sim/joystick/yoke_pitch_ratio");

        /// <summary>
        ///  Legacy - this spelling error is still present for. Units:[-1..1]
        /// </summary>
        public IXPDataRef<float> Yolk_pitch_ratio => m_data.GetFloat("sim/joystick/yolk_pitch_ratio");

        /// <summary>
        ///  The deflection of the joystick axis controlling roll. Use override_joystick or override_joystick_roll. Units:[-1..1]
        /// </summary>
        public IXPDataRef<float> Yoke_roll_ratio => m_data.GetFloat("sim/joystick/yoke_roll_ratio");

        /// <summary>
        ///  Legacy - this spelling error is still present for backward compatibility with older plugins.. Units:[-1..1]
        /// </summary>
        public IXPDataRef<float> Yolk_roll_ratio => m_data.GetFloat("sim/joystick/yolk_roll_ratio");

        /// <summary>
        ///  The deflection of the joystick axis controlling yaw. Use override_joystick or override_joystick_heading. Units:[-1..1]
        /// </summary>
        public IXPDataRef<float> Yoke_heading_ratio => m_data.GetFloat("sim/joystick/yoke_heading_ratio");

        /// <summary>
        ///  Legacy - this spelling error is still present for backward compatibility with older plugins.. Units:[-1..1]
        /// </summary>
        public IXPDataRef<float> Yolk_heading_ratio => m_data.GetFloat("sim/joystick/yolk_heading_ratio");

        /// <summary>
        ///  The artificial stability input modifications for pitch. Use override_artstab. Units:[-1..1]
        /// </summary>
        public IXPDataRef<float> Artstab_pitch_ratio => m_data.GetFloat("sim/joystick/artstab_pitch_ratio");

        /// <summary>
        ///  The artificial stability input modifications for roll. Use override_artstab. Units:[-1..1]
        /// </summary>
        public IXPDataRef<float> Artstab_roll_ratio => m_data.GetFloat("sim/joystick/artstab_roll_ratio");

        /// <summary>
        ///  The artificial stability input modifications for yaw. Use override_artstab. Units:[-1..1]
        /// </summary>
        public IXPDataRef<float> Artstab_heading_ratio => m_data.GetFloat("sim/joystick/artstab_heading_ratio");

        /// <summary>
        ///  Servo input for pitch. Units:[-1..1]
        /// </summary>
        public IXPDataRef<float> Servo_pitch_ratio => m_data.GetFloat("sim/joystick/servo_pitch_ratio");

        /// <summary>
        ///  Servo input for roll. Units:[-1..1]
        /// </summary>
        public IXPDataRef<float> Servo_roll_ratio => m_data.GetFloat("sim/joystick/servo_roll_ratio");

        /// <summary>
        ///  Servo input for yaw. Units:[-1..1]
        /// </summary>
        public IXPDataRef<float> Servo_heading_ratio => m_data.GetFloat("sim/joystick/servo_heading_ratio");

        /// <summary>
        ///  Flight Control Heading (sum of yoke plus artificial stability). Units:[-1..1]
        /// </summary>
        public IXPDataRef<float> FC_hdng => m_data.GetFloat("sim/joystick/fc_hdng");

        /// <summary>
        ///  Flight Control Pitch (sum of yoke plus artificial stability). Units:[-1..1]
        /// </summary>
        public IXPDataRef<float> FC_ptch => m_data.GetFloat("sim/joystick/fc_ptch");

        /// <summary>
        ///  Flight Control Roll (sum of yoke plus artificial stability). Units:[-1..1]
        /// </summary>
        public IXPDataRef<float> FC_roll => m_data.GetFloat("sim/joystick/fc_roll");

        /// <summary>
        ///  The nullzone size for the pitch axis (as of 940, one null zone serves all 3 axes). Units:ratio
        /// </summary>
        public IXPDataRef<float> Joystick_pitch_nullzone => m_data.GetFloat("sim/joystick/joystick_pitch_nullzone");

        /// <summary>
        ///  The nullzone size for the roll axis. Units:ratio
        /// </summary>
        public IXPDataRef<float> Joystick_roll_nullzone => m_data.GetFloat("sim/joystick/joystick_roll_nullzone");

        /// <summary>
        ///  The nullzone size for the heading axis. Units:ratio
        /// </summary>
        public IXPDataRef<float> Joystick_heading_nullzone => m_data.GetFloat("sim/joystick/joystick_heading_nullzone");

        /// <summary>
        ///  Joystick center for pitch axis. Units:ratio
        /// </summary>
        public IXPDataRef<float> Joystick_pitch_center => m_data.GetFloat("sim/joystick/joystick_pitch_center");

        /// <summary>
        ///  Joystick center for roll axis. Units:ratio
        /// </summary>
        public IXPDataRef<float> Joystick_roll_center => m_data.GetFloat("sim/joystick/joystick_roll_center");

        /// <summary>
        ///  Joystick center for heading axis. Units:ratio
        /// </summary>
        public IXPDataRef<float> Joystick_heading_center => m_data.GetFloat("sim/joystick/joystick_heading_center");

        /// <summary>
        ///  Amount of artificial stability to add to the pitch.  This is AS set by user, not in Plane-Maker.. Units:ratio
        /// </summary>
        public IXPDataRef<float> Joystick_pitch_augment => m_data.GetFloat("sim/joystick/joystick_pitch_augment");

        /// <summary>
        ///  Amount of artificial stability to add to the roll.  This is AS set by user, not in Plane-Maker.. Units:ratio
        /// </summary>
        public IXPDataRef<float> Joystick_roll_augment => m_data.GetFloat("sim/joystick/joystick_roll_augment");

        /// <summary>
        ///  Amount of artificial stability to add to the heading.  This is AS set by user, not in Plane-Maker.. Units:ratio
        /// </summary>
        public IXPDataRef<float> Joystick_heading_augment => m_data.GetFloat("sim/joystick/joystick_heading_augment");

        /// <summary>
        ///  The sensitivity for the pitch axis (the power ratio). Units:ratio
        /// </summary>
        public IXPDataRef<float> Joystick_pitch_sensitivity => m_data.GetFloat("sim/joystick/joystick_pitch_sensitivity");

        /// <summary>
        ///  The sensitivity for the roll axis. Units:ratio
        /// </summary>
        public IXPDataRef<float> Joystick_roll_sensitivity => m_data.GetFloat("sim/joystick/joystick_roll_sensitivity");

        /// <summary>
        ///  The sensitivity for the heading axis. Units:ratio
        /// </summary>
        public IXPDataRef<float> Joystick_heading_sensitivity => m_data.GetFloat("sim/joystick/joystick_heading_sensitivity");

        /// <summary>
        ///  The deflection of this joystick [Was 15 before 850][Was 24 before 860][was 32 before 900]. Units:ratio
        /// </summary>
        public IXPDataRef<float[]> Joystick_axis_values => m_data.GetFloatArray("sim/joystick/joystick_axis_values");

        /// <summary>
        ///  Min raw value ever seen [Was 15 before 850][Was 24 before 860][was 32 before 900]. Units:ratio
        /// </summary>
        public IXPDataRef<float[]> Joystick_axis_minimum => m_data.GetFloatArray("sim/joystick/joystick_axis_minimum");

        /// <summary>
        ///  Max raw value ever seen [Was 15 before 850][Was 24 before 860][was 32 before 900]. Units:ratio
        /// </summary>
        public IXPDataRef<float[]> Joystick_axis_maximum => m_data.GetFloatArray("sim/joystick/joystick_axis_maximum");

        /// <summary>
        ///  Fully processed ratio for each axis - either -1 to 1 or 0 to 1.. Units:float
        /// </summary>
        public IXPDataRef<float[]> Joy_mapped_axis_value => m_data.GetFloatArray("sim/joystick/joy_mapped_axis_value");
    }
}