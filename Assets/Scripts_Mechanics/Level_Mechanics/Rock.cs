using UnityEngine;
using UnityEngine.SceneManagement;

public class Rock : MonoBehaviour
{
    public CharacterController characterController;
    public GameObject me;

   
    private void OnTriggerEnter(Collider other)
    {
        characterController = other.GetComponent<CharacterController>();

        if (characterController != null)
        {

        }
    }
    private void OnCollisionStay(Collision collision)
    {
        me.SetActive(false);
    }

}
