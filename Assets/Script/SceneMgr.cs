using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneMgr : MonoBehaviour
{
    void OnTriggerEnter(Collider coll)
    {
        if(coll.CompareTag("MainCamera"))
        {
            SceneManager.LoadScene("03_underground");
        }
    }
}
