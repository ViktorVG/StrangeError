using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MilimorgMod.Items.Armor
{
    [AutoloadEquip(EquipType.Wings)]
    public class AirCoat : ModItem
    {
        public override bool Autoload(ref string name)
        {
            return base.Autoload(ref name);
        }

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Air Coat"); //название объекта в игре
            Tooltip.SetDefault("The initial flight levels are now available to you");

        }

        public override void SetDefaults()
        {
            item.width = 42;
            item.height = 40;
            item.value = 2010;
            item.rare = 1;
            item.accessory = true;
        }

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.wingTimeMax = 6;


        }

        public override void VerticalWingSpeeds(Player player, ref float ascentWhenFalling, ref float ascentWhenRising, ref float maxCanAscendMultiplier, ref float maxAscentMultiplier, ref float constantAscend)
        {
            ascentWhenFalling = 0.4f;
            ascentWhenRising = 0.5f;
            maxCanAscendMultiplier = 3f;
            maxAscentMultiplier = 3f;
            constantAscend = 1f;
            
        }

        public override void HorizontalWingSpeeds(Player player, ref float speed, ref float acceleration)
        {
            speed = 0.8f;
            acceleration = 1f;
            
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Silk, 15);
            recipe.AddIngredient(ItemID.FallenStar, 5);
            recipe.AddTile(TileID.Loom);
            recipe.SetResult(this);
            recipe.AddRecipe();

        }
    }
}
