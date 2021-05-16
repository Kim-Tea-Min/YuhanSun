using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateScript : MonoBehaviour
{
    public GameObject[] prefab_24; //복제본을 저장
    public GameObject[] prefab_35; //복제본을 저장
    int order = 0;  //원판의 분할된 면의 제작순서
    int bt = 0;  //룰렛을 구성하는 부채꼴의 수
    public int div; //div : 총 분할할 면의 수
    // Start is called before the first frame update
    void Start()
    {
        GameObject[] prefab_24 = new GameObject[8];
        //복제본을 저장할 오브젝트 생성
        GameObject[] prefab_35 = new GameObject[7];
        //복제본을 저장할 오브젝트 생성      
    }

    // Update is called once per frame
    void Update()
    {
 
        if (div == 5 || div == 7)
            {
                for (int i = 0; i < prefab_24.Length; i++)
                    prefab_24[i].SetActive(false);
                for (order = 1; order <= div; order++)
                { 
                    for (; bt < 35 / div * order; bt++)
                    {
                        GameObject.Find("Roullet" + order.ToString() + "_35").GetComponent<RoulletController>().order = order;
                        //Roullet1부터 Roulletdiv(div는 상수)까지 order변수를 보냄
                        Instantiate(prefab_35[order - 1], new Vector3(transform.position.x, transform.position.y, transform.position.z), Quaternion.Euler(0, 0, -10.28571f * bt));
                        //-10.28571f 35분에 360도
                        //35분원을 복사하여 룰렛을 제작
                    }
                }
            }
        else{
                for (int i = 0; i < prefab_35.Length; i++)
                    prefab_35[i].SetActive(false);
                for (order = 1; order <= div; order++)
                {
                    for (; bt < 24 / div * order; bt++)
                    {
                        GameObject.Find("Roullet" + order.ToString() + "_24").GetComponent<RoulletController>().order = order;
                        //Roullet1_24부터 Roulletdiv_24(div는 상수)까지 order변수를 보냄
                        Instantiate(prefab_24[order - 1], new Vector3(transform.position.x, transform.position.y, transform.position.z), Quaternion.Euler(0, 0, -15.0f * bt));
                        //24분원을 복사하여 룰렛을 제작
                    }
                }
            }
        
    }
}
