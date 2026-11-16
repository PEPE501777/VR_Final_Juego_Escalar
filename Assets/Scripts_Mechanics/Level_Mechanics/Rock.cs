using UnityEngine;
using UnityEngine.SceneManagement;

public class Rock : MonoBehaviour
{
    public CharacterController characterController;
    public GameObject me;
    public End_Game end;

   
    private void OnTriggerEnter(Collider other)
    {
        characterController = other.GetComponent<CharacterController>();

        if (characterController != null)
        {
            end.End_Game_Func();
        }
    }
    private void OnCollisionStay(Collision collision)
    {
        me.SetActive(false);
    }

}
