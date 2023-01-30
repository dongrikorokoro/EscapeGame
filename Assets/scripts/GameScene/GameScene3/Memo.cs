using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameScene3 {
    public class Memo : MonoBehaviour
    {
        public ZoomObject zoomObject;
        public LoadText text;

        public void click() {
            if(GameManager.Instance.denkyuGimmike) {
                zoomObject.active();
            } else {
                text.UpdateText("暗くてよく見えない...");
            }    
        }
    }
}
