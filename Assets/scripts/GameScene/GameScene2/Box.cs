using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameScene2 {
    public class Box : MonoBehaviour
    {
        public LoadText text;
        public GameObject lightOff;
        public ZoomObject zoomObject;

        public void Clicked() {
            if(lightOff.activeSelf) {
                text.UpdateText("暗くてよく見えない");
            } else {
                zoomObject.active();
            }
        }
    }
}