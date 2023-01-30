using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameScene4 {
    public class Doll : MonoBehaviour
    {
        public LoadText text;

        public void Clicked() {
            text.UpdateText("私たちに似ている人形のお腹が割かれている...。");
            GameManager.Instance.clearGimmike(8);
        }
    }
}
