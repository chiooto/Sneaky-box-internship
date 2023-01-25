using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteButton : MonoBehaviour
{
    static public bool isButton = false;

    public void ChangeButton()
    {
         isButton = !isButton;
                     
    }
}
