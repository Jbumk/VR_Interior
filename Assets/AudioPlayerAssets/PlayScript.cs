using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayScript : MonoBehaviour
{


    private AudioSource AS;
    public List<AudioClip> AC=new List<AudioClip>();
    int num = 0;

    // Start is called before the first frame update
    public void Start()
    {
        AS = GetComponent<AudioSource>();
        


    }

    public void playSound() {
        if (AS.isPlaying == false)
        {
            AS.clip = AC[0];
            AS.Play();
        }
        
            
        

    }



    /*IEnumerator autoNext() {

        if (AS.isPlaying == true)
        {
            yield return new WaitForSeconds(AC[num].length);
        }
            nextSong();
        
            

    }*/

    public void pauseSound()
    {
        AS.Pause();

    }


    public void stopSound()
    {
        AS.Stop();

    }




    public void toggleLoop()
    {
        if (AS.loop == true)
            AS.loop = false;
        else
            AS.loop = true;

    }


    public void nextSong()
    {
        if (num < AC.Count-1)
        {



            AS.Stop();
            num++;




            AS.clip = AC[num];
            AS.Play();
        }

    }

    public void prevSong()
    {
        if (num > 0)
        {
            AS.Stop();
            num--;
            AS.clip = AC[num];
            AS.Play();

        }
    }

    public void checkNext() {
        if (AS.isPlaying == false)
            nextSong();

    }



    public void muteAudio() {
        if (AS.mute == true)
            AS.mute = false;
        else
            AS.mute = true;


    }
   









    // Update is called once per frame
    public void Update()
    {
        if (AS.time == AC[num].length&&AS.loop==false)
            nextSong();


    }
}
