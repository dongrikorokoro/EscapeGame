using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameScene2 {
    public class Cutter : MonoBehaviour
    {
        public LoadText text;
        public GameObject lightOff;
        public Item item;

        public void Clicked() {
            if(lightOff.activeSelf) {
                text.UpdateText("暗くてよく見えない");
            } else {
                ItemBox.instance.setItem(item);
                gameObject.SetActive(false);
                text.UpdateText("カッターを手に入れた");
            }
        }
    }
}
