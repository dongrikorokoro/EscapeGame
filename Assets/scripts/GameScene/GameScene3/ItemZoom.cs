using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameScene3 {
    public class ItemZoom : MonoBehaviour
    {
       public LoadText text;

        public void ClickItem() {
            if(GameManager.Instance.memoGimmike) {
                text.UpdateText("中に何かある...。");
                GameManager.Instance.clear = true;
            } else {
                text.UpdateText("電球だ");
            }
        }
    }
}
