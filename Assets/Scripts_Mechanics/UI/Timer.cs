using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;


public class Timer : MonoBehaviour
{

    public int Seconds;
    public int Maxseconds = 60;
    public bool count = true;
    public TextMeshProUGUI textScore;
    public TextMeshProUGUI textseconds;
    public static float score;
    public GameObject spawn1;
    public GameObject door;
    public bool juego;
    public End_Game ending;


    public void StarGame()
    {
        juego = true;
        Seconds = Maxseconds;
        spawn1.SetActive(true);
        door.SetActive(false);



    }

    public void EndGAME()
    {
        juego = false;
        spawn1.SetActive(false);
        ending.End_Game_Func();


    }

    // Update is called once per frame
    void Update()
    {
        if (juego)
        {
            textseconds.text = Seconds.ToString();
            if (count)
            {
                StartCoroutine(Lecture());
                Seconds = Seconds - 1;
            }
            if (Seconds == 0)
            {
                EndGAME();
            }
        }

    }

    private IEnumerator Lecture()
    {
        count = false;
        yield return new WaitForSeconds(1);
        count = true;
    }
}
