using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NavMove : MonoBehaviour
{
    public NavMeshAgent agent;
    public Transform follower;


    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }
    public LayerMask layer;
     void Update()
    {
        if (Input.GetKey(KeyCode.Mouse0))
        {
            var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out RaycastHit hiteData, 1000, layer)) //인라인 변수 선언
            {
                agent.destination = hiteData.point;
            }
        }
    }
}

  