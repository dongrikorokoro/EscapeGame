using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameScene3 {
    public class HeartKeyZoom : MonoBehaviour
    {
        public LoadText text;

        public void Click() {
        text.UpdateText("ハートのマークが描かれてる");
        }
    }
}

