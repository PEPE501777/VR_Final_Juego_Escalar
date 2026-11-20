using UnityEngine;

public class Object_Found : MonoBehaviour
{
    public float buscador = 0;
    public bool activo = false;
    public bool id_correcto = false;
    public bool correcto = false;
    public Object_Identifier reference;

    private void OnTriggerEnter(Collider other)
    {
        TrySetReference(other);
    }

    private void OnTriggerStay(Collider other)
    {
        // Stay also covers objects that were already overlapping when this
        // component became enabled or when the physics scene started.
        TrySetReference(other);
    }

    private void OnTriggerExit(Collider other)
    {
        Object_Identifier exitingObject = other.GetComponentInParent<Object_Identifier>();
        if (exitingObject != null && exitingObject == reference)
            ClearReference();
    }

    private void TrySetReference(Collider other)
    {
        // Interactable objects often have child colliders, while their
        // identifier lives on the root object.
        Object_Identifier foundObject = other.GetComponentInParent<Object_Identifier>();
        if (foundObject == null)
            return;

        reference = foundObject;
        activo = true;
        id_correcto = foundObject.id == buscador;
        correcto = id_correcto;
    }

    private void ClearReference()
    {
        reference = null;
        activo = false;
        id_correcto = false;
        correcto = false;
    }
}
