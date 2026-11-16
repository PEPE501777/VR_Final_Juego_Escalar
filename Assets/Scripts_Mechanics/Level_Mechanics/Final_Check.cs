using UnityEngine;

public class Final_Check : MonoBehaviour
{
    public Object_Found ref1;
    public Object_Found ref2;
    public Object_Found ref3;
    public Object_Found ref4;
    public Win_Game win;

    public void Win()
    {
        win.Win_Game_Func();
    }




    public void Update()
    {
        if ((ref1.correcto && ref2.correcto) && (ref3.correcto && ref4.correcto))
        {
            Win();
        }
    }


}
