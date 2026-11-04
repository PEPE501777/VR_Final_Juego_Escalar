using UnityEngine;

public class Object_Found : MonoBehaviour
{
    public float buscador = 0;
    public bool activo = false;
    public bool id_correcto = false;
    public bool correcto = false;
    public Object_Identifier reference;

    private void OnTriggerStay(Collider other)
    {
        reference = other.GetComponent<Object_Identifier>();
        if (reference != null)
        {
            activo = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (reference != null && activo == true)
        {
            if (reference.id == buscador)
            {
                correcto = true;
            }
            
        }
            
    }
}
