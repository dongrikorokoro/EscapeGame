using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameScene2 {
    public class HeartDoor : MonoBehaviour
    {
        public LoadText text;
        public GameObject lightOff;
        public Item.Type clearItem;

        public void Clicked() {
            bool clearGimmike = ItemBox.instance.TryUseItem(clearItem);
            if(clearGimmike) {
                text.UpdateText("鍵が開いた。男性に報告しに行こう...");
                GameManager.Instance.doorGimmike = true; 
            } else if(GameManager.Instance.doorGimmike) {
                text.UpdateText("鍵が空いている。男性に報告しに行こう");
            } else if(lightOff.activeSelf) {
                text.UpdateText("暗くてよく見えない...");
            } else {
                text.UpdateText("鍵がかかっている...。ハートのマークがついている");
            }
        }
    }
}
