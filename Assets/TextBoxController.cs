using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextBoxController : MonoBehaviour
    //�ؽ�Ʈ �ڽ��� �������ִ� ��ũ��Ʈ
{
    public CanvasController CC;
    //�귿 ������ ���༭ div�� angle�� �޾ƿ�
    float rotationSpeed;
    //rotationSpeed : ȸ�����ۼӵ�
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.RotateAround(new Vector3(360, 610, 0), Vector3.forward, rotationSpeed);
        //(360, 730, 0)�� �߽����� forward���⿡ rotationSpeed�� �ӵ��� ����;       
        rotationSpeed = CC.rotationSpeed;
        //CanvasController���� rotationSpeed�� �޾ƿ�

    }
}
