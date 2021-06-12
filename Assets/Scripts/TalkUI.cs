  using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TalkUI : MonoBehaviour
{
   public Text text;
    //1. 
    //투명 - Canvas Group 의 Alpha로 조절할 수 있음
    //스케일
    //위치이동 - 없음
    CanvasGroup canvasGroup; //2. 캔바스 그룹 : 변투명 만들어주기

    private void Start()
    {
        canvasGroup = GetComponent<CanvasGroup>(); //3. Canvas Group을 사용하겠다.


    }

    private void Update()
    {
        //4. test 해볼거임. 키보드 누르면 Alpha가 작동하는지
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            canvasGroup.alpha = 0; //알파가 0. 즉, 안보인다는 의미.

        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            canvasGroup.alpha = 1; //보임.

        }


    }



}
