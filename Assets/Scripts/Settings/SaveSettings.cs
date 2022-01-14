using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class SaveSettings
{
    public class Setting
    {
        public static float volumeSetting;
        public static float brightnessSetting = 0.7843137f;
    }

    public void getParameterVolume(float parameter)
    {
        Setting.volumeSetting = parameter;
    }
    public void getParameterBrightness(float parameter)
    {
        Setting.brightnessSetting = parameter;
    }
}
