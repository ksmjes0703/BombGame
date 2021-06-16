using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //이거 꼭 넣기!!!

public class Button : MonoBehaviour
{
    public void Reset()
    {
        SceneManager.LoadScene("Desert");
    }
    public void Quit()
    {
        Application.Quit();
    }
}