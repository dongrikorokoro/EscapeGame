using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameScene1 {
    public class Box : MonoBehaviour
    {
        public LoadText text;
        public GameObject lightOff;

        public void Clicked() {
            if(lightOff.activeSelf) {
                text.UpdateText("暗くてよく見えない");
            }
        }
    }
}
