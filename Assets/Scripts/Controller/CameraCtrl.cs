using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraCtrl : MonoBehaviour
{
    private GameObject player;
    private float smootf = 0.5f;
    private Vector2 speed;

    // Use this for initialization
    void Start()
    {
        transform.position = new Vector3(-1, -1, -10);

        Camera camera = GetComponent<Camera>();
        camera.orthographicSize = 1.8f;

        /*
        // choose the margin randomly
        float margin = Random.Range(0.0f, 0.3f);
        Debug.Log(margin);
        // setup the rectangle
        camera.rect = new Rect(margin, 0.0f, 1.0f - margin * 2.0f, 1.0f);
        */
        

       

        /*
        speed = new Vector2(0.5f, 0.5f);

        // set the desired aspect ratio (the values in this example are
        // hard-coded for 16:9, but you could make them into public
        // variables instead so you can set them at design time)
        float targetaspect = 16.0f / 9.0f;

        // determine the game window's current aspect ratio
        float windowaspect = (float)Screen.width / (float)Screen.height;

        // current viewport height should be scaled by this amount
        float scaleheight = windowaspect / targetaspect;

        // obtain camera component so we can modify its viewport
        Camera camera = GetComponent<Camera>();

        // if scaled height is less than current height, add letterbox
        if (scaleheight < 1.0f)
        {
            Rect rect = camera.rect;

            rect.width = 1.0f;
            rect.height = scaleheight;
            rect.x = 0;
            rect.y = (1.0f - scaleheight) / 2.0f;

            camera.rect = rect;
        }
        else // add pillarbox
        {
            float scalewidth = 1.0f / scaleheight;

            Rect rect = camera.rect;

            rect.width = scalewidth;
            rect.height = 1.0f;
            rect.x = (1.0f - scalewidth) / 2.0f;
            rect.y = 0;

            camera.rect = rect;
        }
        */
    }

    /*

    // Update is called once per frame
    void Update()
    {
        player = GameObject.FindGameObjectWithTag("Player");

        if (player != null)
        {
            //se o player está ainda antes da metade da tela, no ínicio do jogo, então não move a câmera
            if (player.transform.position.x <= 0)
            {
                transform.position = new Vector3(0, 0, transform.position.z);
            }
            else
            { //a câmera só acompanha o player quando o x do player atinger a metade da tela (no nosso caso o player está atingindo a metade da tela qdo for > 0)
                Follow();
            }
        }
    }

    private void Follow()
    {

        Vector2 positionCamera = Vector2.zero;

        positionCamera.x = Mathf.SmoothDamp(transform.position.x, player.transform.position.x, ref speed.x, smootf);
        positionCamera.y = Mathf.SmoothDamp(transform.position.y, player.transform.position.y, ref speed.y, smootf);

        //Vector3 newPosition = new Vector3 (positionCamera.x, positionCamera.y, transform.position.z);
        Vector3 newPosition = new Vector3(positionCamera.x, transform.position.y, transform.position.z);


        transform.position = Vector3.Lerp(transform.position, newPosition, Time.time);
    }
    */
}
