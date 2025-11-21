using UnityEngine;

public class QuitButton : MonoBehaviour
{
    public void QuitApp()
    {

        Application.Quit();
        
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#endif
    }
}