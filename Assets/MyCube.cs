using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyCube : MonoBehaviour
{
    public void OnClickMessage()
    {
        var rotate = GetComponent<GORotate>();
        rotate.enabled = !rotate.enabled;
    }

 
}
//쓰기 완료


