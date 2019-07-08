using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonStyle01 : MonoBehaviour
{
    bool isSelected;
    // Start is called before the first frame update
    void Start()
    {
        isSelected = false;
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void OnHover()
    {
        this.transform.localScale = new Vector3(1.3f, 1.3f, 1.0f);
    }
    public void OnExit()
    {
        if (!isSelected)
        this.transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);
    }
    public void OnSelected()
    {
        this.transform.localScale = new Vector3(1.2f, 1.2f, 1.2f);
        isSelected = true;
    }
    public void OnDeSelected()
    {
        isSelected = false;
        this.transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);
    }

}
