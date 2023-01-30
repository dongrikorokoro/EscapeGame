using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace GameScene4 {
    public class LightSwitchController : MonoBehaviour
    {
        public LoadText text;
        
        public void click() {
            text.UpdateText("反応がない...");
            GameManager.Instance.clearGimmike(7);
        }
    }
}
