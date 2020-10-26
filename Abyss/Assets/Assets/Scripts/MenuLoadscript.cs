using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuLoadscript : MonoBehaviour
{
    //Carries the vairalbe from main menu scene to world scene
    public bool loadContinue;

    private void Awake()
    {
        loadContinue = false;
    }

    public bool getLoadcontuine()
    {
        return loadContinue;
    }

    public void setLoadcontuie(bool loaded)
    {
        loadContinue = loaded;
    }
}
