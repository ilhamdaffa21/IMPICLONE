using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BrightLoad : MonoBehaviour
{
    Image brightfade;
    // Start is called before the first frame update
    void Start()
    {
        if (SaveSettings.Setting.brightnessSetting != null)
        {
            SaveSettings.Setting.brightnessSetting = SaveSettings.Setting.brightnessSetting;
        }
        brightfade = GetComponent<Image>();
        brightfade.color = new Color(brightfade.color.r, brightfade.color.g, brightfade.color.b, SaveSettings.Setting.brightnessSetting);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
