using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonScripts : MonoBehaviour
{
    public void closeInventory()
    {
        GameObject.Find("InventoryView").gameObject.SetActive(false);
    }
}
