using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameScene6 {
    public class MemoZoom : MonoBehaviour
    {
        public LoadText text;

        public void Click() {
        text.UpdateText("「僕たちの記念日を逆にすると君の生だ！これは僕たちが例え地球の裏にいても切ることのできない糸でつながっているということなんだ！」「そうね！私達の糸は誰にも切ることができない運命なのよ！！」と書かれている");
        }
    }
}
