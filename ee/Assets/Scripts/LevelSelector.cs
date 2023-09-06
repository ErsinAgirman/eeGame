using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelector : MonoBehaviour
{
    public void LoadSceneByIndex()
    {
        SceneManager.LoadScene(1);
    }
}
