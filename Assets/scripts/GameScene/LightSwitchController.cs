using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LightSwitchController : MonoBehaviour
{
    public GameObject denkyu;
    public LightController light;
    public LoadText text;
    
    public void click() {
        if(light.clear) {
            light.changeLight();
        } else {
            if(denkyu.activeSelf) {
                text.UpdateText("反応がない...電球がついてないようだ");
            }
        }
    }
}
