using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tansu : MonoBehaviour
{
    public LoadText text;
    public GameObject lightOff;

    public void Clicked() {
        if(lightOff.activeSelf) {
            text.UpdateText("暗くてよく見えない");
        }
    }
}
