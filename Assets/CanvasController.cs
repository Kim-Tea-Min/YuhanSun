using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class CanvasController : MonoBehaviour
{
    public GameObject[] canvas;
    //캔버스를 저장
    public int canvas_order;
    //캔버스가 나오는 순서
    public int canvas_num;
    //캔버스의 총 갯수
    public int div = 8;
    public GameObject RoulletManager;
    // Start is called before the first frame update
    void Start()
    {
       div = GameManager.numeber;
       canvas_order = 0; //초기값 설정
       canvas_num = 2;
       Canvas_changed();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Canvas_changed() //다음캔버스로 넘어가는 함수
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
    public void Canvas_back() //제작중
    {

    }

    public void Canvas_Reset()
    {
        SceneManager.LoadScene("SecondScene");
    }
}
