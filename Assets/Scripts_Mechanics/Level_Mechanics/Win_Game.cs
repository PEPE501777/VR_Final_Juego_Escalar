using UnityEngine;
using TMPro;
using System.Collections;
using UnityEngine.SceneManagement;

public class Win_Game : MonoBehaviour
{
    public void Win_Game_Func()
    {
        StartCoroutine(Lecture());

    }

    private IEnumerator Lecture()
    {

        yield return new WaitForSeconds(3);
        SceneManager.LoadScene(1);

    }
}
