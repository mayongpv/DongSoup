using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tree : MonoBehaviour
{
    // 3D오브젝트 클릭 이벤트 
    private void OnMouseDown()
    {
        print(transform.GetPath() + "OnClickMessage 실행");
        //플레이어가 나에게 들어와 있는 방식인가?
        //2가지 방법으로 확인 가능
    }
    private void OnTriggerEnter(Collider other)
    {
        //부딪히면 나뭇잎을 흔들어라.
        if (other.CompareTag("Player"))
        {
            Animator[] animators = GetComponentsInChildren<Animator>();
            for (int i = 0; i < animators.Length; i++)
            {
                animators[i].Play("Shake", 0, 0); 
            }
        }
    }
}
