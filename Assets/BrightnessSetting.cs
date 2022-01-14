using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BrightnessSetting : MonoBehaviour
{
    Slider brightslider;
    public Image brightfade;
    // Start is called before the first frame update
    void Start()
    {
        brightslider = GetComponent<Slider>();
        //if(SaveSettings.Setting.brightnessSetting == null)
        //{
        //    brightslider.value = brightfade.color.a;
        //}
        //if (SaveSettings.Setting.brightnessSetting != null)
        //{
            brightslider.value = SaveSettings.Setting.brightnessSetting;
        //}

        print(brightslider.value);
    }

    // Update is called once per frame
    void Update()
    {
        print(SaveSettings.Setting.brightnessSetting);
        brightfade.color = new Color(brightfade.color.r, brightfade.color.g, brightfade.color.b, brightslider.value);
        SaveSettings.Setting.brightnessSetting = brightslider.value;
    }
}
