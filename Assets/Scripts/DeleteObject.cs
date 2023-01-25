using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DeleteObject : MonoBehaviour
{
    Ray ray;
    RaycastHit hit;
    public Vector3 mousepos;
    

    public void Update()
    {
        //if (DeleteButton.isButton == true)
        {
        mousepos = Input.mousePosition;
        ray = Camera.main.ScreenPointToRay(mousepos);
        if(Physics.Raycast(ray, out hit))
         {
             if(Input.GetMouseButtonDown(1))
                 Destroy(this.gameObject);
                
         }
        }  
    }

    
}
