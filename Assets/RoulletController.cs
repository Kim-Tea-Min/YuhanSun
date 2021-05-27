using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoulletController : MonoBehaviour
{
    private GameObject target;
    public CanvasController CC;
    //�귿 ������ ���༭ div�� angle�� �޾ƿ�
    public int order = 0; //���ҵ� ���� div��° ��
                          //sector�� ���ۿ� ���� �����ϰ� order�� ��������
    public float rotationSpeed; //ȸ���ӵ�
    bool act = true; //�Լ��� ���۽�ų ��

    void Start()
    {
        act = true;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 0, rotationSpeed);
        //rotationSpeed�� �ӵ��� ȸ��
        rotationSpeed = CC.rotationSpeed;
        //CanvasController���� rotationSpeed�� �޾ƿ�


        if (Input.GetMouseButtonDown(0)&&act)
        {
            target = null;
            Vector2 pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            RaycastHit2D hit = Physics2D.Raycast(pos, Vector2.zero, 0f);

            if (hit.collider != null)
            {
                target = hit.collider.gameObject;  //��Ʈ �� ���� ������Ʈ�� Ÿ������ ����
            }
            if (target == this.gameObject)
            {
                CC.sector = order;
                //CanvasController�� sector�� order������ ����
            }
            act = false; //���콺 Ŭ���� �Լ��� ���� �۵����ϰ� ����
        }
    }

}
