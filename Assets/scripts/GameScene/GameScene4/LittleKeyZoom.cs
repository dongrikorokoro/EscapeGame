using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameScene4 {
    public class LittleKeyZoom : MonoBehaviour
    {
        public LoadText text;

        public void Click() {
            text.UpdateText("取っ手が懐中電灯になっている");
        }
    }
}
