using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameScene4 {
    public class HeartDoor : MonoBehaviour
    {
        public LoadText text;

        public void click() {
            text.UpdateText("ハートのマークが書いてある扉だ。近づくのはやめておこう...");
            GameManager.Instance.clearGimmike(6);
        }
    }
}
