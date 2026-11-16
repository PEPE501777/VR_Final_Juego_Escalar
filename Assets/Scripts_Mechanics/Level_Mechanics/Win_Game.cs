using UnityEngine;
using TMPro;
using System.Collections;
using UnityEngine.SceneManagement;

public class Win_Game : MonoBehaviour
{
    public GameObject win;
    public void Win_Game_Func()
    {
        win.SetActive(true);
        StartCoroutine(Lecture());

    }

    private IEnumerator Lecture()
    {

        yield return new WaitForSeconds(5);
        SceneManager.LoadScene(0);

    }
}
