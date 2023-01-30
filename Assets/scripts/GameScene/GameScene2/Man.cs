using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace GameScene2 {
    public class Man : MonoBehaviour
    {
        public LoadText text;

        public void click() {
            if(GameManager.Instance.doorGimmike) {
                GameManager.Instance.clear = true;
            } else if(GameManager.Instance.boxGimmike) {
                text.UpdateText("記号と同じ場所の鍵が開きそうじゃないかな？");
            } else if(GameManager.Instance.dollGimmike) {
                text.UpdateText("メモとカレンダーを見たら箱の番号がわかりそう");
            } else {
                text.UpdateText("僕たちに似てる人形に縫い目がついていて不気味だよ");
            }
        }
    }
}
