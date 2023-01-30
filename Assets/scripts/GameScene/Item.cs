using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    public enum Type {
        Cube,
        Ball,
        Denkyu,
        CloverKey,
        HeartKey,
        cutter,
        calender,
        memo,
        littleKey,
        
    }

    public Type type;
    public Sprite sprite;
}
