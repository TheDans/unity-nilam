using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class CustomizeModels : MonoBehaviour
{

    public GameObject[] shirtVariant;
    public GameObject[] pantsVariants;
    private int currentShirt;
    private int currentPants;

    void Update()
    {
        //shirts
        for (int i = 0; i < shirtVariant.Length; i++){
            if(i == currentShirt){
                shirtVariant[i].SetActive(true);
            } else {
                shirtVariant[i].SetActive(false);
            }
        }

        //pants
        for (int i = 0; i < pantsVariants.Length; i++){
            if(i == currentPants){
                pantsVariants[i].SetActive(true);
            } else {
                pantsVariants[i].SetActive(false);
            }
        }
    }


    public void SwitchShirts()
    {//swapping shirt
        
        if(currentShirt == shirtVariant.Length - 1){
            currentShirt = 0;
        } else {
            currentShirt ++;
        }

    }
    public void SwitchPants()
    {//swapping shirt
        
        if(currentPants == pantsVariants.Length - 1){
            currentPants = 0;
        } else {
            currentPants ++;
        }

    }
   //Call Function!
}
