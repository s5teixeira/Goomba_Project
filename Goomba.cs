class Goomba {
    protected int posX; //changed from private to protected 
    private int speed; 
    protected string[] goombaSprite;
    private bool direction;
    
    public Goomba (int speed) {
        posX= 0;
        this.speed = speed ;
        goombaSprite = new string[10];
        SetSprite();
        direction = true;
    }
    public void ChangeDir() {
        if (direction) direction= false;
        else direction = true; //true = right  false = left//
    }

    protected virtual void SetSprite() {  
         goombaSprite[0] = @"     ________  ";
         goombaSprite[1] = @"    /        \ ";
         goombaSprite[2] = @"   /  \    /  \ ";
         goombaSprite[3] = @"  /   |    |   \ ";
         goombaSprite[4] = @" /  -^------^-  \ ";
         goombaSprite[5] = @"|________________| ";
         goombaSprite[6] = @"      /    \ ";  
         goombaSprite[7] = @" ____|      |____ ";
         goombaSprite[8] = @"/____\ ==== /____\ ";
         goombaSprite[9] = @"                     ";
    }
    public virtual void DrawSprite() { //add virtual keyword to drawsprite in goomba 
        string spaces = " ";
    for ( int i=0; i<this.posX; i++)
    spaces += " ";
    foreach(string eachLine in goombaSprite)
    Console.WriteLine(spaces + eachLine);
    }

    public void UpdatePos() {
        if (direction) 
        posX += speed;
        else 
        posX -= speed;
    }
}