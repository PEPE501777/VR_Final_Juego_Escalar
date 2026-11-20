using UnityEngine;

public class Final_Check : MonoBehaviour
{
    public Object_Found ref1;
    public Object_Found ref2;
    public Object_Found ref3;
    public Object_Found ref4;
    public Win_Game win;
    private bool winTriggered;

    public void Win()
    {
        if (winTriggered || win == null)
            return;

        winTriggered = true;
        win.Win_Game_Func();
    }




    public void Update()
    {
        if (!winTriggered && ref1 != null && ref2 != null && ref3 != null && ref4 != null &&
            ref1.correcto && ref2.correcto && ref3.correcto && ref4.correcto)
        {
            Win();
        }
    }


}
