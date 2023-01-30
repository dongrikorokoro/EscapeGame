using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameScene4 {
    public class CloverDoor : MonoBehaviour
    {
        public LoadText text;

        public void Clicked() {
            text.UpdateText("クローバーのマークが書いてある扉だ。鍵がかかっている");
            GameManager.Instance.clearGimmike(10);
        }
    }
}