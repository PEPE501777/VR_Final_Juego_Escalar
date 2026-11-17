using UnityEngine;

public class Objetct_Pooling : MonoBehaviour
{

    public GameObject cubrePrefab;
    private GameObject[] cubes = new GameObject[3];

    private float[] returnIn = new float[3];
    private float nextSpawn = 5f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //Preparar cubos
        for (int i = 0; i < cubes.Length; i++)
        {
            cubes[i] = Instantiate(cubrePrefab, transform);
            cubes[i].SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        //Return. Deactivate the cubes
        for (int i = 0; i < cubes.Length; i++)
        {
            if (cubes[i].activeSelf && Time.time >= returnIn[i])
            {
                cubes[i].SetActive(false);
            }
        }


        if (Time.time >= nextSpawn)
        {
            Spawn();
            nextSpawn = Time.time + 1f;
        }
    }

    void Spawn()
    {
        for (int i = 0; i < cubes.Length; i++)
        {
            if (!cubes[i].activeSelf)
            {
                cubes[i].transform.position = new Vector3(Random.Range(0f, 18f), transform.position.y, Random.Range(-16f, 4f));
                cubes[i].SetActive(true);
                returnIn[i] = Time.time + 6f;
                return;
            }

        }
    }
}
