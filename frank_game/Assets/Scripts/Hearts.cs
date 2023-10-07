using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Hearts : MonoBehaviour
{
    public GameObject[] hearts;
   
    public int lives;
    public PolygonCollider2D safeZone;
    private bool canLoseLife;
    // Start is called before the first frame update
    void Start()
    {
        lives = 9;
        canLoseLife = true;
    }

    // Update is called once per frame
    void Update()
    {
       
        
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision == safeZone && canLoseLife == true) {

            canLoseLife=false;
            StartCoroutine(loseLife());
            Debug.Log("collision");
        }

    }

    IEnumerator loseLife()
    {
        yield return new WaitForSeconds(1);
        lives -= 1;
        hearts[lives].SetActive(false);
        canLoseLife = true;
        Debug.Log("Lives: " +  lives);

    }
}
