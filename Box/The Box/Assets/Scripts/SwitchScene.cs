using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class SwitchScene : MonoBehaviour
{
    [SerializeField] int combatScene = 1;

    public void SwitchToNextScene()
    {
        SceneManager.LoadScene(combatScene);
    }

}
