using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextBoxController : MonoBehaviour
    //텍스트 박스를 움직여주는 스크립트
{
    bool act = true; // 박스를 움직여주는 함수가 동작할지를 결정
    int div; // 룰렛을 div등분함
    float rotationSpeed, angle;
    //rotationSpeed : 회전시작속도 , angle : 몇번째  div에 걸릴지 + 오차
    public GameObject RoulletManager;//룰렛을 완성시켜주는 오브젝트 
    //룰렛 관리도 해줘서 div랑 angle를 받아옴
    // Start is called before the first frame update
    void Start()
    {
        div = RoulletManager.GetComponent<InstantiateScript>().div;
        //RoulletManager에서 div변수 받아옴
    }

    // Update is called once per frame
    void Update()
    {
        angle = RoulletManager.GetComponent<InstantiateScript>().angle;
        //RoulletManager에서 angle변수 받아옴
        transform.RotateAround(new Vector3(360, 730, 0), Vector3.forward, rotationSpeed);
        //(360, 730, 0)을 중심으로 forward방향에 rotationSpeed의 속도로 공전;
        rotationSpeed *= 1 - 0.01f * div / (div + angle);
        //일주후 order*div만큼 추가로 이동(order : div의 순서)

        if (Input.GetMouseButtonDown(0) && act)
            //마우스 왼쪽버튼을 누르고 act가 true일때
        {
            rotationSpeed = 3.6f;
            act = false; // 버튼을 눌렀을 때 함수가 작동 못하게 막음
        }
    }
}
