using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class ChangeFocus : MonoBehaviour
{
    public GameObject target;
    

    void OnMouseDown()
    {

        LookAt.target = target;
        Camera.main.fieldOfView = Mathf.Clamp(60 * target.transform.localScale.x, 1, 100);


    }
}
