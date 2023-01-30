using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameScene6 {
    public class Door : MonoBehaviour
    {
        public LoadText text;

        public void click() {
            text.UpdateText("入ってきたドアだ");
            GameManager.Instance.clearGimmike(1);
        }
    }
}

