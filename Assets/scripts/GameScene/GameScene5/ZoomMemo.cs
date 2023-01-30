using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameScene5 {
    public class ZoomMemo : MonoBehaviour
    {
        public LoadText text;
        
        public void click() {
            text.UpdateText("男の名前がケント、女の名前がミカ");
        }
    }
}
