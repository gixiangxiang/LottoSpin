using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EventContoller : MonoBehaviour
{
  public GameObject settingPanel;
  public GameObject ratioPanel;

  public void SetPrize_Event()
  {
    settingPanel.SetActive(true);
    ratioPanel.SetActive(false);
  }

  public void SetRatio_Event()
  {
    settingPanel.SetActive(false);
    ratioPanel.SetActive(true);
  }
}
