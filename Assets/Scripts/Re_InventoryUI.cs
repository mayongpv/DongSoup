using System.Collections.Generic;
using System.Collections;
using System;
using UnityEngine;


public class Re_InventoryUI : MonoBehaviour
{
    public Transform blankIcon;
    public float xSize = 10;
    public float ySize = 10;
    public int rowCount = 4; //가로 갯수

    //비어있는 슬롯 위치 아이콘을 10개씩 4줄로 배치하자.//블랭크 아이콘을 배치

    //public List<GameObject> = new List<GameObject>
    //[ContextMenu("아이콘 생성")]

    void Start()
    {
        //기존의 아이템을 삭제하자
        //posItems.ForEach(x => Destroy(x));

        for (int x = 0; x < rowCount; x++)
        {
            GameObject newGo = Instantiate(blankIcon.gameObject);
            newGo.transform.SetParent(transform); //ReckTransform에 있는 Go를 부모 지정할 때는 항상 SetParetn 사용해야 한다.
            float pos = x / (rowCount - 1);
            newGo.GetComponent<Animator>().Play("InventoryPos", 0);
            
        }


        //int xCount = 10;
        //int yCount = 4;
        //Vector3 origialPos = blankIcon.localPosition;
        //for (int y = 0; y < yCount; y++)
        //{
        //    for (int x = 0; x < xCount; x++)
        //    {
        //        var newPos = origialPos;
        //        newPos.x += x * xSize;
        //        newPos.y += y * ySize;
        //        GameObject newGO = Instantiate(blankIcon.gameObject);
        //        newGO.transform.SetParent(transform);
        //        newGO.transform.localPosition = newPos;
        //        //posItems.Add(newGO);
        //    }
        //}

    
    }

    void Update()
    {

    }
}
