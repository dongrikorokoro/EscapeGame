using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameScene6 {
    public class Passward : MonoBehaviour
    {
    // 正解の数値
    [SerializeField] int[] correctNumbers;

    //現在の数値:PasswardButtonのNumberを見ればいい
    [SerializeField] PasswardButton[] passwardButtons;

    // クリックするたびに現在のパネルの数値と正解を比較
    public Item getItem;
    public LoadText text;
    public PasswordPanel pasPanel;

    //クリアした時に実行する関数
    public void CheckClear()
    {
        if(IsClear() == true)
        {
            text.UpdateText("鍵が開いた");
            GameManager.Instance.doorGimmike = true;
        }
    }


    //クリアしているか判定する関数
    bool IsClear()
    {
        // 正解しているかどうか
        // =>１つでも一致しなければfalse
        // =>全てのチェックをクリアすればtrue

        for(int i=0; i<correctNumbers.Length; i++)
        {
            if (passwardButtons[i].number != correctNumbers[i])
            {
                return false;
            }
        }
        return true;
    }
}
}
