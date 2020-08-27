using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MilimorgMod.Items
{

    public class KeenEye : ModItem
    {

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Keen Eye");
            Tooltip.SetDefault("In your hands is the strength of the most vigilant and powerful archers. Now it is your strength!");
        }

        public override void SetDefaults()
        {
            item.Size = new Vector2(20, 30);
            item.rare = 1;
            item.value = Item.sellPrice(gold: 1, silver: 5);

            item.useTime = 15;
            item.useAnimation = 25;
            item.useStyle = 5;
            item.UseSound = SoundID.Item5;

            item.noMelee = true;
            item.ranged = true;
            item.damage = 15;
            item.crit = 15;

            item.useAmmo = AmmoID.Arrow;
            item.shoot = 2;
            item.shootSpeed = 15f;

        }

        public override void AddRecipes()
        {

            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod, "OdamireOre", 10);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();

        }





    }


}