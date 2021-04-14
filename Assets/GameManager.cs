using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
  #region 싱글톤 적용
  private static GameManager instance;
  public static GameManager Instance
  {
    get
    {
      if (instance == null) instance = FindObjectOfType<GameManager>();
      return instance;
    }
  }

  private void Awake()
  {
    //씬에 싱글톤 오브젝트가 된 다른 GameManager 오브젝트가 있다면 
    if (Instance != this)
    {
      //파괴
      Destroy(gameObject);
    }
    DontDestroyOnLoad(gameObject);
  }

  #endregion

  public static int numeber = 2;

  void Start()
  {

  }

  // Update is called once per frame
  void Update()
  {

  }
}
