using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;

namespace MilimorgMod.Dusts
{
    public class ChaosDust : ModDust
    {

        public override void OnSpawn(Dust dust)
        {
            dust.color = new Color(149, 0, 200);
            dust.alpha = 1;
            dust.scale = 1.3f;
           
            dust.noGravity = true;
            dust.noLight = false;

        }


        public override bool Update(Dust dust)
        {
            dust.position += dust.velocity;
            dust.rotation += dust.velocity.X * 0.15f;
            dust.scale *= 0.9f;
            float light = 0.99f * dust.scale;
            Lighting.AddLight(dust.position, 0.668f, 0, 0.8f);
            if (dust.scale < 0.5f)
            {
                dust.active = false;

            }
            return false;


        }


       

    }





}