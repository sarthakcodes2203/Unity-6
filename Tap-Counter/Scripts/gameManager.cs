using UnityEngine;
using UnityEngine.UI;

public class gameManager : MonoBehaviour
{

    public int tapCount;

    public gamePlayUI gamePlayUI;
    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            tapCount++;

            gamePlayUI.updateTapCountText();
            Debug.Log("Mouse Clicked:"+tapCount);
        }

    }
}
