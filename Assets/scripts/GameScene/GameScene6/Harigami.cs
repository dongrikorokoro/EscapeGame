using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameScene6 {
    public class Harigami : MonoBehaviour
    {
        public LoadText text;

        public void click() {
            text.UpdateText("これで最後か....");
            GameManager.Instance.clearGimmike(4);
        }
    }
}
