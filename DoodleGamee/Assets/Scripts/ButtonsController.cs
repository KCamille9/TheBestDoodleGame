using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class ButtonsController : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public enum Directions {Left, Right, Up, Down }
    //__________________________________________________//

    [SerializeField] PlayerController playerController;
    [SerializeField] Directions buttonDirection;
    //__________________________________________________//

    private bool pointerDown;

    private bool isJumping;
    public float jumpTime;
    private float jumpTimeCounter;


    // Update is called once per frame
    void Update()
    {
        if (pointerDown)
        {
            if(buttonDirection.Equals(Directions.Right))
            {
                playerController.MoveRight();
            }
            else if (buttonDirection.Equals(Directions.Left))
            {
                playerController.MoveLeft();
            }

            else if (buttonDirection.Equals(Directions.Up))
            {
                /*isJumping = true;
                jumpTimeCounter = jumpTime;
                playerController.MoveUp();*/
                if(playerController.rb.velocity.y == 0)
                {
                    playerController.MoveUp();
                }
            }

            /*if (buttonDirection.Equals(Directions.Up) && isJumping)
            {
                if (jumpTimeCounter > 0)
                {
                    playerController.MoveUp();
                    jumpTimeCounter -= Time.deltaTime;
                }
                else
                {
                    pointerDown = false;
                }
            }*/

        }
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        pointerDown = true;
        Debug.Log("Pointer down");
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        pointerDown = false;
        Debug.Log("Pointer up");
    }

    public void ReloadScn()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
