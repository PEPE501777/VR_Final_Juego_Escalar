using UnityEngine;
using TMPro;
using System.Collections;
using UnityEngine.SceneManagement;

public class End_Game : MonoBehaviour
{
    public void End_Game_Func()
    {

        StartCoroutine(Lecture());

    }

    private IEnumerator Lecture()
    {

        yield return new WaitForSeconds(0);
        SceneManager.LoadScene(2);

    }
}
