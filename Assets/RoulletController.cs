using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoulletController : MonoBehaviour
{
    private GameObject target;
    public CanvasController CC;
    //룰렛 관리도 해줘서 div랑 angle를 받아옴
    public int order = 0; //분할된 면의 div번째 면
                          //sector는 동작에 직접 관여하고 order은 관여안함
    public float rotationSpeed; //회전속도
    bool act = true; //함수를 동작시킬 지

    void Start()
    {
        act = true;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 0, rotationSpeed);
        //rotationSpeed의 속도로 회전
        rotationSpeed = CC.rotationSpeed;
        //CanvasController에서 rotationSpeed를 받아옴


        if (Input.GetMouseButtonDown(0)&&act)
        {
            target = null;
            Vector2 pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            RaycastHit2D hit = Physics2D.Raycast(pos, Vector2.zero, 0f);

            if (hit.collider != null)
            {
                target = hit.collider.gameObject;  //히트 된 게임 오브젝트를 타겟으로 지정
            }
            if (target == this.gameObject)
            {
                CC.sector = order;
                //CanvasController의 sector에 order변수를 저장
            }
            act = false; //마우스 클릭시 함수가 더는 작동못하게 막음
        }
    }

}
