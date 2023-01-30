using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameScene4 {
    public class CloverKeyZoom : MonoBehaviour
    {
        public LoadText text;

        public void Click() {
            text.UpdateText("クローバーのマークが描かれてる");
        }
    }
}
