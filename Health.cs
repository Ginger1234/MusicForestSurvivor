using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Health : MonoBehaviour
{
    public int health;
    public int numOfHearts;
    public Image [] hearts;
    public Sprite fullHeart;
    public Sprite emptyHeart;

    void Update(){
        if (health > numOfHearts){
            health =numOfHearts;
        }
        for (int i =0; i<hearts.Length; i++){
            if (i <health){
                hearts[i].sprite=fullHeart;
               // hearts[i].color = new Color32(255,255,225,225);
            } else {
                hearts[i].sprite=emptyHeart;
             //   hearts[i].color = new Color32(255,255,225,100);

            }
            if (i< numOfHearts){
                hearts[i].enabled = true;
            } else {
                hearts[i].enabled = false;
            }
        }

    }
    
}
