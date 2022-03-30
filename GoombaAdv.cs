class GoombaAdv : Goomba
{
    
    private string[] goombaSpriteLeftFoot;
    private string[] goombaSpriteRightFoot;
    int var = 0;
    

    public GoombaAdv(int speed) : base(speed)
    {
        goombaSpriteLeftFoot = new string[10];
        goombaSpriteRightFoot = new string[10];
        SetSprite();
        
    }
         //DRAW SRPITE///////
    public override void DrawSprite()
    {         //posX
    string spaces = " ";
    for ( int i= 0; i < posX; i++) {
        spaces += " ";
        
    }
    if (var % 2 == 0) {
        foreach( string eachLine in goombaSpriteLeftFoot)
        System.Console.WriteLine(spaces + eachLine) ;
    } else 
    {
        foreach(string eachLine in goombaSpriteRightFoot)
        System.Console.WriteLine(spaces + eachLine) ;
    }
    var ++; //incement 
    }
    //SET SPRITE ////
    private void SetSprite()
    {     //LEFT FOOT  //    
goombaSpriteLeftFoot[0]=  @"    ________  ";
goombaSpriteLeftFoot[1]=  @"   /        \ ";
goombaSpriteLeftFoot[2]=  @"  /  \    /  \ ";
goombaSpriteLeftFoot[3]=@"   /   |    |   \ ";
goombaSpriteLeftFoot[4]=@"  /  -^------^-  \ ";
goombaSpriteLeftFoot[5]=@" |________________| ";
goombaSpriteLeftFoot[6]=@"  ____ /    \       ";  
goombaSpriteLeftFoot[7]=@" /____\      |____ ";
goombaSpriteLeftFoot[8]=@"        ==== /____\ ";
goombaSpriteLeftFoot[9]=@"                     ";

//RIGHT FOOT//
goombaSpriteRightFoot[0]=@"     ________  ";
goombaSpriteRightFoot[1]=@"    /        \ ";
goombaSpriteRightFoot[2]=@"   /  \    /  \ ";
goombaSpriteRightFoot[3]=@"  /   |    |   \ ";
goombaSpriteRightFoot[4]=@" /  -^------^-  \ ";
goombaSpriteRightFoot[5]=@"|________________| ";
goombaSpriteRightFoot[6]=@"      /    \ ____ ";
goombaSpriteRightFoot[7]=@" ____|      /____\ ";
goombaSpriteRightFoot[8]=@"/____\ ====         ";
goombaSpriteRightFoot[9]=@"                     ";


    }
}