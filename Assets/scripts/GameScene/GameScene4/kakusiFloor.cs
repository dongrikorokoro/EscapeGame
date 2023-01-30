using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameScene4 {
    public class kakusiFloor : MonoBehaviour
    {
        public LoadText text;
        public Item.Type clearItem;

        public void click() {
            if(GameManager.Instance.allTouchGimmike) {
                bool clearGimmike = ItemBox.instance.TryUseItem(clearItem);
                if(clearGimmike) {
                    GameManager.Instance.clear = true;
                } else {
                    text.UpdateText("呼びかけると「・・・ッッ」と聞こえてくる。隠し扉になっていてよく見ると鍵がかかっている");
                }
            }
        }
    }
}
