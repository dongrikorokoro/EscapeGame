using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameScene2 {
    public class CutterZoom : MonoBehaviour
    {
        public LoadText text;

        public void Click() {
        text.UpdateText("カッターだ。切れ味がよさそうだ");
        }
    }
}
