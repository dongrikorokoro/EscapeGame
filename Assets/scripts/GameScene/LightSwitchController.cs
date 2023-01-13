using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LightSwitchController : MonoBehaviour
{
    public Image light;
    public Sprite lightOn;
    public Sprite lightOff;
    private bool isLight;
    public GameObject lightGround;

    void start() {
        light = GameObject.Find("light").GetComponent<Image>();
        isLight = false;
    }

    public void click() {
        if(isLight == false) {
            isLight = true;
            light.sprite = lightOn;
            lightGround.SetActive(false);
        } else {
            isLight = false;
            light.sprite = lightOff;
            lightGround.SetActive(true);
        }
    }
}
