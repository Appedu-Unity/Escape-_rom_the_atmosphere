using UnityEngine.SceneManagement;
using UnityEngine;

public class MenuManager : MonoBehaviour
{
    /// <summary>
    /// 開始遊戲
    /// </summary>
    public void StartGame()
    {
        Invoke("DelayStart", 1.3f);
    }
    private void DelayStart()
    {
        SceneManager.LoadScene("Game");
    }
    /// <summary>
    /// 離開遊戲
    /// </summary>
    public void QuitGame()
    {
        Invoke("DelayQuit", 1.5f);
    }
    private void DelayQuit()
    {
        Application.Quit();
    }
}
