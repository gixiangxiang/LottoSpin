using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpinWheelManager : MonoBehaviour
{
    
  public Image[] pieImages;
  public float[] values;

  void Start()
  {
    SetValue(values);
  }
  

  public void SetValue(float[] valuesToSet)
  {
    float totalValues = 0;
    for (int i = 0; i < pieImages.Length; i++)
    {
      totalValues += FindPercentage(valuesToSet,i);
      pieImages[i].fillAmount=totalValues;
    }
  }

  float FindPercentage(float[] valuesToSet, int index)
  {
    float totalAmount = 0;
    for (int i = 0; i < valuesToSet.Length; i++)
    {
      totalAmount += valuesToSet[i];
    }
    return valuesToSet[index]/totalAmount;
  }
}
