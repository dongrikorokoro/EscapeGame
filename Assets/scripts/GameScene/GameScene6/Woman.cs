using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameScene6 {
    public class Woman : MonoBehaviour
    {
        public LoadText text;

        public void click() {
            if(GameManager.Instance.allTouchGimmike) {
                text.UpdateText("ヒント見つけたんですが、一番多い数字を4つ並べるらしいですよ");
            } else {
                text.UpdateText("これで出れるんですね！隅々まで探索しましょう");
                GameManager.Instance.clearGimmike(5);
            }
        }
    }
}
