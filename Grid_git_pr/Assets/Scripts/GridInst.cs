using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GridInst : MonoBehaviour
{
    
    public GameObject Letter;
    
    public int rows;
    
    public int cols;

    public InputField InputFieldWidth;
    public InputField InputFieldHeight;

    public Button generateButton;

       
    public float tileSize = 1;

    

    public void GenerateGrid()
    {
        
        GameObject referenceTile = (GameObject)Instantiate(Letter);

        for (int row = 0; row < rows; row++)
        {
            for (int col = 0; col < cols; col++)
            {
                GameObject tile = (GameObject)Instantiate(referenceTile, transform);

                float posX = col * tileSize;
                float posY = row * -tileSize;

                tile.transform.position = new Vector2(posX, posY);
            }
        }
        

        Destroy(referenceTile);

        float gridW = cols * tileSize;
        float gridH = rows * tileSize;
        transform.position = new Vector2(-gridW / 2 + tileSize / 2,    gridH / 2 - tileSize / 2);
    }

    
        ///////////////////////////InputField Rows
        public void PlaceShowRows()
    {
        
        rows = int.Parse(InputFieldWidth.text);
        
    }
        ///////////////////////////InputField Cols
        public void PlaceShowCols()
    {
         
        cols = int.Parse(InputFieldHeight.text);
            
    }

    public void BtnOnClick() 
    { 
        generateButton.GetComponent<Button>().interactable = false; 
    }

    
}

