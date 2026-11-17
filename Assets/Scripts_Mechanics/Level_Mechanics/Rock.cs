using UnityEngine;
using UnityEngine.SceneManagement;

public class Rock : MonoBehaviour
{
    public CharacterController characterController;
    public GameObject me;
    public End_Game end;
    
    //private void Start()
    //{
    //    end = GetComponent<End_Game>();
    //}

    //private void OnTriggerEnter(Collider other)
    //{
    //    characterController = other.GetComponent<CharacterController>();

    //    if (characterController != null)
    //    {
    //        end = GetComponent<End_Game>();
    //        end.End_Game_Func();
    //    }
    //}

    private void OnCollisionStay(Collision collision)
    {
        me.SetActive(false);
    }

}
