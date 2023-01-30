using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameScene4 {
    public class ZoomHeartBox : MonoBehaviour
    {
        public LoadText text;

        public void click() {
            text.UpdateText("「君のもの」と書かれている。中身は空っぽだ");
            GameManager.Instance.clearGimmike(5);
        }
    }
}

