using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameScene4 {
    public class ZoomCloverBox : MonoBehaviour
    {
        public LoadText text;

        public void click() {
            text.UpdateText("「僕のもの」と書かれている");
            GameManager.Instance.clearGimmike(3);
        }
    }
}
