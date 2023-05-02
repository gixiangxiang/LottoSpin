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

  [Header("----遊戲控制面板----")]
  [Header("開始遊戲面板")]
  public GameObject gamePanel;
  [Header("開始按鈕")]
  public Button startBtn;
  [Header("停止按鈕")]
  public Button stopBtn;
  [Header("轉盤腳本")]
  public SpinDish dish;
  [SerializeField] int showStop = 5;


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
    startBtn.gameObject.SetActive(true);
    stopBtn.gameObject.SetActive(false);
  }

  public void Rolling_Event()
  {
    startBtn.gameObject.SetActive(false);
    stopBtn.gameObject.SetActive(true);
    stopBtn.interactable = false;
    StartCoroutine(dish.RotateObject());
    StartCoroutine(WaitSecond());    
  }

  public void StopRoll_Event()
  {
    stopBtn.interactable = false;
    dish.stop = true;
  }

  public IEnumerator WaitSecond()
  {    
    while (showStop > 0)
    {
      showStop--;
      yield return new WaitForSeconds(1);
    }
    stopBtn.interactable = true;
  }


  
}
