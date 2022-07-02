using UnityEngine;

public class PickItem : MonoBehaviour
{
    public string itemName = "pear"; //Each item must have an unique name
    public Texture itemPreview;

    void Start()
    {
        //Change item tag to Respawn to detect when we look at it
        gameObject.tag = "Respawn";
    }

    public void PickItemFunc()
    {
        Destroy(gameObject);
    }
}
