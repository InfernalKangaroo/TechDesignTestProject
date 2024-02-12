using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene_change : MonoBehaviour
{
    public int SceneNumber;
  public void Transition()
    {
        SceneManager.LoadScene(SceneNumber);
    }
}
