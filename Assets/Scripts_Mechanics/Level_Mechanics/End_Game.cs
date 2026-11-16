using UnityEngine;
using TMPro;
using System.Collections;
using UnityEngine.SceneManagement;

public class End_Game : MonoBehaviour
{
    public GameObject fali;
    public void End_Game_Func()
    {
         fali.SetActive(true);
        StartCoroutine(Lecture());

    }

    private IEnumerator Lecture()
    {

        yield return new WaitForSeconds(5);
        SceneManager.LoadScene(0);

    }
}
