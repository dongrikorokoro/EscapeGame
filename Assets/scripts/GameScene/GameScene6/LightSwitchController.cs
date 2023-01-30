using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace GameScene6 {
    public class LightSwitchController : MonoBehaviour
    {
        public LightController light;
        public LoadText text;
        
        public void click() {
            light.changeLight();
        }
    }
}
