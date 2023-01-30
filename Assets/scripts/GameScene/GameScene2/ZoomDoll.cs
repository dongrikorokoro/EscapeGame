using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameScene2 {
    public class ZoomDoll : MonoBehaviour
    {
        public LoadText text;
        public Item.Type clearItem;
        public Item getItem;

        public void click() {
            bool clearGimmike = ItemBox.instance.TryUseItem(clearItem);
            if(clearGimmike) {
                text.UpdateText("メモ帳が入ってた。");
                ItemBox.instance.setItem(getItem);
                GameManager.Instance.dollGimmike = true;
            } else if(GameManager.Instance.dollGimmike) {
                text.UpdateText("私たちに似ている...。お腹が割かれている。");
            } else {
                text.UpdateText("私たちに似ている...。お腹が縫い合わせられている。");
            }
            
        }
    }
}
