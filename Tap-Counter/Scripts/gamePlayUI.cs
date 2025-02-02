using UnityEngine;
using UnityEngine.UI;

public class gamePlayUI : MonoBehaviour
{
    public GameObject tapCountText;
    public gameManager gameManager;
    void Start()
    {
        
    }

    public void BackBtnClicked()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(0);
    }

    public void updateTapCountText()
    {
        tapCountText.GetComponent<Text>().text = gameManager.tapCount.ToString();
    }
}
