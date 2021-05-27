using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    public GameObject[] canvas;
    //캔버스를 저장
    public GameObject RoulletManager;
    public GameObject[] input;
    public GameObject Button_reset;

    public Text[] set_text;
    public Text[] get_text;
    public Text text_res;

    public string[] text = new string[8];
    public int canvas_order;
    //캔버스가 나오는 순서
    public int canvas_num;
    //캔버스의 총 갯수
    public int div, sector;
    
    
    public float rotationSpeed;
    public float rnd, angle; //rnd 0과 1사이의 float형 난수
    //angle : 몇번째 면에 걸릴지 + 오차(sector + rnd - 1)
    bool act = true; //abc

    // Start is called before the first frame update
    void Start()
    {
       Button_reset.SetActive(false);
       div = NumberCounter.numeber;
       act = true;

       rnd = Random.Range(1.000f, 0.000f);
       //rnd : 0과 1사이의 float형 난수생성  

       canvas_order = 0; //초기값 설정
       canvas_num = 2;
       Canvas_changed();

    }

    // Update is called once per frame
    void Update()
    {
        angle = sector + rnd - 1; ;
        //RoulletManager에서 angle변수 받아옴
        rotationSpeed *= 1 - 0.01f * div / (div + angle);
        //일주후 order*(360도/div)만큼 추가로 이동(order : div의 순서)

        for (int i = div; i < get_text.Length; i++)
        {
            input[i].GetComponent<InputField>().interactable = false;
        }
        for (int i = 0; i < get_text.Length; i++)
        {
            if (get_text[i].text != "")
            {
                text[i] = get_text[i].text;
            }
            else
            {
                text[i] = (i + 1).ToString();
            }
        }
        
        for (int i = 0; i < text.Length; i++)
        {
                set_text[i].text = text[i];
        }
        

        if (rotationSpeed<=0.01 && !act)
        {
            Button_reset.SetActive(true);

            if (sector == 0)
            {
                text_res.text = "\"\"";
            }
            else
            {
                text_res.text = "\"" + text[sector - 1] + "\"";
            }
        }


        if (canvas_order == 2 && Input.GetMouseButtonDown(0) && act)
        {
            if (act)
            {
                rotationSpeed = 3.6f; //회전속도 3.6도
                act = false; //마우스 클릭시 함수가 한번만 동작하게 함
            }
            
        }
    }

    public void Canvas_changed() //다음 캔버스로 넘어가는 함수
    {
        if (canvas_order <= canvas_num) canvas_order++; //다음 캔버스로
        for (int i = 1; i <= canvas_num; i++)
        {
            if (canvas_order == i)
            {
                for (int n = 0; n < canvas_num; n++)
                { canvas[n].SetActive(false); } //캔버스 숨기기
                canvas[i - 1].SetActive(true);  //캔버스 만들기
            }
            RoulletManager.GetComponent<InstantiateScript>().div = div;
        } 
        
    }
   
}
