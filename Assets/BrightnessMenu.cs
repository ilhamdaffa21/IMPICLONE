using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BrightnessMenu : MonoBehaviour
{
    Slider brightslider;
    // Start is called before the first frame update
    void Start()
    {
        brightslider = GetComponent<Slider>();
        brightslider.value = SaveSettings.Setting.brightnessSetting;

    }

    // Update is called once per frame
    void Update()
    {
        SaveSettings.Setting.brightnessSetting = brightslider.value;
    }
}
