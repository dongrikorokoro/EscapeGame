using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameScene6 {
    public class time : MonoBehaviour
    {
        public LoadText text;

        public void click() {
            text.UpdateText("時刻は3時半をさしている");
            GameManager.Instance.clearGimmike(6);
        }
    }
}
