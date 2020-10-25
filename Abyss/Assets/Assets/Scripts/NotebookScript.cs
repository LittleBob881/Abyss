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
    public GameObject OpenButton;

    public GameObject view;
    public Sprite[] sprites;
    public Image activePage;
    public Image page0;

    // Start is called before the first frame update
    void Awake()
    {
        //Makes a sprite array of all of the pages 
        loadPages();

        //Makes the notebook with all the pages
        createNoteBook();

        //Set up for each of the buttons and sets the appropriate action listeners
        Button next = NextButton.GetComponent<Button>();
        next.onClick.AddListener(turnForwardPage);

        Button back = BackButton.GetComponent<Button>();
        back.onClick.AddListener(turnBackPage);

        Button exit = exitButton.GetComponent<Button>();
        exit.onClick.AddListener(ExitTaskOnClick);

        Button open = OpenButton.GetComponent<Button>();
        open.onClick.AddListener(OpenOnClick);

        //Sets the image on the left side of the screen to page 0
        Image firstPage = page0.GetComponent<Image>();
        firstPage.sprite = sprites[0];

        //Sets the image on the right side of the screen to page 1
        Image active = activePage.GetComponent<Image>();
        active.sprite = sprites[1];

        view.gameObject.SetActive(false);
    }
    //Loads the sprites into an array for the notebook pages 
    private void loadPages()
    {
        sprites = new Sprite[10];
        Sprite[] spritesload = Resources.LoadAll<Sprite>("Pagespage");
        for (int k = 0; k < 8; k++)
        {
            sprites[k] = spritesload[k];
        }
        sprites[8] = Resources.Load<Sprite>("dogNews");
        sprites[9] = Resources.Load<Sprite>("dogPage");
    }

    void OpenOnClick()
    {
        view.gameObject.SetActive(true);
    }

    //Is called as the action listener for the exit button and will close the notebook
    void ExitTaskOnClick()
    {
        view.gameObject.SetActive(false);
    }

    //Is called as the action listener for the back button and will turn back the page if another page is unlocked previous to the active page
    public void turnBackPage()
    {
        noteBookPage page = playerNoteBook.turnPageBack();

        //If it is going back to the first page also will show page 0
        if(page.getPageNum() == 1)
        {
            page0.enabled = true;
        }

        //Sets the image in Unity to the new active page
        Image active = activePage.GetComponent<Image>();
        activePage.sprite = page.getPage();
    }

    //Is called as the action listener for the next button and will turn forward the page if there is an unlocked page after the active page
    public void turnForwardPage()
    {
        noteBookPage page = playerNoteBook.turnPageForward();

        //If it is going back to the first page also will show page 0
        if (page.getPageNum() > 1)
        {
            page0.enabled = false;
        }

        //Sets the image in Unity to the new active page
        Image active = activePage.GetComponent<Image>();
        activePage.sprite = page.getPage();

    }

    //Is called at the start of a new game to make the notebook and initialize all the pages into an array
    public void createNoteBook()
    {
        playerNoteBook = new NoteBook();

        //Creates all of the pages into one notebook
        for(int i = 0; i < sprites.Length; i++)
        {
            noteBookPage page = new noteBookPage(sprites[i], i);
            playerNoteBook.addNoteBookPage(page);
            playerNoteBook.unlockPage(i); //Unlocking all pages for this sprint

            //Sets the first page to the active page
            if (i == 1)
            {
                playerNoteBook.setActivePage(page);
            }
        }

        playerNoteBook.unlockPage(0);
        playerNoteBook.unlockPage(1);
    }

    //Changes pageImage by number 
    public void ChangePageImage(Sprite image, int pageNumber)
    {
        Debug.Log("in notebook");
        playerNoteBook.updatePage(image, pageNumber);
    }
}




//Notebook Page Class - Has the information that each page needs and the needed getters and setters for each attribute
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

    public void setPage(Sprite page)
    {
        this.page = page;
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

//Notebook Class - Has a list of the notebook pages and methods needed for turning pages and setting page information
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
    public noteBookPage turnPageForward()
    {
        Boolean found = false;
        noteBookPage current = activePage;
        int count = activePageNum;

        //Checks while there are pages left until the next unlocked page is found 
            //Else will leave the active page as the original page
        for(int i = count; i < numPages-1; i++)
        {
            current = pages[++count];
            found = current.getUnlocked();

            //If the page is unlocked then the active page is set to the current page and the loop is broken
            if (found == true)
            {
                i = numPages;
                this.setActivePage(current);
                return current;
            }
        }

        //If unlocked page not found returns the original active page
        return activePage;
    }

    //Checks to see if there is a page before the current page and if so changes the active page to the previous page
    public noteBookPage turnPageBack()
    {
        Boolean found = false;
        noteBookPage current = pages[activePageNum];
        int count = activePageNum;

        //Checks while there are pages left before of the active page until the first unlocked page is found 
            //Else will leave the active page as the original page
        for (int i = count; i > 1; i--)
        {
            current = pages[--count];
            found = current.getUnlocked();
            if(found == true)
            {
                i = -1; //Breaks loop if unlocked page is found
                this.setActivePage(current); //Sets current page to the active page
            }
        }

        return activePage;
    }

    //Returns the active pages sprite
    public noteBookPage getActivePage()
    {
        return pages[activePageNum];
    }

    //Sets the active page to the passed in page and also sets the page number to the passes in pages number
    public void setActivePage(noteBookPage page)
    {
        activePage = page;
        activePageNum = page.getPageNum();
    }

    public noteBookPage getPage(int pageNum)
    {
        return pages[pageNum];
    }

    public void updatePage(Sprite page, int pageNum)
    {
        pages[pageNum].setPage(page);
    }
}
