using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoad : MonoBehaviour
{
    Scene m_Scene;
    string sceneName;

    public void ReloadScene()
    {
        SceneManager.LoadScene(GetSceneName());
    }

    private string GetSceneName()
    {
        m_Scene = SceneManager.GetActiveScene();
        sceneName = m_Scene.name;
        return sceneName;
    }
}
