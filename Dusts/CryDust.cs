using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;

namespace MilimorgMod.Dusts
{
    public class CryDust : ModDust
    {

        public override void OnSpawn(Dust dust)
        {
            dust.color = new Color(152, 0, 5);
            dust.alpha = 1;
            dust.scale = 2.1f;
           
            dust.noGravity = true;
            dust.noLight = false;

        }


        public override bool Update(Dust dust)
        {
            dust.position += dust.velocity;
            dust.rotation += dust.velocity.X * 0.15f;
            dust.scale *= 0.9f;
            float light = 0.70f * dust.scale;
            Lighting.AddLight(dust.position, 0.675f, 0, 0.02f);
            if (dust.scale < 0.5f)
            {
                dust.active = false;

            }
            return false;


        }


       

    }





}