using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameScene5 {
    public class CloverDoor : MonoBehaviour
    {
        public LoadText text;
        public Item.Type clearItem;

        public void Clicked() {
            bool clearGimmike = ItemBox.instance.TryUseItem(clearItem);
            if(clearGimmike) {
                GameManager.Instance.clear = true;
            } else {
                text.UpdateText("クローバーのマークが書いてある扉だ。鍵がかかっている");
                GameManager.Instance.clearGimmike(10);
            }
        }
    }
}