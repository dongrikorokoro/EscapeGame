using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameScene5 {
    public class ItemZoom : MonoBehaviour
    {
       public LoadText text;

        public void ClickItem() {
            text.UpdateText("電球だ");
        }
    }
}
