using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameScene6 {
    public class TV : MonoBehaviour
    {
        public LoadText text;

        public void click() {
            text.UpdateText("ニュース番組がやってる。「今年度3回目の台風が発生いたしました」と言ってる");
            GameManager.Instance.clearGimmike(0);
        }
    }
}
