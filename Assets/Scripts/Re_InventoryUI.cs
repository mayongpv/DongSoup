using System.Collections.Generic;
using System.Collections;
using System;
using UnityEngine;


public class Re_InventoryUI : MonoBehaviour
{
    public Transform blankIcon;
    //비어있는 슬롯 위치 아이콘을 10개씩 4줄로 배치하자.//블랭크 아이콘을 배치

    public List<GameObject> = new List<GameObject>
    [ContextMenu("아이콘 생성")]

    void Start()
    {
        posItems.ForEach(x => Destroy(x));

        int xCount = 10;
        int yCount = 4;
        Vector3 origialPos = blankIcon.localPosition;
        for (int y = 0; y < yCount; y++)
        {
            for (int x = 0; x < xCount; x++)
            {
                var newPos = origialPos;
                newPos.x += x * xSize;
                newPos.y += y * ySize;
                GameObject newGO = Instantiate(blankIcon.gameObject);
                newGO.transform.SetParent(transform);
                newGO.transform.localPosition = newPos;
                posItems.Add(newGO);
            }
        }
 

    }

    void Update()
    {

    }
}
