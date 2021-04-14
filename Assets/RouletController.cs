using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RouletController : MonoBehaviour
{
    private GameObject target; //Raycast로 찾은 오브젝트를 저장
    public GameObject RoulletManager; //룰렛을 완성시켜주는 오브젝트
    //룰렛 관리도 해줘서 div랑 angle를 받아옴
    float rotationSpeed; //회전속도
    bool act = true; //함수를 동작시킬 지
    public int div = 0;//분할된 면의 수
    public int sector, order= 0; //분할된 면의 div번째 면
    //sector는 동작에 직접 관여하고 order은 관여안함
    public float angle = 0; //몇번째 면에 걸리는지 보기 편하려구 만든 변수
    //angle : 몇번째  div에 걸릴지 + 오차
    void Start()
    {
        act = true;
        div = RoulletManager.GetComponent<InstantiateScript>().div;
        //RoulletManager에서 div변수 받아옴
    }

    // Update is called once per frame
    void Update()
    {
        angle = RoulletManager.GetComponent<InstantiateScript>().angle;
        //RoulletManager에서 angle변수 받아옴
        transform.Rotate(0, 0, rotationSpeed);
        //rotationSpeed의 속도로 회전
        rotationSpeed *= 1-0.01f*div/(div+angle);
        //일주후 order*div만큼 추가로 이동(order : div의 순서)

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
                RoulletManager.GetComponent<InstantiateScript>().sector = order;
                //RoulletManager의 sector에 order변수를 저장
            }
            rotationSpeed = 3.6f; //회전속도 3.6도
            act = false; //마우스 클릭시 함수가 더는 작동못하게 막음
        }
    }
}
