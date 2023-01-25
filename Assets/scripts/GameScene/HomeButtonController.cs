using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HomeButtonController : MonoBehaviour
{
    public void clicked() {
        SceneManager.LoadScene("SelectEpisodeScene",LoadSceneMode.Single);
    }
}
