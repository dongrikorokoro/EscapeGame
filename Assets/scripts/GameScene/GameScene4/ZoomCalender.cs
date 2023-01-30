using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameScene4 {
    public class ZoomCalender : MonoBehaviour
    {
        public LoadText text;

        public void click() {
            text.UpdateText("8月16日に〇がついてる");
            GameManager.Instance.clearGimmike(4);
        }
    }
}
