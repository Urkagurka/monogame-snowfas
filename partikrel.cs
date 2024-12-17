using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;


namespace Monogame_S
{
    public class partikrel
    {
        private int size;
        private Color color;
        private float speed = 160;
        private Vector2 position;
        private Texture2D texture;
        
        public partikrel(int size, Color color, Vector2 position, Texture2D texture){
            this.size       =   size;
            this.color      =   color;
            this.position   =  position;
            this.texture    =   texture;
        }

        public void Update(){
            float dt = 1f/60f;
            position.Y += speed*dt;
        }
        public void Draw(SpriteBatch spriteBatch){
            Rectangle r = new Rectangle((int)position.X,(int)position.Y,size,size);
            spriteBatch.Draw(texture,r,color);
        }
    }
}