using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public int x = 1;
    public void NextScene()
    {
        SceneManager.LoadScene(x);
    }
}
