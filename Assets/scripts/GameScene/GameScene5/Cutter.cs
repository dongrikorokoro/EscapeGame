using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameScene5 {
    public class Cutter : MonoBehaviour
    {
        public LoadText text;
        public Item item;

        public void Clicked() {
            text.UpdateText("カッターが置いてある");
            GameManager.Instance.clearGimmike(3);
        }
    }
}
