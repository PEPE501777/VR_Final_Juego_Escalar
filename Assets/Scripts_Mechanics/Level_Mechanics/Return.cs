using UnityEngine;
using TMPro;
using System.Collections;
using UnityEngine.SceneManagement;

public class Return : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        StartCoroutine(Lecture());
    }
    private IEnumerator Lecture()
    {

        yield return new WaitForSeconds(5);
        SceneManager.LoadScene(0);

    }

}
