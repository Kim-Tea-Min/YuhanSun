using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextBoxController : MonoBehaviour
    //텍스트 박스를 움직여주는 스크립트
{
    public CanvasController CC;
    //룰렛 관리도 해줘서 div랑 angle를 받아옴
    float rotationSpeed;
    //rotationSpeed : 회전시작속도
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.RotateAround(new Vector3(360, 610, 0), Vector3.forward, rotationSpeed);
        //(360, 730, 0)을 중심으로 forward방향에 rotationSpeed의 속도로 공전;       
        rotationSpeed = CC.rotationSpeed;
        //CanvasController에서 rotationSpeed를 받아옴

    }
}
