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
        brightslider.value = brightfade.color.a;
    }

    // Update is called once per frame
    void Update()
    {
        brightfade.color = new Color(brightfade.color.r, brightfade.color.g, brightfade.color.b, brightslider.value);
    }
}
