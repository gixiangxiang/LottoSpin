using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EventContoller : MonoBehaviour
{
  [Header("設定獎品面板")]
  public GameObject settingPanel;
  [Header("設定比例面板")]
  public GameObject ratioPanel;
  [Header("開始遊戲面板")]
  public GameObject gamePanel;

  public void SetPrize_Event()
  {
    settingPanel.SetActive(true);
    ratioPanel.SetActive(false);
    gamePanel.SetActive(false);
  }

  public void SetRatio_Event()
  {
    settingPanel.SetActive(false);
    ratioPanel.SetActive(true);
    gamePanel.SetActive(false);
  }

  public void StartGame_Event()
  {
    settingPanel.SetActive(false);
    ratioPanel.SetActive(false);
    gamePanel.SetActive(true);
  }
}
