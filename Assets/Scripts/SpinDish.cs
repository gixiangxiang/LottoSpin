using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinDish : MonoBehaviour
{
  // 設定旋轉速度和計時器
  [SerializeField] float rotationSpeed = 50f;
  [SerializeField] float slowRatioMin = 3f;
  [SerializeField] float slowRatioMax = 3f;
  [SerializeField] float timer = 3f;

  void Start()
  {
    StartCoroutine(RotateObject());
  }

  IEnumerator RotateObject()
  {
    float slowRatio=Random.Range(slowRatioMin,slowRatioMax);
    Debug.Log(slowRatio);
    float timeElapsed = 0;
    while (true)
    {
      timeElapsed += Time.deltaTime;
      if (timeElapsed < timer)
      {
        transform.Rotate(0, 0, -rotationSpeed * Time.deltaTime);
      }
      else
      {
        rotationSpeed -= Time.deltaTime*slowRatio;
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

  void Spin()
  {
    // 開始旋轉協程
    StartCoroutine(RotateObject());
  }

}
