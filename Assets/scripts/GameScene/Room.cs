using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Room : MonoBehaviour
{
    public GameObject[] rooms;
    private int now = 0;

    public void move(string direction) {
        rooms[now].SetActive(false);

        if(direction == "right") {
            now++;
        } else {
            now--;
        }
        if(now > 3) {
            now = 0;
        } else if(now < 0) {
            now = 3;
        }
        rooms[now].SetActive(true);
    }
}
