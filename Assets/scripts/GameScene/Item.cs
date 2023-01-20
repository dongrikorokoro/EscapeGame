using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    public enum Type {
        Cube,
        Ball,
        Denkyu,
        Key1,
        Key2,
        cutter,
    }

    public Type type;
    public Sprite sprite;
}
