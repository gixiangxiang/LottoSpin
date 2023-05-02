using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinDish : MonoBehaviour
{
  // 設定旋轉速度和計時器
  [Header("轉速")]
  [SerializeField] float rotationSpeed = 50f;
  [Header("減速最小值")]
  [SerializeField] float slowRatioMin = 3f;
  [Header("減速最大值")]
  [SerializeField] float slowRatioMax = 3f;
  [SerializeField] float timer = 3f;//停止時間
  public bool stop;


  void Start()
  {
    timer = Mathf.Floor(Random.Range(10f, 13f));
    // StartCoroutine(RotateObject());
  }

  public IEnumerator RotateObject()
  {
    float slowRatio = Random.Range(slowRatioMin, slowRatioMax);
    Debug.Log(slowRatio);
    float timeElapsed = 0;
    while (true)
    {
      timeElapsed += Time.deltaTime;
      if (timeElapsed < timer)
      {
        transform.Rotate(0, 0, -rotationSpeed * Time.deltaTime);
      }
      else if (stop)
      {
        rotationSpeed -= Time.deltaTime * slowRatio;
        if (rotationSpeed <= 0)
        {
          rotationSpeed = 0;
          yield break;
        }
        transform.Rotate(0, 0, -rotationSpeed * Time.deltaTime);
      }
      else
      {
        GameManager.gm.eventCtrl.stopBtn.interactable=false;//停止按鈕取消互動
        rotationSpeed -= Time.deltaTime * slowRatio;
        if (rotationSpeed <= 0)
        {
          rotationSpeed = 0;
          yield break;
        }
        transform.Rotate(0, 0, -rotationSpeed * Time.deltaTime);
      }
      yield return null;
    }
  }
}
