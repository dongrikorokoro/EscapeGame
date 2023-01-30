using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameScene5 {
    public class kakusiFloor : MonoBehaviour
    {
        public LoadText text;

        public void click() {
           text.UpdateText("こんなところに隠し扉があるなんて...");
           GameManager.Instance.clearGimmike(0);
        }
    }
}
