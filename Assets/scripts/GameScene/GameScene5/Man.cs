using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameScene5 {
    public class Man : MonoBehaviour
    {
        public LoadText text;
        
        public void click() {
            if(GameManager.Instance.allTouchGimmike) {
                text.UpdateText("思い出した！僕の誕生日は10月20日だ！もしかして、僕の誕生日と君の誕生日を合わせた数字だったりして");
            } else {
                text.UpdateText("僕の誕生日はたしか、10月だった気がする...");
            }
        }
    }
}
