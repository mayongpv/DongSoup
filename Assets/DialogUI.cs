using UnityEngine;
using UnityEngine.UI;

public class DialogUI : MonoBehaviour
{
    public Text text;
    CanvasGroup canvasGroup;

    //투명 - 나타날 땐 안하고 사라질 때 있음 - 캔바스 그룹 이용
    //위치 이동
    // 

    void Start()
    {
        canvasGroup = GetComponent<CanvasGroup>();
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))

            canvasGroup.alpha = 0;

        if (Input.GetKeyDown(KeyCode.Alpha2))

            canvasGroup.alpha = 1;

        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            canvasGroup.alpha = 0;
            canvasGroup.DOFade(0, duration);

        }
    }

}
