using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameScene2 {
    public class ZoomBox : MonoBehaviour
    {
        public LoadText text;

        public void click() {
            text.UpdateText("「僕のもの」と書かれている");
        }
    }
}
