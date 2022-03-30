class Star {
    private int posX;
    private string[] starSprite;
    
    public Star(int posX) {
        this.posX = posX;
        starSprite = new String[6];
        SetSprite(); //for star image to starsprite
    }
    private void SetSprite() {
starSprite[0] = @"          ";
starSprite[1] = @"  ___/\___";
starSprite[2] = @"  \  ||  / ";
starSprite[3] = @"  /__  __\";
starSprite[4] = @"     \/   ";
starSprite[5] = @"          ";  
      
 }
 public void DrawSprite () { //draw startssprites at posx
    string spaces = " ";
    for ( int i=0; i<this.posX; i++)
    spaces += " ";
    foreach(string eachLine in starSprite)
    Console.WriteLine(spaces + eachLine);

 }
}