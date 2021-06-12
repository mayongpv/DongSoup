using DG.Tweening;
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

    public float duration = 1; //6. 시간을 나타내는 변수 생성
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
        //5. 이걸 하려는게 아니라 서서히 시간을 두고 나타나는 걸 원함
        // Courtine을 이용하나? 할 수 있다. 하지만 Courtine 보다 더 간단한게 있음.
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            //시간을 두고 사라졌다가 서서히 나타나자.-> 시간 변수 필요

            /*8.처음엔 아예 안보이게 하자 
             */
            canvasGroup.alpha = 0;
            /*7. DoTween 이용할거임. 있다면 Canvas Group 관련 트위닝 할 수 있는 기능이 있다.
             1 = 보인다, duration : 시간값
             */
            canvasGroup.DOFade(1, duration);
            //즉, 숫자 3을 누으면 처음엔 안보이다가 점점 
        }
        //9. 반대의 경우 처음엔 보이다가 점점 안보이게 하기
        if (Input.GetKeyDown(KeyCode.Alpha4)) 
        {
            canvasGroup.alpha = 1;
            canvasGroup.DOFade(0, duration);
        }


    }



}
