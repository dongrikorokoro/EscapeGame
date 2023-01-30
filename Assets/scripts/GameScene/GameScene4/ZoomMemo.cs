using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameScene4 {
    public class ZoomMemo : MonoBehaviour
    {
        public LoadText text;
        
        public void click() {
            text.UpdateText("暗くて見えずらいが「過去の光が今の心強い光となる」と書かれている");
        }
    }
}
