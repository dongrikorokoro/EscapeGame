using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameScene3 {
    public class CloverKeyZoom : MonoBehaviour
    {
        public LoadText text;

        public void Click() {
            text.UpdateText("クローバーのマークが描かれてる");
        }
    }
}
