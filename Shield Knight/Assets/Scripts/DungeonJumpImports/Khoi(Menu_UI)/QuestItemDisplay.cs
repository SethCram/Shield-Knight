using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuestItemDisplay : MonoBehaviour
{
    public Image item;
    public string itemName;

    // Start is called before the first frame update
    private void Start()
    {
        if(PlayerManager.instance.QuestItemIsCollected(itemName))
        {
            item.enabled = true;
        }
        else
        {
            item.enabled = false;
        }
    }

    // Update is called once per frame
    private void Update()
    {
        if(PlayerManager.instance.QuestItemIsCollected(itemName))
        {
            item.enabled = true;
        }
        else
        {
            item.enabled = false;
        }
    }
}