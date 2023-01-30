using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameScene5 {
    public class Chair : MonoBehaviour
    {
        public LoadText text;

        public void click() {
            text.UpdateText("男性が縛られていた椅子だ。男性はどこに行ったのだろう？");
            GameManager.Instance.clearGimmike(1);
        }
    }
}
