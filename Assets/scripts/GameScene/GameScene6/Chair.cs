using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameScene6 {
    public class Chair : MonoBehaviour
    {
        public LoadText text;

        public void click() {
            text.UpdateText("男性が縛られていた椅子だ");
        }
    }
}
