using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NotebookScript : MonoBehaviour
{
    private static NoteBook playerNoteBook;
    public GameObject exitButton;
    public GameObject NextButton;
    public GameObject BackButton;

    public GameObject view;
    public Sprite[] sprites;

    // Start is called before the first frame update
    void Start()
    {
        createNoteBook();

        //Load in Sprites (ask Judith how to make a resource sheet and how that is impletemented)
        //sprites = Resources.LoadAll<Sprite>("Itemsheet_6");

        Button next = NextButton.GetComponent<Button>();
        next.onClick.AddListener(turnForwardPage);

        Button back = BackButton.GetComponent<Button>();
        next.onClick.AddListener(turnBackPage);

        Button exit = exitButton.GetComponent<Button>();
        next.onClick.AddListener(ExitTaskOnClick);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void ExitTaskOnClick()
    {
        Debug.Log("You have clicked the button!");
        view.gameObject.SetActive(false);

    }

    public void turnBackPage()
    {
        playerNoteBook.turnPageBack();
    }

    public void turnForwardPage()
    {
        playerNoteBook.turnPageForward();
    }

    public void createNoteBook()
    {
        playerNoteBook = new NoteBook();

        for(int i = 0; i < sprites.Length; i++)
        {
            noteBookPage page = new noteBookPage(sprites[i], i);
            playerNoteBook.addNoteBookPage(page);
            //don't unlock all 
            playerNoteBook.unlockPage(i);
            if(i == 1)
            {
                playerNoteBook.setActivePage(page);
            }
        }

    }
}

public class noteBookPage
{
    private Sprite page;
    private int pageNum;
    private Boolean unlocked;

    public noteBookPage(Sprite page, int pageNum)
    {
        this.page = page;
        this.pageNum = pageNum;
        this.unlocked = false;
    }

    public Sprite getPage()
    {
        return this.page;
    }

    public int getPageNum()
    {
        return this.pageNum;
    }

    public Boolean getUnlocked()
    {
        return this.unlocked;
    }

    public void setUnlocked(Boolean unlocked)
    {
        this.unlocked = unlocked;
    }
}

public class NoteBook
{
    private List<noteBookPage> pages;
    private static noteBookPage activePage;
    private int activePageNum;
    private int numPages;

    //For loading a saved games notebook
    public NoteBook(List<noteBookPage> pages)
    {
        this.pages = pages;
        activePage = pages[0];
        activePageNum = activePage.getPageNum();
        numPages = pages.Count;
    }

    //For starting a new game
    public NoteBook()
    {
        this.pages = new List<noteBookPage>();
    }

    //Is used to generate the notebook at the beginning with pages
    //Title page is page 0 in array
    public void addNoteBookPage(noteBookPage page)
    {
        this.pages.Add(page);
        this.numPages++;
    }

    //Is called to unlock the page at the page number given (Page 0 is the title page)
    public void unlockPage(int pageNum)
    {
        pages[pageNum].setUnlocked(true);
    }

    //Checks to see if there is another page and changes the active page to the next page
    public void turnPageForward()
    {
        activePageNum = activePage.getPageNum();
        Boolean stop = false;
        Boolean found = false;
        noteBookPage current = pages[activePageNum];
        int count = activePageNum;
        while(!stop)
        {
            current = pages[++count];
            if(current.getPageNum() < numPages)
            {
                found = current.getUnlocked();
                if(found == true)
                {
                    stop = true;
                }
            }
            else
            {
                stop = true;
            }
        }
        
        if(found == true)
        {
            activePage = current;
            activePageNum = count;
        }
    }

    //Checks to see if there is a page before the current page and if so changes the active page to the previous page
    public void turnPageBack()
    {
        activePageNum = activePage.getPageNum();
        Boolean stop = false;
        Boolean found = false;
        noteBookPage current = pages[activePageNum];
        int count = activePageNum;
        while (!stop)
        {
            current = pages[--count];
            if (current.getPageNum() > 0)
            {
                found = current.getUnlocked();
                if (found == true)
                {
                    stop = true;
                }
            }
            else
            {
                stop = true;
            }
        }

        if (found == true)
        {
            activePage = current;
            activePageNum = count;
        }
    }

    //Returns the active pages sprite
    public Sprite getActivePage()
    {
        return activePage.getPage();
    }

    public void setActivePage(noteBookPage page)
    {
        activePage = page;
        activePageNum = page.getPageNum();
    }
}
