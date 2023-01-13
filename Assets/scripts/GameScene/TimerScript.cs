using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TimerScript : MonoBehaviour
{
    private float totalTime;
    private int minute;
    private float seconds;
    //前のupdateの時の秒数
    private float oldSeconds;
    //タイマー表示用テキスト
    private TextMeshProUGUI timerText;

    void Start() {
        minute = 10;
        seconds = 0f;
        totalTime = minute * 60 + seconds;
        oldSeconds = 0f;
        timerText = GetComponentInChildren<TextMeshProUGUI>();
    }

    void Update() {
        if(totalTime <= 0f) {
            return;
        }
        totalTime = minute * 60 + seconds;
        totalTime -= Time.deltaTime;

        minute = (int)totalTime/60;
        seconds = totalTime - minute * 60;
        if(seconds >= 60f) {
            minute++;
            seconds = seconds - 60;
        }
        //値が変わった時だけテキストUIを更新
        if((int)seconds != (int)oldSeconds) {
            timerText.text = minute.ToString("00") + ":" + ((int) seconds).ToString("00");
        }
        oldSeconds = seconds;
        if(totalTime <= 0f) {
            Debug.Log("制限時間終了");
        }
    }
}
