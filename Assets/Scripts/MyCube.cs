using UnityEngine;

public class MyCube : MonoBehaviour
{
    public void OnClickMessage()
    {
        var rotate = GetComponent<GORotate>();
        rotate.enabled = !rotate.enabled;
    }


    private object i;
    public void Update()

    {
        for (int i = 0; i < 10; i++) 

        {



            Debug.Log(i);

        }


}
}
//쓰기 완료


