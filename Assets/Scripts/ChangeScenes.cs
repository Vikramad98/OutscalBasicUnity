using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ChangeScenes : MonoBehaviour
{
    // Start is called before the first frame update
    public string Scene;

    public void SceneChange()
    {
        SceneManager.LoadScene(Scene);
    }
}
