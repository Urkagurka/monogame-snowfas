using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Monogame_S
{
    public class partikelsystem
    {
        List<partikrel> particles = new List<partikrel>();
        Texture2D texture;
        Random random = new Random();
        public partikelsystem(Texture2D texture){
            this.texture=texture;
        }
        private void SpawnParticle(){
            if(random.Next(1,101)<50){
                particles.Add(CreateParticle());
            }
        }
        private partikrel CreateParticle(){
            int size = random.Next(1,20);
            float x = random.Next(0,800);
            Vector2 position = new Vector2(x,-20);

            return new partikrel(size,Color.GhostWhite,position,texture);
        }
        
        public void Update(){
            foreach(partikrel particle in particles){
                particle.Update();
            }
            SpawnParticle();
        }
        public void Draw(SpriteBatch spriteBatch){
            foreach(partikrel particle in particles){
                particle.Draw(spriteBatch);
            }
        }
    }
}