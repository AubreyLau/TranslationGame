using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;       //Allows us to use Lists.

public class CharacterCreator : MonoBehaviour
{

    public Button currentButton;
    public static int head;
    public static int body;
    public static int legs;
    public static int hat;

    public GameObject[] headTiles;
    public GameObject[] bodyTiles;
    public GameObject[] legsTiles;
    public GameObject[] hatTiles;

    public GameObject Head;
    public GameObject Body;
    public GameObject Legs;
    public GameObject Hat;

    // Start is called before the first frame update
    void Start()
    {
        head = 0;
        body = 0;
        legs = 0;
        hat = 0;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void GetButton()
    {
        currentButton = UnityEngine.EventSystems.EventSystem.current.currentSelectedGameObject.GetComponent<Button>();
    }

    public void GetHead()
    {
        head = (currentButton.name[12] - '0') * 10 + currentButton.name[13] - '0';
        GameObject toInstantiate = headTiles[head];
        GameObject instance =
            Instantiate(toInstantiate,Head.transform.position, Quaternion.identity) as GameObject;
        Destroy(Head);
        //Set the parent of our newly instantiated object instance to boardHolder, this is just organizational to avoid cluttering hierarchy.
        instance.transform.SetParent(this.transform);
        Head = instance;
        Head.transform.localScale = new Vector3(0.1f, 0.1f, 1.0f);
        instance.name = "Head";

    }
    public void GetBody()
    {
        body = (currentButton.name[12] - '0') * 10 + currentButton.name[13] - '0';
        GameObject toInstantiate = bodyTiles[body];
        GameObject instance =
            Instantiate(toInstantiate, Body.transform.position, Quaternion.identity) as GameObject;
        Destroy(Body);
        //Set the parent of our newly instantiated object instance to boardHolder, this is just organizational to avoid cluttering hierarchy.
        instance.transform.SetParent(this.transform);
        instance.name = "Body";
    }
    public void GetLegs()
    {
        legs = (currentButton.name[12] - '0') * 10 + currentButton.name[13] - '0';
        GameObject toInstantiate = legsTiles[legs];
        GameObject instance =
            Instantiate(toInstantiate, Legs.transform.position, Quaternion.identity) as GameObject;
        Destroy(Legs);
        //Set the parent of our newly instantiated object instance to boardHolder, this is just organizational to avoid cluttering hierarchy.
        instance.transform.SetParent(this.transform);
        instance.name = "Legs";
    }
    public void GetHat()
    {
        hat = (currentButton.name[12] - '0') * 10 + currentButton.name[13] - '0';
        GameObject toInstantiate = hatTiles[hat];
        GameObject instance =
            Instantiate(toInstantiate, Hat.transform.position, Quaternion.identity) as GameObject;
        Destroy(Hat);
        //Set the parent of our newly instantiated object instance to boardHolder, this is just organizational to avoid cluttering hierarchy.
        instance.transform.SetParent(this.transform);
        instance.name = "Hat";
    }


}
