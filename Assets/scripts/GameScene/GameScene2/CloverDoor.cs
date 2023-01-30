using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameScene2 {
    public class CloverDoor : MonoBehaviour
    {
        public LoadText text;
        public GameObject lightOff;

        public void Clicked() {
            if(lightOff.activeSelf) {
                text.UpdateText("暗くてよく見えない...");
            } else {
                text.UpdateText("鍵がかかっている...。クローバーのマークがついている");
            }
        }
    }
}