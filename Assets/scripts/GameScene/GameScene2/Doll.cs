using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameScene2 {
    public class Doll : MonoBehaviour
    {
        public LoadText text;
        public GameObject lightOff;
        public ZoomObject ZoomObject;

        public void Clicked() {
            if(lightOff.activeSelf) {
                text.UpdateText("暗くてよく見えない");
            } else {
                ZoomObject.active();
            }
        }
    }
}
